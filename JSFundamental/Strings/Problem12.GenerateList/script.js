
    var people = [{
        name: 'Pesho',
        age: 25
    }, {
        name: 'Gosho',
        age: 30
    }, {
        name: 'Vanko',
        age: 35
    }, {
        name: 'Doncho',
        age: 40
    }],
        divPeople = document.getElementById('list-item'),
        template = divPeople.innerHTML,
        peopleList = generateList(people, template);

    divPeople.innerHTML = peopleList;
    document.body.removeChild(document.getElementById('problem'));


function generateList(people, template) {
    var prop,
        i,
        len,
        liContent,
        props = [],
        peopleList = [];

    peopleList.push('<ul><strong>-\{name\}-</strong><span>-\{age\}-</span >');

    for (prop in people[0]) {
        props.push(prop);
    }

    for (i = 0, len = people.length; i < len; i += 1) {
        peopleList.push('<li>');
        liContent = template;

        for (prop in people[0]) {
            liContent = liContent.replace(new RegExp(
                '\\-{' + prop + '\\}-', "g"), people[i][prop]);
        }

        peopleList.push(liContent);
        peopleList.push('</li>');
    }

    peopleList.push('</ul>');

    return peopleList.join('');
}