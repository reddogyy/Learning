
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


youngestPerson(people);

function youngestPerson(persons) {

    persons.sort(function (a, b) {
        return a.age - b.age
    });
    console.log("The youngest person is " + persons[0].firstName + " " + persons[0].lastName + " " + persons[0].age + " " + persons[0].gender);
}

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    }
}


