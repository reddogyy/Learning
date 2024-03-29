var input = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>ANYTHING</lowcase> else.";



    result = parseTags(input);
    console.log('Problem 4: ' + result);


function parseTags(text) {
    var i,
        jump,
        random,
        originalText = text,
        currentStateArr = [],
        newText = [],
        len = text.length;

    for (i = 0; i < text.length; i += 1) {
        if (text[i] === '<') {
            switch (text[i + 1]) {
                case 'u':
                    currentStateArr.push('u');
                    jump = text.indexOf('>', i);
                    i = jump + 1;
                    break;
                case 'l':
                    currentStateArr.push('l');
                    jump = text.indexOf('>', i);
                    i = jump + 1;
                    break;
                case 'm':
                    currentStateArr.push('m');
                    jump = text.indexOf('>', i);
                    i = jump + 1;
                    break;
                case '/':
                    currentStateArr.pop();
                    jump = text.indexOf('>', i);
                    i = jump + 1;
                    break;
            }
        }
        switch (currentStateArr[currentStateArr.length - 1]) {
            case undefined:
                newText.push(text[i]);
                break;
            case 'u':
                newText.push(text[i].toUpperCase());
                break;
            case 'l':
                newText.push(text[i].toLowerCase());
                break;
            case 'm':
                random = Math.random();
                if (random < 0.5) {
                    newText.push(text[i].toLowerCase());
                    break;
                } else {
                    newText.push(text[i].toUpperCase());
                    break;
                }
        }
    }
    return newText.join('');
}