//#region Reply DocVisa

$(document).on("click", "#replyTransaction", function (event) {
    event.preventDefault();
    const href = $(this).attr("href");
    $.ajax({
        url: href
    }).done(function (response) {
        $("#replyTransactionModal .modal-dialog").html(response);
    });
});

$(document).on("click", "#btnReplyDocVisa", function (event) {

    event.preventDefault();
    var $form = $('#replyForm');
    const action = $form.attr("action");
    const method = $form.attr("method");

    if ($form.valid()) {
        $.ajax({
            url: action,
            type: method,
            data: $form.serialize()
        }).done(function (response) {
            table.draw();
            $("#btnCloseReplyModal").click();
            window.Swal.fire({
                title: 'success!',
                //text: 'Do you want to continue',
                icon: 'success',
                confirmButtonText: 'OK'
            });
            window.location.href = "/transaction/index";
        }).fail(function (xhr) {
            window.Swal.fire({
                icon: 'error',
                title: 'Oops...',
                text: xhr.responseText
            });
        });
    } else {
        window.Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: "form not valid"
        });
    }

});
//#endregion Reply DocVisa