var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];


function largerThanNeighbours(numbersArray) {
    for (var i = 1; i < numbersArray.Length - 1; i++) {
        if (numbersArray[i] > numbersArray[i - 1] && numbersArray[i] > numbersArray[i + 1]) {
            document.writeln("First number is on position : "+i);
            return 0;
        }
    }

}
largerThanNeighbours(array);