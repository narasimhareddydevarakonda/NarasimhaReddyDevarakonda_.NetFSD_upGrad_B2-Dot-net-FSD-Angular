function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(successCallback, errorCallback);
    } else {
        document.getElementById("output").innerHTML = "Geolocation is not supported by this browser.";
    }
}

function successCallback(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;

    document.getElementById("output").innerHTML =
        "Latitude: " + latitude + "<br>Longitude: " + longitude;

    var locationData = {
        latitude: latitude,
        longitude: longitude,
        time: new Date().toLocaleString()
    };

    var history = localStorage.getItem("locationHistory");

    if (history) {
        history = JSON.parse(history);
    } else {
        history = [];
    }

    history.unshift(locationData);

    if (history.length > 5) {
        history = history.slice(0, 5);
    }

    localStorage.setItem("locationHistory", JSON.stringify(history));

    displayHistory(history);
}

function errorCallback(error) {
    var message = "";

    if (error.code === error.PERMISSION_DENIED) {
        message = "Permission denied. Please allow location access.";
    } else if (error.code === error.POSITION_UNAVAILABLE) {
        message = "Location information is unavailable.";
    } else if (error.code === error.TIMEOUT) {
        message = "The request to get location timed out.";
    } else {
        message = "An unknown error occurred.";
    }

    document.getElementById("output").innerHTML = message;
}

function loadHistory() {
    var history = localStorage.getItem("locationHistory");

    if (history) {
        history = JSON.parse(history);
        displayHistory(history);
    }
}

function displayHistory(history) {
    var list = document.getElementById("history");
    list.innerHTML = "";

    for (var i = 0; i < history.length; i++) {
        var li = document.createElement("li");
        li.innerHTML =
            "Lat: " + history[i].latitude +
            ", Long: " + history[i].longitude +
            " (" + history[i].time + ")";
        list.appendChild(li);
    }
}