document.addEventListener('DOMContentLoaded', function() {
    const textElement = document.getElementById('text');
    const increaseBtn = document.getElementById('increaseBtn');
    const decreaseBtn = document.getElementById('decreaseBtn');
    const sizeInput = document.getElementById('sizeInput');

    let currentSize = 16;

    function updateSize() {
        textElement.style.fontSize = `${currentSize}px`;
        sizeInput.value = currentSize;
    }

    increaseBtn.addEventListener('click', function() {
        if (currentSize < 48) {
            currentSize++;
        } else {
            currentSize = 16;
        }
        updateSize();
    });

    decreaseBtn.addEventListener('click', function() {
        if (currentSize > 8) {
            currentSize--;
        } else {
            currentSize = 16;
        }
        updateSize();
    });

    sizeInput.addEventListener('input', function() {
        let newSize = parseInt(sizeInput.value);
        if (newSize >= 8 && newSize <= 48) {
            currentSize = newSize;
            updateSize();
        }
    });
});