function minMaxOfSequence() {
    var input = document.getElementById("input").value,
        numbers = [];

    numbers = input.split(/[ ,]+/);
    numbers.sort(sortNumbers);

    console.log("Min value of sequence:", numbers[0]);
    console.log("Max value of sequence:", numbers[numbers.length - 1]);
    document.getElementById("min").innerText = "Min value: " + numbers[0];
    document.getElementById("max").innerText = "Max value: " + numbers[numbers.length - 1];
}

function sortNumbers(a, b) {
    return a - b;
}