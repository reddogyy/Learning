var pointX = prompt("pleases enter X : ");
var pointY = prompt("pleases enter Y : ");
var circleRadius = 5;
if (pointX * pointX + pointY * pointY <= circleRadius * circleRadius) {
    document.write("Point("+pointX+","+ pointY+") is INSIDE a circle K(O, "+circleRadius+").");
}
else {
    document.write("Point(" + pointX + "," + pointY + ") is OUTSIDE a circle K(O, " + circleRadius + ").");
}