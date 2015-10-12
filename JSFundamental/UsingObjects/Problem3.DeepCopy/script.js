var obj = {
    stringProperty: 'this is a string',
    numberProperty: 5,
    arrayProperty: [1, 2, 3, 4, 5],
    objectProperty: {
        a: 5,
        b: 7,
        c: [1, 2, 3]
    }
},
        copy = createDeepCopy(obj),
        result = '',
        prop;
console.log('Problem 3: Properties of the copy:');
result += 'Properties of the copy:<br /><br />';

for (prop in copy) {
    result += (prop + ': ' + copy[prop] + '<br />');
    console.log(prop + ': ' + copy[prop]);
}

console.log('Change a reference type property of the original object:');
result += '<br />Change a reference type property of the original object:<br />';

obj.arrayProperty[0] = 'This is changed';

console.log('Object.arrayProperty: ' + obj.arrayProperty);
result += 'Object.arrayProperty: ' + obj.arrayProperty +
    '<br />The copy is not changed:<br />copy.arrayProperty: ' + copy.arrayProperty;
console.log('The copy is not changed:');
console.log('copy.arrayProperty: ' + copy.arrayProperty);
document.getElementById('pr3answer').innerHTML = result;


function createDeepCopy(obj) {
    if (obj === null || typeof obj !== 'object') {
        return obj;
    }

    var copy = obj.constructor();
    for (var prop in obj) {
        copy[prop] = createDeepCopy(obj[prop]);
    }

    return copy;
}