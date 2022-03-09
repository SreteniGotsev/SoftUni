function Solve(arg1){
let inputType = typeof(arg1);


if(inputType === 'number'){
    
   console.log(`${(Math.PI * arg1 * arg1).toFixed(2)}`)

   

} else {
    console.log(`We can not calculate the circle area, because we receive a ${inputType}.`);
}

}

Solve(3)