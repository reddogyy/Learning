
var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname: 'Bay', lastname: 'Ivan', age: 81 }];


function findYoungest(array) {
    var youngest;
    for (var i = 0; i <= array.length-2; i++) {
        if (array[i].age < array[i + 1].age) {
            youngest = array[i];
        }
    }
    document.writeln(youngest.firstname + " "+ youngest.lastname);
}

findYoungest(people);