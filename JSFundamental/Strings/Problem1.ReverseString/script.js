
var userInput = prompt("Please enter a number :");


function reverseString(userInput) {

        var result = '';
        for (var i = userInput.length - 1; i >= 0; i--)
            result += userInput[i];
        console.log(result);
    
}

reverseString(userInput);