function Solve(length){
    
    let size = 0;

    if (size == NaN){

        size = 5
    }
    else{
        
        size = length
    }
     
    
    for (let i = 0; i < size; i++) {
        
        let result = '';
        
        for (let index = 0; index < size; index++) {
            
            result += '* '
        }
         
        console.log(result.trimEnd());
    }
}

Solve(4)