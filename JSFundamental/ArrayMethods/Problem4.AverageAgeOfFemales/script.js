
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


femaleAvarageAge(people);

function femaleAvarageAge(persons) {
    var females = persons.filter(function (item) {
        if (item.gender === 'female')
        {
            return item.age;
        }
    });
    var sumAge = females.reduce(function (sumAge, persons) {
        return sumAge + persons.age;
    }, 0);
    console.log(' The average age of all Women is ' + (sumAge / females.length).toFixed(2) + ' years old');
   
}

function createPerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: gender
    }
}


