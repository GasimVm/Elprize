
var check = function () {
    let isValid = new Boolean(false);
    let password = document.getElementById("Password").value;
    let confirmPassword = document.getElementById("ConfirmPassword").value;
    //console.log(password);
    const error = document.getElementById('errorMessage');
    // check password and confirmPassword equals to null ''
    if (password !== "" && confirmPassword !== "") {
        if (password === "password") {             // invalid password
            error.innerHTML = "Password not valid password.";
            error.style.color = "red";
            isValid = false;
        } else if (password === confirmPassword) { // matching
            error.style.color = "green";
            error.innerHTML = "Password and Confirmation Password  matching.";
            isValid = true;
        } else if (password !== confirmPassword) { // not matching
            error.style.color = "red";
            error.innerHTML = "Password and Confirmation Password must match.";
            isValid = false;
        }
    } else if (password === "" || confirmPassword === "") {
        error.innerHTML = "";
        isValid = false;
    }
    return isValid;
};
