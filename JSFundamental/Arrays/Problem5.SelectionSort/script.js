var array = [8, 12, 3, 4, 5, 2, 11, 13, 7, 4, 15, 14, 12, 8, 1];

function selectionSort(numbersArray){
    var min;
    var temp;
    for (var i = 0; i < numbersArray.length - 1; i++)
    {
        min = i;
        for (var j = i + 1; j < numbersArray.length; j++)
        {
            if (numbersArray[j] < numbersArray[min])
            {
                min = j;
            }
        }
        temp = numbersArray[i];
        numbersArray[i] = numbersArray[min];
        numbersArray[min] = temp;
    }
    for (var i = 0; i < numbersArray.length; i++)
    {
        document.writeln(numbersArray[i]);
    }
}
selectionSort(array);