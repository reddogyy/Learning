var x1 = prompt("Please enter x coordinates of pointA: ");
var y1 = prompt("Please enter y coordinates of pointA: ");
var x2 = prompt("Please enter x coordinates of pointB: ");
var y2 = prompt("Please enter y coordinates of pointB: ");
var x3 = prompt("Please enter x coordinates of pointC: ");
var y3 = prompt("Please enter y coordinates of pointC: ");
var x4 = prompt("Please enter x coordinates of pointD: ");
var y4 = prompt("Please enter y coordinates of pointD: ");
var x5 = prompt("Please enter x coordinates of pointE: ");
var y5 = prompt("Please enter y coordinates of pointE: ");
var x6 = prompt("Please enter x coordinates of pointF: ");
var y6 = prompt("Please enter y coordinates of pointF: ");

function main() {
    var p1 = points(x1, y1);
    var p2 = points(x2, y2);
    var p3 = points(x3, y3);
    var p4 = points(x3, y3);
    var p5 = points(x3, y3);
    var p6 = points(x3, y3);
    
    document.writeln("distance between p1 and p2 is : ", calculateDistance(p1, p2));
    document.writeln("distance between p2 and p3 is : ", calculateDistance(p3, p4));
    document.writeln("distance between p3 and p1 is : ", calculateDistance(p5, p6));
    var line1 = lines(p1, p2);
    var line2 = lines(p3, p4);
    var line3 = lines(p5, p6);

    var isTriangle = canFormTriangle(line1, line2, line3);
}

function points(x, y) {
    return {
        'xCoor': x,
        'yCoor': y
    };
}

function lines(startPoint, endPoint) {
    return {
        'firstPoint': startPoint,
        'secondPoint': endPoint,
        'length': calculateDistance(startPoint,endPoint)
    };
}

function calculateDistance(startPoint, endPoint) {
    return Math.sqrt((startPoint.x - endPoint.x) * (startPoint.x - endPoint.x) +
        (startPoint.y - endPoint.y) * (startPoint.y - endPoint.y));
}


function canFormTriangle(sideA, sideB, sideC) {
    if ((sideA.length + sideB.length > sideC.length) &&
        (sideA.length + sideC.length > sideB.length) &&
        (sideB.length + sideC.length > sideA.length)) {
        return true;
    } else {
        return false;
    }
}
main();