Array.prototype.compareLexicographically = function (arr) {
    for (var ind = 0; ind < Math.min(this.length, arr.length) ; ind++) {
        if (arr[ind] !== this[ind]) {
            return this[ind] < arr[ind] ? -1 : 1;
        }
    }

    if (this.length != arr.length) {
        this.length < arr.length ? -1 : 1;
    }

    return 0;
}

document.writeln(['a', 'b', 'c'].compareLexicographically(['a', 'b', 'c']));
document.writeln(['a', 'b', 'c'].compareLexicographically(['a', 'c', 'b']));
document.writeln(['a', 'c', 'b'].compareLexicographically(['a', 'b', 'c']));