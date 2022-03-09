function Solve(steps, length, speed){

    let distance = steps * length;

    let time = (distance/1000) / speed;

    let additionalMinutes = 0;

    for (let index = 500; index < distance; index+=500) {
        
        additionalMinutes++;
    }

    let hours = Math.floor(time);
    let minutes = Math.floor((time - hours) * 60) + additionalMinutes;
    let seconds = Math.round(((time-hours)*60 + additionalMinutes - minutes) * 60);
    
    if(hours === 0){

        if(minutes === 0 ){
            console.log(`0${hours}:0${minutes}:${seconds}`);
        }else{
            console.log(`0${hours}:${minutes}:${seconds}`);
        }
    }
    else{
        if(minutes === 0 ){
            console.log(`${hours}:0${minutes}:${seconds}`);
        }else{
            console.log(`${hours}:${minutes}:${seconds}`);
        }
    }

}

Solve(4000, 0.6, 5)