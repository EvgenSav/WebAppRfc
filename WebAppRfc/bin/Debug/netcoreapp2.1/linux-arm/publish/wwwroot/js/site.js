﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();


connection.on("UpdateDevView", function (rfdevice) {
    var appCtrlScope = angular.element(document.getElementById("app_controller")).scope();
    try {
        appCtrlScope.$apply(function () {
            appCtrlScope.devView.UpdateDevView(rfdevice.value);
        });
    } catch(err){
        appCtrlScope = angular.element(document.getElementById("log_controller")).scope();
        try {
            appCtrlScope.$apply(function () {
                appCtrlScope.devLog.UpdateDevView(rfdevice.value);
            });
        } catch(err){ }
    } finally {
        console.log("Device info updated!");
    }


    console.log(rfdevice.value);
});

connection.on("ConfirmDevAdd", function (rfdevice) {
    var appCtrlScope = angular.element(document.getElementById("addNewDev_controller")).scope();
    appCtrlScope.$apply(function () {
        appCtrlScope.new.ConfirmAddDev(rfdevice.value);
    });
    console.log(rfdevice.value);
});

connection.start().catch(err => console.error(err.toString()));

