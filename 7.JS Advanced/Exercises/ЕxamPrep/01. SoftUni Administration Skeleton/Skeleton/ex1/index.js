function solve() {
   
    let addButton = document.querySelector(`.action .form-control button`);

    addButton.addEventListener('click', (e) => {
        e.preventDefault();

        let lectureInput = document.querySelector(".form-control input[name='lecture-name']");
        let dateInput = document.querySelector("input[name='lecture-date']");
        let moduleInput = document.querySelector("select[name='lecture-module']");

        let part = dateInput.value.split('T');
        //    console.log(part[0]);
        //    console.log(lectureInput.value);
        //    console.log(typeof dateInput.value);
        //    console.log(formatDate(part[0]));

        let lecture = createLecture(lectureInput, part)

        let addingPoint = document.querySelector('.modules');


        let modules = Array.from(document.querySelectorAll(' h3')).forEach(x=x.value)
        console.log(!(modules.includes(`${moduleInput.value.toUpperCase()}-MODULE`)));
        console.log(`${moduleInput.value.toUpperCase()}-MODULE`);
        console.log(modules);

        if (!(modules.includes(`${moduleInput.value.toUpperCase()}-MODULE`))) {
            let moduleL = createModuleElement(moduleInput.value);
            addingPoint.appendChild(moduleL);
        }

        let ulS = document.querySelector(`.${moduleInput.value} ul`)
        ulS.appendChild(lecture)

        let arr = Array.from(ulS.querySelectorAll('li'));
        arr.sort((a,b) => a.split(' - ')[1] - b.split(' - ')[1])
        .forEach(li=>ulS.appendChild(li));
        


        //console.log(module);




        
        ulS.addEventListener('click', (e) => {
            e.preventDefault;
            if(e.target.tagName != 'BUTTON'){
                return;
            }
            let itemForDel = e.target.parentNode;
            let ul = e.target.parentNode.parentNode;

            console.log(ul);

            let moduleK = e.target.parentNode.parentNode.parentNode;

            console.log(moduleK);

            itemForDel.remove();
            if(Array.from(ulS.querySelectorAll('li')).length == 0){
                moduleK.remove();
                let arM = moduleK.value.split('-')
                let index = modules.indexOf(arM[0]);
                modules = modules.splice(index,1);
            }
        })

    })


    function createModuleElement(moduleInput) {

        let module = document.createElement('div');
        module.classList.add('module');
        module.classList.add(`${moduleInput}`);

        let heading = document.createElement('h3');
        heading.textContent = `${moduleInput.toUpperCase()}-MODULE`;
        module.appendChild(heading);

        let ul = document.createElement('ul');
        module.appendChild(ul);
        return module;

    }

    function createModule(moduleInput) {

        let obj = {
            nameM: moduleInput,
            lectures: []
        }
        return obj;

    }

    function formatDate(date) {
        let regex = /-/g;
        let formatedDate = date.replace(regex, `/`);
        return formatedDate;
    }

    function createLecture(lectureNmae, date) {
        let liElement = document.createElement('li');
        liElement.classList.add('flex');

        let headingLi = document.createElement('h4');
        headingLi.textContent = `${lectureNmae.value} - ${date[0]} - ${date[1]}`;

        let button = document.createElement('button');
        button.classList.add('red');
        button.textContent = 'Del';
        button.classList.add('del');

        liElement.appendChild(headingLi);
        liElement.appendChild(button);
        return liElement;

    }
}