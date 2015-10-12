

function solve() {
    return function solve(numbers) {
        if (numbers === undefined) {
            throw new Error('The array cannot be undefined.');
        } else if (!numbers.length) {
            return null;
        } else {
            if (!numbers.every(function (num) {
                    return num == Number(num);
            })) {
                throw new Error('All elements must be numbers.');
            }

            return numbers.reduce(function (currentSum, number) {
                return currentSum + +number;
            }, 0);
        }
    }
}