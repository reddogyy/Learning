
var userInput = prompt("Please enter a number :");

function notDivisibleNumbers(number) {
    for (i = 1; i <= number; i++) {
        if (((i % 3) == 0) || ((i % 7) == 0)) {

        }
        else {
            document.writeln(" ", i);
        }
    }
}
notDivisibleNumbers(userInput);