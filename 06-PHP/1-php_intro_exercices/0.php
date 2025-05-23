Sure! Let's break down the question, logic, and solution step by step:

### Question
You need to create a function called `getMax()` in PHP. This function should:
1. Accept three arguments of type `float`.
2. Return the largest value among the three numbers, limited to three decimal places.
3. If at least two of the provided values are equal, the function should return `0`.

### Logic
1. **Check for Equality**: First, the function checks if any two of the three numbers are equal. If they are, it returns `0`.
2. **Find the Maximum Value**: If none of the numbers are equal, the function finds the largest number among the three.
3. **Limit to Three Decimal Places**: The function then rounds the largest number to three decimal places before returning it.

### Solution
Here's the PHP code that implements this logic:

```php
<?php
function getMax(float $a, float $b, float $c) : float {
    // Check if at least two values are equal
    if ($a == $b || $a == $c || $b == $c) {
        return 0.0;
    }

    // Find the maximum value among the three
    $maxValue = max($a, $b, $c);

    // Limit the result to 3 decimal places
    return round($maxValue, 3);
}

// Examples of usage
echo getMax(1.23456, 2.34567, 3.45678); // returns « 3.457 »
echo getMax(1.23456, 1.23456, 3.45678); // returns « 0 »
echo getMax(1.23456, 2.34567, 2.34567); // returns « 0 »
echo getMax(1.23456, 2.34567, 1.23456); // returns « 0 »
?>
```

### Explanation
1. **Function Definition**: `function getMax(float $a, float $b, float $c) : float {`
   - This line defines the function `getMax` which takes three floating-point numbers as arguments and returns a floating-point number.

2. **Check for Equality**: `if ($a == $b || $a == $c || $b == $c) { return 0.0; }`
   - This part checks if any two of the three numbers are equal. If they are, the function returns `0.0`.

3. **Find Maximum Value**: `$maxValue = max($a, $b, $c);`
   - This line finds the largest number among the three using the `max()` function.

4. **Round to Three Decimal Places**: `return round($maxValue, 3);`
   - This line rounds the largest number to three decimal places using the `round()` function and returns it.

### Examples
- `getMax(1.23456, 2.34567, 3.45678)` returns `3.457` because `3.45678` is the largest number, rounded to three decimal places.
- `getMax(1.23456, 1.23456, 3.45678)` returns `0` because `1.23456` appears twice.
- `getMax(1.23456, 2.34567, 2.34567)` returns `0` because `2.34567` appears twice.
- `getMax(1.23456, 2.34567, 1.23456)` returns `0` because `1.23456` appears twice.

I hope this explanation helps! If you have any more questions or need further clarification, feel free to ask! 😊