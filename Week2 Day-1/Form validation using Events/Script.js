function validateName() {
    var name = document.getElementById("name").value;
    var msg = document.getElementById("nameMsg");

    if (name.trim() === "") {
        msg.innerHTML = " Name cannot be empty";
        msg.style.color = "red";
        return false;
    } else {
        msg.innerHTML = " Valid";
        msg.style.color = "green";
        return true;
    }
}

function validateEmail() {
    var email = document.getElementById("email").value;
    var msg = document.getElementById("emailMsg");

    if (email.indexOf("@") === -1) {
        msg.innerHTML = " Email must contain @";
        msg.style.color = "red";
        return false;
    } else {
        msg.innerHTML = " Valid";
        msg.style.color = "green";
        return true;
    }
}

function validateAge() {
    var age = document.getElementById("age").value;
    var msg = document.getElementById("ageMsg");

    if (age <= 18 || age === "") {
        msg.innerHTML = " Age must be greater than 18";
        msg.style.color = "red";
        return false;
    } else {
        msg.innerHTML = " Valid";
        msg.style.color = "green";
        return true;
    }
}

function saveData() {
    var isNameValid = validateName();
    var isEmailValid = validateEmail();
    var isAgeValid = validateAge();

    if (isNameValid && isEmailValid && isAgeValid) {
        var user = {
            name: document.getElementById("name").value,
            email: document.getElementById("email").value,
            age: document.getElementById("age").value
        };

        sessionStorage.setItem("userData", JSON.stringify(user));
        document.getElementById("finalMsg").innerHTML = " Registration successful! Data stored in sessionStorage.";
        document.getElementById("finalMsg").style.color = "green";
    } else {
        document.getElementById("finalMsg").innerHTML = " Please fix errors before submitting.";
        document.getElementById("finalMsg").style.color = "red";
    }
}