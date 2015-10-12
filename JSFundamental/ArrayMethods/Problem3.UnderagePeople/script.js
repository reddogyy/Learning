
var people = [
new createPerson("Ivan", "Ivanov", 20, "Male"),
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
var years = parseInt(prompt("Please enter age which we will check for : "));
console.log(" Are everyone over "+ years +" years old ? "+people.every(function (item) { return item.age >= years;}));

underAge(people, years);
function underAge(persons, age) {
    persons.filter(function (item) { return item.age >= years; });
    persons.forEach(function (item) {console.log(JSON.stringify(item));});
}

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender 
    }
}


