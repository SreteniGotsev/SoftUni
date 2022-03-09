function Solve(string1, string2){

    let num1 = Number(string1)
    let num2 = Number(string2)
    let result = 0

    for(i=num1; i <= num2;i++){
        result+=i
    }

    console.log(result)
}       