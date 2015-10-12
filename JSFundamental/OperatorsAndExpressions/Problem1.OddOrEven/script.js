
var userInput = prompt("Please enter a number :");
var result;
if (userInput % 3 === 0) {
    result = "odd";
} else if (userInput % 2 === 0) {
    result = "even";
}
document.write("number is : " + result);