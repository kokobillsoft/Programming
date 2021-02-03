let addMessage = document.querySelector('.message'),
addButton = document.querySelector('.add');
todo=document.querySelector
let todoList = [];

addButton.addEventListener('click', function (){

let newTodo = {
    todo: addMessage.value,
    checked: false,
    important: false
};

    todoList.push(newTodo);
    displayMessages();
});

function displayMessages(){
    
    let displayMessage = '';
    
    todoList.forEach(function(item, i){
        displayMessage += `
        <li>
            <input type='checkbox' id='item_${i}'>
            <label for='item_${i}'>${item.todo}</label>
        </li>
        `;
        console.log (displayMessage);
        todo.innerHTML = displayMessage;
        alert("1");
    });

}

/*function displayMessages(){
    let displayMessage = `Our bussines: ${addMessage.value}`;
    console.log('displayMessage% ', displayMessage);
}*/


