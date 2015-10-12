var min,
    max,
    prop;

minMax(document);
minMax(window);
minMax(navigator);

function minMax(obj) {

    min = '~'; // ASCII code 126 (biggest)
    max = ' '; // ASCII code 32 (smallest)

    for (prop in obj) {

        if (prop > max) {
            max = prop;
        }
        if (prop < min) {
            min = prop;
        }
    }

    document.writeln(obj.toString() + ': min -> ' + min + ', max -> ' + max);
}