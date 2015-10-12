var str1 = stringFormat("Hello {0}!", "Peter");

document.writeln(str1);

var format = "{0}, {1}, {0} text {2}";
var str2 = stringFormat(format, 1, "Pesho", "Gosho");

document.writeln(str2);

function stringFormat(str) {
    var selfArguments = arguments;

    return str.replace(/\{(\d+)\}/g, function(match, arg) {
        return selfArguments[+arg + 1];
    });
}