var userInput = prompt("Please enter a number :");
var result = String(userInput).charAt(2);

result = (userInput / 100) % 10;
var digit = result.toString()[0];
if( digit =='7'){
document.write("The third digit is 7 ");
}
else {
    document.write("the third digit is not 7");
}