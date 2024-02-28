'use strict';

window.addEventListener('load', () => {
    const btnAdd = document.getElementById("Add");
    const popup = document.getElementById("popup"); 
    btnAdd.addEventListener("click", () => {
        popup.classList.toggle('disable');
    });
    popup.addEventListener("click", (event) => {
        if(event.target === popup) popup.classList.toggle('disable');
    });
    // Мы здесь получаем элементы по id и меняем класс disable как вкл-выкл у popup.
    // При нажатии Добавить-открываем окно, при нажатии вне окна(серое место) закрываем его


    let list = document.getElementsByClassName("list__wrapper");// получаем <div class="list__wrapper shadow">
    list = list[0]; // т.к list это массив, зная что щас в коде у нас один такой элемент, берем его
    const popup_btn = document.getElementById("popup-btn");
    popup_btn.onclick = () => { //при клике на Отправить мы делаем...
        var listLeng = document.getElementsByClassName('list__lines').length;// чтобы получить сколько есть записей
        let text = Array.from(popup.getElementsByTagName('input'));
        let divList = document.createElement('div');
        divList.classList.add('list__lines');
        let number = document.createElement('p');
        number.classList.add('number');
        number.textContent = listLeng+1; // наш номер будет равен = количество записей на дан. момент + 1

        /* дальше мы просто реализуем вот такую структуру
        <div class="list__line-title">
            <p class="number">1</p>
            <p class="name">текст</p>
            <p class="breed">текст</p>
            <p class="chip">текст</p>
            <p class="age">текст</p>
            <p class="nick">текст</p>
            <p class="drugs">текст</p>
            <p class="heal">текст</p>
            <div class="list__param">
                <div class="list__change">Изменить</div>
                <div class="list__remove">Удалить</div>
            </div>
        </div>
        но в js переменных 
        */
        let name = document.createElement('p');
        name.classList.add('name');
        let breed = document.createElement('p');
        breed.classList.add('breed');
        let chip = document.createElement('p');
        chip.classList.add('chip');
        let age = document.createElement('p');
        age.classList.add('age');
        let nick = document.createElement('p');
        nick.classList.add('nick');
        let drugs = document.createElement('p');
        drugs.classList.add('drugs');
        let heal = document.createElement('p');
        heal.classList.add('heal');
        let param =  document.createElement('div');
        let change = document.createElement('div');
        let remove = document.createElement('div');
        param.classList.add('list__param');
        param.appendChild(change);
        param.appendChild(remove);
        change.classList.add('list__change');
        remove.classList.add('list__remove');
        change.textContent = 'Изменить';
        remove.textContent = 'Удалить';

        divList.appendChild(number);
        divList.appendChild(name);
        divList.appendChild(breed);
        divList.appendChild(chip);
        divList.appendChild(age);
        divList.appendChild(nick);
        divList.appendChild(drugs);
        divList.appendChild(heal);
        divList.appendChild(param);
        
        let i = 1;
        text.forEach(element => {
            const a = divList.querySelectorAll('p');
            a[i].textContent = element.value;
            i++;
        });
        // то что мы писали в модальном окне мы берём оттуда и закидываем в нашу структуру в Js
        list.appendChild(divList);// нашу структуру с данными кидаем в конец <div class="list__wrapper shadow">
        popup.click();// закрываем окно
    }; 

    const checkbox = document.getElementById("checkbox")
    checkbox.addEventListener("change", () => {
        let l = document.getElementsByClassName('list');
        let p = popup.getElementsByClassName("popup__box");
        let logo = document.getElementsByClassName('logo');
        logo = logo[0];
        document.body.classList.toggle("dark");
        l[0].classList.toggle('list-dark');
        p[0].classList.toggle('dark-popup');
        list.classList.toggle('shadow');
        logo.classList.toggle('shadow');
    })

    

});