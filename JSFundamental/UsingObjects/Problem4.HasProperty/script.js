
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
 property = prompt("PLease enter the property we will search for");
hasProperty(obj, property);



function hasProperty(obj, property) {
    if (property in obj) {
        document.writeln('The object contains a property ' + property + ' with value ' + obj[property] + '.');
        console.log('Problem 4: The object contains a property ' + property + ' with value ' + obj[property] + '.');
    } else {
        document.writeln('The object doesn\'t contain a property ' + property + '.');
    }
}