
var userInput = prompt("Please enter a number :");

var isValid = isValidExpression(userInput);

console.log(isValid);

function isValidExpression(exp) {
    var bracketCount = 0;

    for (i = 0; i < exp.length; i++) {
        if (exp[i] == '(') {
            bracketCount++;
        }
        else if (exp[i] == ')') {
            bracketCount--;
        }

        if (bracketCount < 0) {
            return false;
        }
    }

    return bracketCount === 0;
}
