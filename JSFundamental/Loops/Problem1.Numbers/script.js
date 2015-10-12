
var userInput = prompt("Please enter a number :");

function printNumber(number) {
    for (var i = 1; i <= number; i++) {
        document.writeln(i);
    }
}
printNumber(userInput);