"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;
document.getElementById("videob").disabled = true;

connection.on("ReceiveMessage", function (message) {

    var url = `https://localhost:44359/api/all/${room}`;
    console.log(url)
    fetch(url, {
        method: "Get"
    }).then(x => x.json())
        .then(x => {
            document.getElementById('users').innerHTML = "";
            for (var i = 0; i < x.length; i++) {

                document.getElementById('users').innerHTML += `
                                        <div class="users-list">
                                            <div class="chat-user">
                                                <img class="chat-avatar" src="https://bootdey.com/img/Content/avatar/avatar6.png" alt="">
                                                <div class="chat-user-name">
                                                    <a href="#">${x[i]}</a>
                                                </div>
                                            </div>
                                        </div>`
            }

        })

    for (var i = 0; i < users.length; i++) {
    }
    if (message.button != "yes") {
        var msg = message.text.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
        var encodedMsg =  msg;
        var li = document.createElement("li");
        li.textContent = encodedMsg;
        document.getElementById("messagesList").innerHTML += ` 
                                        <div class="chat-message right">
                                            <img class="message-avatar" src="https://bootdey.com/img/Content/avatar/avatar6.png" alt="">
                                            <div class="message">
                                                <a class="message-author" href="#"> ${message.user}</a>
                                                <span class="message-date"> </span>
                                                <span class="message-content">
                                                   ${encodedMsg}
                                                </span>
                                            </div>
                                        </div>`
    }
    else {
        var li = "HI"

        document.getElementById("video").innerHTML = `<iframe width="420" height="315"
src="${message.text}">
</iframe>`
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    document.getElementById("videob").disabled = false;






    connection.invoke("AddToGroup", room).catch(function (err) {
        return console.error(err.toString());
    });



}).catch(function (err) {
    return console.error(err.toString());
});



document.getElementById("sendButton").addEventListener("click", function (event) {



    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessageToGroup", room, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();

    document.getElementById("messageInput").value = "";


});


//------------------------------------------------------- VIDEO
connection.on("VideoInfo", function (message) {
    
    var li = "HI"
    document.getElementById("video").appendChild(li);
});

document.getElementById("videob").addEventListener("click", function (event) {



    var message = document.getElementById("videom").value;
    connection.invoke("SendVideoInfiToAllMessage", room, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});