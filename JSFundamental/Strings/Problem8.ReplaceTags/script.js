var html = '<p>Please visit <A HREF="http://academy.telerik.com">our site</A> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

var escapedHtml = replaceHrefWithUrlTag(html);

document.writeln(html);
document.writeln();
document.writeln(escapedHtml);

function replaceHrefWithUrlTag(text) {
    var pattern = /<a href="(.*?)">(.*?)<\/a>/gi;

    var escapedText = text.replace(pattern, function(tag, url, message) {
        return Format("[URL={0}]{1}[\/URL]", url, message);
    });

    return escapedText;
}