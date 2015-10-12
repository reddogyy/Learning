var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var position = prompt("Please enter a position : ");

function largerThanNeighbours(myArray) {
    var isLargest = false;
    if (position > myArray.length || position=== myArray.length) {
        document.writeln("Entered number is bigger than array length or is equal to it.");
        return 0;
    }
    var tempPosition = position - 1;
    if (myArray[tempPosition] > myArray[tempPosition - 1] && myArray[tempPosition] > myArray[tempPosition + 1])
    {
        isLargest = true;
    }
    else
    {
        isLargest = false;
    }

    document.writeln(isLargest);
}
largerThanNeighbours(array);