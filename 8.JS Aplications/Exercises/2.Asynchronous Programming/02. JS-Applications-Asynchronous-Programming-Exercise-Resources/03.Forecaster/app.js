function attachEvents() {
    let location= document.getElementById('location');
    let button= document.getElementById('submit')

    button.addEventListener('click', display);

   function display() {
    fetch('http://localhost:3030/jsonstore/forecaster/locations')
    .then(res=>res.json())
    .then(arr => {
    
    let locationName = location.value;    
    let city = arr.find(x=>x.name === locationName)

    console.log(city)
        
    })
    
 }

}

attachEvents();