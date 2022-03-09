
function Solve(num1, num2, operator){

   let output = 0

   if(operator === '+'){
    
    output = num1 + num2

   }else if(operator === '-'){
    output = num1 - num2
   }else if(operator === '*'){
    output = num1 * num2
   }else if(operator === '/'){
    output = num1 / num2      
   }else if(operator === '%'){
    output = num1 % num2
   } else if (operator === '**'){
    output = num1 ** num2
   }

  console.log(output)

};

Solve(5,3, '**')