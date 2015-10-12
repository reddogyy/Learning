
var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

var searchedSubstring = "in";
var occurs = allOccursLength(text, searchedSubstring, true, false);

document.writeln(text+ "\n");
document.writeln(searchedSubstring + " Is found " + occurs + " times");

function allOccursLength(str, pattern, isSubstring, isCaseSensitive) {
    var caseSensitive = isCaseSensitive ? "g" : "gi";
    var format = isSubstring ? "{0}" : "\\b{0}\\b";

    var regex = new RegExp((format, pattern), caseSensitive);

    return str.match(regex).length;
}