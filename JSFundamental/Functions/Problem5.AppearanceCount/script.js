var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var mostFrequent = 1;
var number = 0;
var tempNumber = 0;
var count = 1;

function mostFrequentNumber(myArray) {
    for (var i = 0; i < myArray.length; i++) {
        tempNumber = myArray[i];
        for (var j = 0; j < myArray.length; j++) {


            if (tempNumber == myArray[j] && j != i) {
                count++;
                if (count > mostFrequent) {
                    mostFrequent = count;
                    number = myArray[i];

                }
                else {
                    count = 1;
                }
            }
        }
        count = 1;

    }
    document.writeln("Most frequent number is : " + number + " , " + mostFrequent + " times");
}
mostFrequentNumber(array);