
var firstNumber = prompt("Please enter first number :");
var secondNumber = prompt("Please enter second number :");
var thirdNumber = prompt("Please enter third number :");
var result,
    isPositive =true;
if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0) {
    document.writeln("the result is 0");
} else {
    if (firstNumber < 0) {
        isPositive = !isPositive;
    }
    if (secondNumber < 0) {
        isPositive = !isPositive;
    }
    if (thirdNumber < 0) {
        isPositive = !isPositive;
    }
    if (isPositive == true) {
        document.writeln("the product is with sign +");
    } else {
        document.writeln("the product is with sign -");
    }
}