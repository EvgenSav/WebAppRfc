﻿"use strict";

app.controller("newDevController", function ($http, myFactory) {
    this.myFactory = myFactory; //gives possibility to accecc myFactory in html tempplate page
    this.DevTypes = [
        {
            id: 0,
            name: "Пульт"
        }, {
            id: 1,
            name: "Силовой блок"
        }, {
            id: 2,
            name: "Силовой блок с обр. св."
        }, {
            id: 3,
            name: "Датчик"
        }];
    this.NooMods = [
        {
            id: 0,
            name: "Tx"
        }, {
            id: 1,
            name: "Rx"
        }, {
            id: 2,
            name: "F-Tx"
        }];
    this.GetRooms = function () {
        $http.get(`http://${myFactory.Host}/Rooms/GetRooms`).then(
            function successCallback(response) {
                myFactory.Rooms = response.data;
                console.log(response.data);
            }, function errorCallback(response) {
            });
    }
    this.RoomSelected = function (name, room, type) {
        let newDev = {
            Name: name,
            Room: room,
            DevType: type.id
        };
        console.log(newDev);
        $http({
            url: `http://${myFactory.Host}/AddDevice/RoomSelected`,
            method: 'POST',
            data: newDev,
            headers: {
                'Accept': 'application/x-www-form-urlencoded',
                'Content-Type': 'application/x-www-form-urlencoded'
            }
        }).then(
            function successCallback(response) {
                console.log(response.data);
                myFactory.Status = response.data.status;
            }, function errorCallback(response) { });
    }
    this.BindClicked = function () {
        $http.get(`http://${myFactory.Host}/AddDevice/SendBind`).then(
            function successCallback(response) {
                myFactory.Status = response.data.status;
            }, function errorCallback(response) {
            });
    }
    this.BindReceived = function (device) {
        console.log(`Received bind for ${device.name}`);
        this.Device = device;
    };
    this.ShowBaseFromNewDev = function () {
        console.log(myFactory.DevBase);
    }
    this.CheckBind = function () {

    }
    this.Add = function () {
        console.log("myFactory before add:");
        console.log(myFactory.DevBase);
        $http.get(`http://${myFactory.Host}/AddDevice/Add`).then(
            function successCallback(response) {
                //console.log("Response data:");
                //console.log(response.data);
                //myFactory.AddToBase(response.data.device);
                //myFactory.Status = response.data.status;
                //console.log("myFactory after add:");
                //console.log(myFactory.DevBase);
            }, function errorCallback(response) { });
        this.Name = "";
        this.selectedType = {};
        this.selectedRoom = "";
    }
});