var inputArray = prompt("Enter elements: ", '[1, 2, 2, 3, 3, 3, 4, 4, 4, 4]');
var removeElement = prompt("Remove element: ", '3');

var elements = [];
elements = inputArray.replace(/[\[\]' ]+/g, '').split(',');

Array.prototype.remove = function (element) {
    for (var i = this.length; i--;) {
        if (this[i] === element) {
            this.splice(i, 1);
        }
    }

    return this;
};

elements.remove(removeElement);
document.writeln("New array is : ",elements);