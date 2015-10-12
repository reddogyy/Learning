property = prompt("Please enter the value you want to sort", "firstname, lastname or age");
var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname: 'Bay', lastname: 'Ivan', age: 1 }];
printArrayOfObjects(group(people, property),Object);

function group(array, property) {
    var i,
        len = array.length,
        prop,
        result = {};

    if (property === 'firstname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].firstname]) {
                result[array[i].firstname].push(array[i]);
            } else {
                result[array[i].firstname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'lastname') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].lastname]) {
                result[array[i].lastname].push(array[i]);
            } else {
                result[array[i].lastname] = [array[i]];
            }
        }
        return result;
    }
    if (property === 'age') {
        for (i = 0; i < len; i += 1) {
            if (result[array[i].age]) {
                result[array[i].age].push(array[i]);
            } else {
                result[array[i].age] = [array[i]];
            }
        }
        return result;
    }
}

function printArrayOfObjects(array, type) {
    var result = '',
        prop,
        len = array.length;

    for (i = 0; i < len; i += 1) {
        for (prop in array[i]) {
            result += (prop + ': ' +
                array[i][prop] + '; ');
        }
        if (type === 'console') {
            result += '\n';
            if (i < len - 1) {
                result += '\t';
            }
        } else {
            result += '<br />';
            if (i < len - 1) {
                result += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            }
        }

    }
    return result;
}