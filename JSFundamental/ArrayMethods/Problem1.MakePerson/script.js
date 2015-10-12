
var people = [
    new createPerson("Ivan", "Ivanov", "20", "Male"),
    new createPerson("Dimitar", "Dimitrov", "55", "Male"),
    new createPerson("Petar", "Petrov", "22", "Male"),
    new createPerson("Some", "Thing", "25", "Male"),
    new createPerson("Maria", "Ivanova", "25", "Female"),
    new createPerson("Silvia", "Petrova", "28", "Female"),
    new createPerson('Penelope', 'Cruz', 41, 'female'),
    new createPerson('Jean', 'Dujardin', 42, 'male'),
    new createPerson('Keira', 'Knightley', 29, 'female'),
    new createPerson("Billy", "Roy", "20", "Male")

];

people.forEach(function (item, index) {
    console.log('Index' + index + ' ' + JSON.stringify(item));
});

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender 
    }
}
console.log(new Array(31).join('-'));

