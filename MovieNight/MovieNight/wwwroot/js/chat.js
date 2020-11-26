"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;
document.getElementById("videob").disabled = true;

connection.on("ReceiveMessage", function (message) {
    if (message.button != "yes") {
        var msg = message.text.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
        var encodedMsg = message.user + " says " + msg;
        var li = document.createElement("li");
        li.textContent = encodedMsg;
        document.getElementById("messagesList").innerHTML += ` 
                                    <li class="chat-left">
                                        <div class="chat-text">
                                                    ${encodedMsg}
                                        </div>
                                        <div class="chat-hour">07:00 <span class="fa fa-check-circle"></span></div>
                                    </li>`
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