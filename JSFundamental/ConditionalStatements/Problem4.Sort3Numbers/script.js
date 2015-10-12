
var firstNumber = prompt("Please enter first number :");
var secondNumber = prompt("Please enter second number :");
var thirdNumber = prompt("Please enter third number :");
var bigNumber,
    littleNumber,
    smallNumber;
if (firstNumber > secondNumber) {
    
    if (firstNumber > thirdNumber) {
        bigNumber = firstNumber;
        if (secondNumber > thirdNumber) {
            littleNumber = secondNumber;
            smallNumber = thirdNumber;
        } else {
            littleNumber = thirdNumber;
            smallNumber = secondNumber;
        }
    } else {
        bigNumber = thirdNumber;
        littleNumber = firstNumber;
        smallNumber = secondNumber;
    }
} else {
    if (secondNumber > thirdNumber) {
        bigNumber = secondNumber;
        if (firstNumber > thirdNumber) {
            littleNumber = firstNumber;
            smallNumber = thirdNumber;
        } else {
            littleNumber = thirdNumber;
            smallNumber = firstNumber;
        }
    } else {
        bigNumber = thirdNumber;
        littleNumber = secondNumber;
        smallNumber = firstNumber;
    }

}
document.writeln(bigNumber + " " + littleNumber + " " + smallNumber);

