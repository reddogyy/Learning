var numberS = prompt("pleases enter a number : ");
document.writeln(solveTask(numberS));
function solveTask(number) {
    if (number <= 3) {
        return number > 1;
    }
    if (number % 2 == 0 || number % 3 == 0) {
        return false;
    }
    for (var i = 5; i * i <= number; i += 6) {
        if (number % i == 0 || number % (i + 2) == 0) {
            return false;
        }
    }
    return true;
}
