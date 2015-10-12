var numberX = prompt("pleases enter A: ");
var numberY = prompt("pleases enter B : ");
document.writeln(solveTask(numberX, numberY));


function solveTask(x, y) {
    var isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3;
    var isOutOfRectangle = !((x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2));
    return isInCircle && isOutOfRectangle;
}