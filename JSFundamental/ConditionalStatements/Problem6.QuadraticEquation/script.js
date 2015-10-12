

var a = prompt("Please enter a number :");
var b = prompt("Please enter b number :");
var c = prompt("Please enter c number :");

function quadraticEq(a,b,c) {
    var 
        discriminant,
        x,
        x1,
        x2;

    document.writeln("Quadratic equation:");

    discriminant = (b * b) - (4 * a * c);

    if (discriminant < 0) {
        document.writeln("The quadratic equation a*x*x + bx + c = 0 has no real roots. ");
    } else if (discriminant === 0) {
        x = -(b / (2 * a));
        document.writeln("The quadratic equation a*x*x + bx + c = 0 has two roots which are actually equal: ", x);
    } else if (discriminant > 0) {
        x1 = (-b + Math.sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.sqrt(discriminant)) / (2 * a);
        document.writeln("The quadratic equation a*x*x + bx + c = 0 has two real roots: x1 is ", x1, " and x2 is ", x2);

    }
}

    quadraticEq(a,b,c);
