
var firstNumber = prompt("Please enter first number :");
var secondNumber = prompt("Please enter second number :");
var thirdNumber = prompt("Please enter third number :");
var fouthNumber = prompt("Please enter fourth number :");
var fifthNumber = prompt("Please enter fifth number :");


if (firstNumber > secondNumber) {
    if (firstNumber > thirdNumber) {
        if (firstNumber > fouthNumber) {
            if (firstNumber > fifthNumber) {
                document.writeln("The biggest number is  : " + firstNumber);
            }
        }

    }
}

else if (secondNumber > thirdNumber) {
    if (secondNumber > fouthNumber) {
        if (secondNumber > fifthNumber) {
            document.writeln("The biggest number is  : " + secondNumber);
        }
    }

} else if (thirdNumber > fouthNumber) {
    if (thirdNumber > fifthNumber) {
        document.writeln("The biggest number is  : " + thirdNumber);
    }
} else if (fouthNumber > fifthNumber) {
    document.writeln("The biggest number is  : " + fouthNumber);
} else {
    document.writeln("The biggest number is  : " + fifthNumber);
}



