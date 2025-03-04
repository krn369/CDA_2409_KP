// Wait until the page is fully loaded
document.addEventListener("DOMContentLoaded", () => {
  // Select elements
  const countDisplay = document.getElementById("count");
  const incrementButton = document.getElementById("increment");
  const resetButton = document.getElementById("reset");

  let count = 0; // Counter starts at 0

  // Function to increment count
  incrementButton.addEventListener("click", () => {
    count++; // Increase count by 1
    countDisplay.textContent = count; // Update displayed count
  });

  // Function to reset count
  resetButton.addEventListener("click", () => {
    count = 0; // Reset count to 0
    countDisplay.textContent = count; // Update displayed count
  });
});
