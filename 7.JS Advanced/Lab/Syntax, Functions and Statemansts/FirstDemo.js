//function Hello(){
//console.log('Hello, world!');
//}

function Solve(firstName, lastName, age, town) {
    if(age >= 18){
      console.log(`Good Evening ${firstName} ${lastName},`);
      console.log(`The packaege will bi send to you address (${town})`);
    }else{
        console.log(`${firstName}, you are too young to have access to this app! Come back after ${18-age} year/s.`);
    }
};

    
    Solve('Sreteni', 'Gotsev', 21, 'Etropole');
    console.log()
    Solve('Gergo', 'Gotsev', 14, 'London');