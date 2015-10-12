var numberA = prompt("pleases enter A: ");
var numberB = prompt("pleases enter B : ");
var numberH = prompt("pleases enter H : ");
document.writeln(solveTask(numberA, numberB, numberH));


function solveTask(a, b, h) {
    return ((a + b)  / 2)*h;
}