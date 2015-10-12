var urlAddress = "https://www.devbg.org/forum/index.php";

var fragments = extractUrlFragments(urlAddress);

// Convert to JSON object
var jsonObject = JSON.stringify({
    protocol: fragments[1],
    server: fragments[2],
    resource: fragments[3]
});
    
document.writeln("JSON: " + jsonObject);

// Parse JSON object to JS object
var jsObject = JSON.parse(jsonObject);

document.writeln();
document.writeln("URL Address: " + urlAddress);
document.writeln("[protocol] = " + jsObject.protocol);
document.writeln("[server] = " + jsObject.server);
document.writeln("[resource] = " + jsObject.resource);


function extractUrlFragments(urlAddress) {
    var pattern = /(.*):\/\/(.*?)(\/.*)/g;

    return pattern.exec(urlAddress);
}