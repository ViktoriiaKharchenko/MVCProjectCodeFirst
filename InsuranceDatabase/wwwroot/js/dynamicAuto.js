brokers = [];
arr = [];
async function autocompleteDyn(arr) {

    await fetch('api/Brokers')
        .then(response => response.json())
        .then(data => {
            arr = data;
            _displayBrokers(data);
        })
        .catch(error => console.error('Unable to get brokers.', error));

    $('#num').autocomplete({
        minLength: 3,
        delay: 1000,
        source: function (request, response) {
            var term = request.term;
            var pattern = new RegExp("^" + term, "i");

            var brokers = $.map(arr, function (elem) {
                if (pattern.test(elem.name)) {
                    return elem;
                }
            })
            response(_displayBrokers(brokers));
        }
    })
}

function displayEditForm(id) {
    console.log(id);
    window.location.href = "/Brokers/Edit/" + id;
}
function displayDeleteForm(id) {
    window.location.href = "/Brokers/Delete/" + id;
}

function _displayBrokers(data) {
    const tBody = document.getElementById('brokers');
    tBody.innerHTML = '';
    const button = document.createElement('button');

    data.forEach(broker => {

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Редагувати';
        editButton.setAttribute('class', 'btn btn-primary')
        editButton.setAttribute('data-toggle', 'collapse')
        editButton.setAttribute('data-target', '#editWagon')
        editButton.setAttribute('aria-expanded', 'false')
        editButton.setAttribute('aria-controls', 'editWagon')
        editButton.setAttribute('onclick', `displayEditForm(${broker.id})`);

        let detailButton = button.cloneNode(false);
        detailButton.innerText = 'Деталі';
        detailButton.setAttribute('class', 'btn btn-primary')
        detailButton.setAttribute('data-toggle', 'collapse')
        detailButton.setAttribute('data-target', '#editWagon')
        detailButton.setAttribute('aria-expanded', 'false')
        detailButton.setAttribute('aria-controls', 'editWagon')
        detailButton.setAttribute('onclick', `displayEditForm(${broker.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Видалити';
        deleteButton.setAttribute('class', `btn btn-warning`);
        deleteButton.setAttribute('onclick', `displayDeleteForm(${broker.id})`);

        let tr = tBody.insertRow();

        let td0 = tr.insertCell(0);
        let td1 = tr.insertCell(1);
        let textNodeName = document.createTextNode(broker.name);
        td1.appendChild(textNodeName);

        let td2 = tr.insertCell(2);
        let textNodeSurname = document.createTextNode(broker.surname);
        td2.appendChild(textNodeSurname);
        let td4 = tr.insertCell(3);
        //td4.appendChild(detailButton);

        let td3 = tr.insertCell(4);
        td3.appendChild(editButton);



        let td5 = tr.insertCell(5);
        td5.appendChild(deleteButton);
    });

}

autocompleteDyn(arr);