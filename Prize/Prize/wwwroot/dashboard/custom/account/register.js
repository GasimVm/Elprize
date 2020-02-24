function onClickRegister() {
    // find registerForm from document
    let form = document.getElementById('registerForm');
    // check form valid
    $.validator.unobtrusive.parse($(form));
    if ($(form).valid() && check()) {
        $.ajax({
            url: `/Account/Register`,
            data: $(form).serialize(),
            type: "POST"
        }).done(function(response) {
            window.Swal.fire({
                title: 'success!',
                //text: 'Do you want to continue',
                icon: 'success',
                confirmButtonText: 'OK'
            });
            window.location.href = response.href;
        }).fail(function(xhr) {
            ////if (xhr.responseText !== null) {
            ////    SwalUtility.Fail(xhr.responseText);
            ////}
            ////else {
            ////    SwalUtility.Fail();
            ////}
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
}