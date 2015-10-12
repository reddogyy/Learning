var value = prompt("pleases enter a number : ");
var inBinary = (value >>> 0).toString(2);
inBinary = ('0000' + inBinary).slice(-16)
var reversed = inBinary.split("").reverse().join("");
document.write(reversed[3]);