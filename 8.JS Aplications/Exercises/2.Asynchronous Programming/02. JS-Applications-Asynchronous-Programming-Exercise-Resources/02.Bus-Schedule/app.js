function solve() {
     
    
    function depart() {
        let nextStopId = 'depot';
        let departInfo = document.querySelector('#info .info');
        let departButton = document.getElementById('depart');
        let arriveButton = document.getElementById('arrive');

        if(departInfo.getAttribute('data-next-stop-id') !== null){
        nextStopId = departInfo.getAttribute('data-next-stop-id');
        }

        fetch( `http://localhost:3030/jsonstore/bus/schedule/${nextStopId}`)
        .then(body => body.json())
        .then( stopInfo => {
             console.log(stopInfo);
             departInfo.setAttribute('data-next-stop-id', stopInfo.next)
             departInfo.setAttribute('data-stop-name', stopInfo.name)
             departInfo.textContent = `Next stop ${stopInfo.name}`;
             arriveButton.disabled = false;
             departButton.disabled = true;
        })
        .catch(err => {
           
            departInfo.textContent = `Err`;
            arriveButton.disabled = true;
            departButton.disabled = true;
        })
       
    }

    function arrive() {
        let departInfo = document.querySelector('#info .info');
        let departButton = document.getElementById('depart');
        let arriveButton = document.getElementById('arrive');
        let stopName = departInfo.getAttribute('data-stop-name')
        departInfo.textContent = `Arriving at ${stopName}`;
        arriveButton.disabled = true;
        departButton.disabled = false;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();