//#region modal for cashBoxType create and edit
$(document).on("click",
    "#createTransaction",
    function (event) {
        event.preventDefault();

        //console.log(href);
        $.ajax({
            url: `/Transaction/Create`
        }).done(
            function (response) {
                $("#createTransactionModal .modal-dialog").html(response);
                $('.select2DropDown').select2({
                    placeholder: "Select"
                });
            });
    });
//#endregion
//#region create and edit cashBox

$(document).on("click", "#sendBTN", function (event) {
    event.preventDefault();
    const $form = $(this).parent().parent();
    const method = $form.attr("method");
    const action = $form.attr("action");
    $.validator.unobtrusive.parse($form);
    if ($form.valid()) {
        $.ajax({
            url: action,
            type: method,
            data: $form.serialize()
        }).done(function (response) {
            $("button#closeModal").click();
            ClearModal();
            table.draw();
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
//#endregion

function ClearModal() {
    $(".select2DropDown").select2("val", " ");
    $("#Amount").val(null);
}