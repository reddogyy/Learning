var word = prompt("Please enter the word which we will search for:");
var text = prompt("Please enter the text : ");

function occuranceOfWord(text,word) {

    var flag = word.toLowerCase();
    var regEx = new RegExp("\\b" + flag + "\\b", "gi");
    var result = text.match(regEx);
    var count = result.length ;

    document.writeln("We found "+ "'"+result+"'"+" "+ count+" times");

}
occuranceOfWord(text,word)