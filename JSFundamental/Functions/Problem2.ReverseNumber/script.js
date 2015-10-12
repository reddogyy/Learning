var userInput = prompt("Please enter a number");


function reverse(number) {
    var result=[];
    var temp = number.toString();
    for (var i = number.length - 1; i >= 0; i--)
    {
        result+=temp[i];
    }
    document.writeln(result);
}
reverse(userInput);