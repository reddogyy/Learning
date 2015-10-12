var userInput = prompt("Please enter a number");


function lastDigit(number) {
    var lastChar = number % 10;
    switch (lastChar) {
        case 0: document.writeln("zero"); return 0;
        case 1: document.writeln("one"); return 0;
        case 2: document.writeln("two"); return 0;
        case 3: document.writeln("three"); return 0;
        case 4: document.writeln("four"); return 0;
        case 5: document.writeln("five"); return 0;
        case 6: document.writeln("six"); return 0;
        case 7: document.writeln("seven"); return 0;
        case 8: document.writeln("eight"); return 0;
        case 9: document.writeln("nine"); return 0;
        default: document.writeln("invalid number"); return 0;
    }
}
lastDigit(userInput);