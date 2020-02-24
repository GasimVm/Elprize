$("#pirt").click(function () {
    $("#homevideo_1").css("display", "block");
});

let random_shans = [];
let dudush_shansi = 30;
let udushButton = document.getElementById('bas');

for (let i = 0; i < dudush_shansi / 10; i++) {
    random_shans.push(true);
}

for (let i = 0; i < 10 - (dudush_shansi / 10); i++) {
    random_shans.push(false);
}

function getRandom() {
    let randomNumber = Math.floor(Math.random() * 10);
    console.log(randomNumber);
    return randomNumber;
}

udushButton.addEventListener("click", function Tekrarla() {
    let udushNomresi = getRandom();
    let udush = random_shans[udushNomresi];


    setTimeout(function () {

        if (udush) {
            alert("Qazandınız")
            $("#salam").css("display", "none");
            $("#bas").css("background", "red");
        }
        else {
            Tekrarla()
        }
        console.log(udush);
    }, 3000);


});
function myFunction() {
    $(".dollar").val($(".elprice").val() * 50);
}