function Solve(array){
 
    let result = 0;
    let otherResult =0;
    let string = '';

    for (const num of array) {
        result+= num;
    }

    for (const num of array) {
        otherResult+= 1/num;
    }

    for (const num of array) {
        string+=num;
    }

    console.log(result);
    console.log(otherResult);
    console.log(string);
}