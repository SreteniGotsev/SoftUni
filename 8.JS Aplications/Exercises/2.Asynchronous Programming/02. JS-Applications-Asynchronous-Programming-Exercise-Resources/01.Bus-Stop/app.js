function getInfo() {
    let stopIdInput = document.getElementById('stopId')
    let stopId = stopIdInput.value;
    document.getElementById('stopId').value = '';
   
    fetch(`http://localhost:3030/jsonstore/bus/businfo/${stopId}` )
    .then(ref=>ref.json())
    .then(info => {
          let stopName= document.getElementById('stopName');
          stopName.textContent = info.name; 

          let buses = document.getElementById('buses')

          while(buses.firstChild) {
              buses.removeChild(buses.firstChild)
          }

          Object.entries(info.buses).forEach( key =>{
              let liElement = document.createElement('li');
              liElement.textContent = `Bus ${key[0]} arrives in ${Number(key[1])}`
              buses.appendChild(liElement)
          })                      
           
          
        })
        .catch(err => {
            let stopName= document.getElementById('stopName');
          stopName.textContent = 'Error'; 

          let buses = document.getElementById('buses')
          
          while(buses.firstChild) {
              buses.removeChild(buses.firstChild)
          }

        })
      
        
}