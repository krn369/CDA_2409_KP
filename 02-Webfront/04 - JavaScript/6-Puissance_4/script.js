// ===== GAME CONSTANTS =====
// These never change during the game

// Number of rows in the game board (standard Connect 4 has 6 rows)
const ROWS = 6;

// Number of columns in the game board (standard Connect 4 has 7 columns)
const COLS = 7;

// Player definitions with their colors
const PLAYERS = {
    ONE: 'yellow',  // Player 1 uses yellow pieces
    TWO: 'red'      // Player 2 uses red pieces
};

// ===== GAME STATE VARIABLES =====
// These track the current state of the game

let currentPlayer = PLAYERS.ONE; // Tracks whose turn it is (starts with Player 1)
let board = [];                 // 2D array representing the game board
let gameOver = false;           // Becomes true when game ends (win or draw)

// ===== GAME INITIALIZATION =====
// Runs when the page loads

// Wait for the HTML document to fully load before running our JavaScript
document.addEventListener('DOMContentLoaded', () => {
    createBoard(); // Set up the game board
    
    // Add click event listener to the reset button
    document.getElementById('reset-btn').addEventListener('click', resetGame);
    
    // Set initial status message
    updateStatus("Player 1's turn (Yellow)", 'player1');
});

// ===== BOARD CREATION =====
// Builds the visual and logical game board

function createBoard() {
    // Get the game board container element from HTML
    const gameBoard = document.getElementById('game-board');
    
    // Clear any existing content in the game board
    gameBoard.innerHTML = '';
    
    // Initialize the board as a 2D array filled with null values
    // Array(ROWS).fill() creates an array with 6 empty slots
    // .map() creates a new array for each row with 7 null values
    board = Array(ROWS).fill().map(() => Array(COLS).fill(null));
    
    // Create each cell in the game board
    for (let row = 0; row < ROWS; row++) {
        for (let col = 0; col < COLS; col++) {
            // Create a new div element for each cell
            const cell = document.createElement('div');
            
            // Add CSS class for styling
            cell.classList.add('cell');
            
            // Store column number as a data attribute
            cell.dataset.col = col;
            
            // Add click event listener - calls handleColumnClick with column number
            cell.addEventListener('click', () => handleColumnClick(col));
            
            // Add the cell to the game board
            gameBoard.appendChild(cell);
        }
    }
}

// ===== GAME LOGIC =====
// Handles player moves and game rules

// Called when a player clicks on a column
function handleColumnClick(col) {
    // If game is already over, do nothing
    if (gameOver) return;
    
    // Find the first available row in this column (pieces stack from bottom)
    const row = findAvailableRow(col);
    
    // If column is full (no available row), do nothing
    if (row === -1) return;
    
    // Place the current player's piece in this position
    placePiece(row, col);
    
    // Check if this move caused a win
    if (checkWin(row, col)) {
        gameOver = true; // Game ends
        
        // Highlight the winning pieces
        highlightWinningCells(row, col);
        
        // Update status message with win announcement
        updateStatus(
            `Player ${currentPlayer === PLAYERS.ONE ? '1 (Yellow)' : '2 (Red)'} WINS! 🎉`, 
            'win'
        );
        return;
    }
    
    // Check if the board is full (draw)
    if (checkDraw()) {
        gameOver = true; // Game ends
        updateStatus("It's a DRAW! 🤝", 'draw');
        return;
    }
    
    // Switch to the other player
    currentPlayer = currentPlayer === PLAYERS.ONE ? PLAYERS.TWO : PLAYERS.ONE;
    
    // Update status message for next player's turn
    updateStatus(
        `Player ${currentPlayer === PLAYERS.ONE ? '1' : '2'}'s turn (${currentPlayer === PLAYERS.ONE ? 'Yellow' : 'Red'})`, 
        currentPlayer === PLAYERS.ONE ? 'player1' : 'player2'
    );
}

// Finds the lowest empty row in a column
function findAvailableRow(col) {
    // Start from bottom row (row 5) and go upwards
    for (let row = ROWS - 1; row >= 0; row--) {
        // If this cell is empty (null), return the row number
        if (board[row][col] === null) return row;
    }
    // If column is full, return -1
    return -1;
}

// Places a piece on the board
function placePiece(row, col) {
    // Update our board array with current player's color
    board[row][col] = currentPlayer;
    
    // Get all cell elements from the DOM
    const cells = document.querySelectorAll('.cell');
    
    // Calculate which cell in the HTML this corresponds to
    // Formula: (row * number of columns) + column
    const cellIndex = row * COLS + col;
    
    // Add the player's color class to the cell (changes its appearance)
    cells[cellIndex].classList.add(currentPlayer);
}

// Checks if the last move caused a win
function checkWin(row, col) {
    // Directions to check: horizontal, vertical, both diagonals
    const directions = [
        [0, 1],  // Horizontal (right/left)
        [1, 0],  // Vertical (up/down)
        [1, 1],  // Diagonal (down-right/up-left)
        [1, -1]  // Diagonal (down-left/up-right)
    ];

    // Check each direction to see if there are 4 in a row
    // .some() returns true if any direction has 4+ in a row
    return directions.some(([dx, dy]) => 
        countConsecutive(row, col, dx, dy) >= 4
    );
}

// Counts consecutive pieces in a line (both directions)
function countConsecutive(row, col, dx, dy) {
    let count = 1; // Start with the current piece
    
    // Count in positive direction (e.g., to the right)
    count += countInDirection(row, col, dx, dy);
    
    // Count in negative direction (e.g., to the left)
    count += countInDirection(row, col, -dx, -dy);
    
    return count;
}

// Helper function to count pieces in one direction
function countInDirection(row, col, dx, dy) {
    let count = 0;
    // Start from next cell in this direction
    let r = row + dx;
    let c = col + dy;
    
    // While we're still on the board and the pieces match current player
    while (r >= 0 && r < ROWS && c >= 0 && c < COLS && board[r][c] === currentPlayer) {
        count++; // Increment count
        r += dx; // Move further in this direction
        c += dy;
    }
    
    return count;
}

// Checks if the board is full (draw)
function checkDraw() {
    // Check if top row is completely filled (no more moves possible)
    return board[0].every(cell => cell !== null);
}

// ===== VISUAL EFFECTS =====
// Highlights the winning pieces

function highlightWinningCells(row, col) {
    // Directions to check (same as win check)
    const directions = [
        [0, 1], [1, 0], [1, 1], [1, -1]
    ];

    // Check each direction
    for (const [dx, dy] of directions) {
        const winningCells = []; // Store winning cells
        winningCells.push({row, col}); // Add current cell
        
        // Check in positive direction
        let r = row + dx;
        let c = col + dy;
        while (r >= 0 && r < ROWS && c >= 0 && c < COLS && board[r][c] === currentPlayer) {
            winningCells.push({row: r, col: c});
            r += dx;
            c += dy;
        }
        
        // Check in negative direction
        r = row - dx;
        c = col - dy;
        while (r >= 0 && r < ROWS && c >= 0 && c < COLS && board[r][c] === currentPlayer) {
            winningCells.push({row: r, col: c});
            r -= dx;
            c -= dy;
        }
        
        // If we found 4+ in a row
        if (winningCells.length >= 4) {
            // Highlight exactly 4 winning cells
            winningCells.slice(0, 4).forEach(({row, col}) => {
                const cellIndex = row * COLS + col;
                const cell = document.querySelectorAll('.cell')[cellIndex];
                
                // Add winning class for animation
                cell.classList.add('winning-cell');
                
                // Add white dot marker
                cell.innerHTML = '<div class="winning-marker"></div>';
            });
            return; // Stop checking other directions
        }
    }
}

// ===== GAME STATUS UPDATES =====
// Updates the status message with appropriate styling

function updateStatus(message, state) {
    const statusElement = document.getElementById('status');
    statusElement.textContent = message; // Set the message text
    
    // Remove all status classes first
    statusElement.className = '';
    
    // Add appropriate class based on game state
    switch(state) {
        case 'player1': // Player 1's turn
            statusElement.classList.add('status-player1');
            break;
        case 'player2': // Player 2's turn
            statusElement.classList.add('status-player2');
            break;
        case 'win': // Win message
            // Use current player's color
            statusElement.classList.add(currentPlayer === PLAYERS.ONE ? 'status-player1' : 'status-player2');
            statusElement.classList.add('status-win'); // Add win animation
            break;
        case 'draw': // Draw message
            statusElement.classList.add('status-draw'); // Split background
            break;
    }
}

// ===== GAME RESET =====
// Resets the game to initial state

function resetGame() {
    currentPlayer = PLAYERS.ONE; // Player 1 starts
    gameOver = false;           // Reset game over flag
    createBoard();              // Recreate the board
    updateStatus("Player 1's turn (Yellow)", 'player1'); // Reset status
}