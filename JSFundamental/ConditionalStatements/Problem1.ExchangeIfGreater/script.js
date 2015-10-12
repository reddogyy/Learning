
var firstNumber = prompt("Please enter first number :");
var secondNumber = prompt("Please enter second number :");

if (firstNumber > secondNumber) {
    document.writeln(firstNumber + " " + secondNumber);
}else if(secondNumber >firstNumber){
    document.writeln(secondNumber + " " + firstNumber);
} else {
    document.writeln("numbers are equal");
}