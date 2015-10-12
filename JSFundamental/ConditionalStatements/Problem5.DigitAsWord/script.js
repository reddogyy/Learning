
var userInput = prompt("Please enter a number :");

function digitAsWord(number) {
    if (typeof (number) == String || number < 0) {
        return console.log("not a digit");
    }

    var integer = parseInt(number);



    switch (integer) {
        case 0 : document.writeln( "zero") ;break;
        case 1 : document.writeln( "one")  ;break;
        case 2 : document.writeln( "two")  ;break;
        case 3 : document.writeln( "three");break;
        case 4 : document.writeln( "four") ;break;
        case 5 : document.writeln( "five") ;break;
        case 6 : document.writeln( "six")  ;break;
        case 7 : document.writeln( "seven");break;
        case 8 : document.writeln( "eight");break;
        case 9: document.writeln("nine")   ;break;
    }
}

digitAsWord(userInput);