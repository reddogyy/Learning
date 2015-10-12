
var people = [
new createPerson("Ivan", "Ivanov", 18, "Male"),
new createPerson("Dimitar", "Dimitrov", 55, "Male"),
new createPerson("Petar", "Petrov", 22, "Male"),
new createPerson("Some", "Thing", 25, "Male"),
new createPerson("Maria", "Ivanova", 25, "Female"),
new createPerson("Silvia", "Petrova", 28, "Female"),
new createPerson('Penelope', 'Cruz', 41, 'female'),
new createPerson('Jean', 'Dujardin', 42, 'male'),
new createPerson('Keira', 'Knightley', 29, 'female'),
new createPerson("Billy", "Roy", 20, "Male")

];


var sorted = people.reduce(function (obj, item) {

    if (obj[item.firstName[0]]) {
        obj[item.firstName[0]].push(item);
    } else {
        obj[item.firstName[0]] = [item];
    }
    return obj;
}, {});

console.log('Sorted peoples by first letter' + JSON.stringify(sorted));

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    }
}


