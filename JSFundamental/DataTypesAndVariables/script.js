// JavaScript source code

var integer = 5;

var string = 'this is a string';

var char = 'a';

var bool = false;

var undefined = undefined;

var double = 5.5;

var floatingPoint = Math.PI;

var nullable = null;

var array = [123, 'AlaBala'];

var objLitteral = {
    Ala: "Bala"
}

var quotedText = "'How you doin'?','Joey said.'";


var firstProblemElement = document.getElementById('firstProblem');
firstProblemElement.innerHTML += "Integer = " + integer + "<br />";
firstProblemElement.innerHTML += "String = " + string + "<br />";
firstProblemElement.innerHTML += "Char = " + char + "<br />";
firstProblemElement.innerHTML += "Bool = " + bool + "<br />";
firstProblemElement.innerHTML += "Undefined = " + undefined + "<br />";
firstProblemElement.innerHTML += "Double = " + double + "<br />";
firstProblemElement.innerHTML += "Floating Point = " + floatingPoint + "<br />";
firstProblemElement.innerHTML += "Nullable = " + nullable + "<br />";
firstProblemElement.innerHTML += "Array = " + array + "<br />";
firstProblemElement.innerHTML += "ObjLitteral = " + objLitteral + "<br />";

var secondProblem = document.getElementById('secondProblem');
secondProblem.innerHTML += "Quoted text : " + quotedText + "<br />";

var thirdProblem = document.getElementById('thirdProblem')
thirdProblem.innerHTML += "type of (integer) :" + typeof (integer) + "<br />";
thirdProblem.innerHTML += "type of (string) :" + typeof (string) + "<br />";
thirdProblem.innerHTML += "type of (Char) :" + typeof (Char) + "<br />";
thirdProblem.innerHTML += "type of (bool) :" + typeof (bool) + "<br />";

thirdProblem.innerHTML += "type of (double) :" + typeof (double) + "<br />";
thirdProblem.innerHTML += "type of (floatingPoint) :" + typeof (floatingPoint) + "<br />";

thirdProblem.innerHTML += "type of (array) :" + typeof (array) + "<br />";
thirdProblem.innerHTML += "type of (objLitteral) :" + typeof (objLitteral) + "<br />";


var fourthProblem = document.getElementById('fourthProblem')
fourthProblem.innerHTML += "type of (undefined) :" + typeof (undefined) + "<br />";
fourthProblem.innerHTML += "type of (nullable) :" + typeof (nullable) + "<br />";