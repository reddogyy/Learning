
var firstNumber = prompt("Please enter first number :");
var secondNumber = prompt("Please enter second number :");
var thirdNumber = prompt("Please enter third number :");

if (firstNumber > secondNumber) {
    result = firstNumber;
    if (firstNumber > thirdNumber) {
        document.writeln("The biggest number is  : " + firstNumber);
    } else {
        document.writeln("The biggest number is  : " + thirdNumber);
    }
} else {
    if (secondNumber > thirdNumber) {
        document.writeln("The biggest number is  : " + secondNumber);
    } else {
        document.writeln("The biggest number is  : " + thirdNumber);
    }

}

