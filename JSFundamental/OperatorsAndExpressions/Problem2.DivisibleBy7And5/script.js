
var userInput = prompt("Please enter a number :");
var result;
if ((userInput % 5 == 0)&&(userInput % 7 == 0)) {
    result = "The entered number is divisible by 5 and 7 ";
} else {
    result = " The entered number is not divisible by 5 and 7";
}
document.write( result);