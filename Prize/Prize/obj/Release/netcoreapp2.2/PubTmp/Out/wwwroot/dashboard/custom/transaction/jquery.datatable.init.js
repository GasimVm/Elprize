let table;
//#region delete Item
function deleteItem(name, id) {
    window.Swal.fire({
        title: "Are you sure?",
        text: `You won't be able to revert ${name}!`,
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.value) {
            $.get('/Dashboard/Accommodation/Delete/' + id).done(function () {
                //table = $("#dataTable").DataTable();
                table.draw();
                window.Swal.fire(
                    "Deleted!",
                    "Your file has been deleted.",
                    "success"
                );
            }).fail(function (xhr) {
                window.Swal.fire({
                    icon: 'error',
                    title: 'Oops...',
                    text: xhr.responseText
                });
            });
        }
    });
};
//#endregion

$(document).ready(function () {

    //#region okay baby
    table = $("#dataTable").DataTable({
        "responsive": true,
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": true, // this is for disable filter (search box)
        "orderMulti": false, // for disable multiple column at once
        "ordering": false,
        "ajax": {
            "url": "/Transaction/LoadData",
            "type": "POST",
            "datatype": "json"
        },
        language: {
            paginate: {
                next: `<i style="color:#0b8071;" class="fas fa-arrow-right"></i>`, // or '→'
                previous: '<i style="color:#0b8071;" class="fas fa-arrow-left"></i>' // or '←' 
            }
        },
        "columns": [
            
            { "data": "id"},
            { "data": "sender"},
            { "data": "receiver"},
            { "data": "amount"},
            {
                "data": "status",
                render: function (data, type, row) {
                    return `<span class="badge badge-soft-danger">${data}</span>`;
                }
            },
            { "data": "sendDate"},
            { "data": "answerDate"},
            {
                data: null,
                render: function (row) {
                    return `<a id="replyTransaction"
                                       href="${row.reply === false ? "#" : `/Transaction/Reply/${row.id}`}" data-id="${row.id}" 
                                       data-toggle="modal" data-target="#replyTransactionModal"  class="${row.reply === false ? "disabled text-black-50" : " text-danger"} btn text-info btn-sm " >
                                     <i class="fa fa-reply text-danger" ></i>
                                  </a>`;
                }
            }
            //{ "data": "Reply"}

        ]
    });
    //#endregion

    //#region row Details
    //var detailRows = [];

    //$('#dataTable tbody').on('click',
    //    'tr td.details-control',
    //    function () {

    //        var tr = $(this).closest('tr');
    //        var row = table.row(tr);
    //        var idx = $.inArray(tr.attr('id'), detailRows);

    //        if (row.child.isShown()) {
    //            tr.removeClass('details');
    //            row.child.hide();
    //            tr.removeClass('shown');
    //            // Remove from the 'open' array
    //            detailRows.splice(idx, 1);
    //        } else {
    //            tr.addClass('shown');
    //            tr.addClass('details');
    //            row.child(format(row.data())).show();

    //            // Add to the 'open' array
    //            if (idx === -1) {
    //                detailRows.push(tr.attr('id'));
    //            }
    //        }
    //    });


    //$('#btn-show-all-children').on('click',
    //    function () {
    //        // Enumerate all rows
    //        table.rows().every(function () {
    //            // If row has details collapsed
    //            if (!this.child.isShown()) {
    //                // Open this row
    //                this.child(format(this.data())).show();
    //                $(this.node()).addClass('shown');
    //            }
    //        });
    //    });

    //$('#btn-hide-all-children').on('click',
    //    function () {
    //        // Enumerate all rows
    //        table.rows().every(function () {
    //            // If row has details expanded
    //            if (this.child.isShown()) {
    //                // Collapse row details
    //                this.child.hide();
    //                $(this.node()).removeClass('shown');
    //            }
    //        });
    //    });

    //table.on('draw',
    //    function () {
    //        $.each(detailRows,
    //            function (i, id) {
    //                $('#' + id + ' td.details-control').trigger('click');
    //            });
    //    });
    //#endregion
});






//#region details table
//function format(row) {
//    // variables
//    var card = `<div class="card">
//                    <div class="card-header p-0 pt-3 pb-3">
//                        <div class="text-center"><h4>Accommodation Photo</h4></div>
//                    </div>
//                    <div class="row justify-content-center">
//                        <div class="col-lg-3">
//                            <div class="card e-co-product">
//                                <a href="">
//                                    <img id="" src="${row.photoPath}" alt="" class="img-fluid">
//                                </a>
//                            </div><!--end card-->
//                        </div><!--end col-->
//                    </div>
//                    <div class="card-body">
//                    <div class="card-header p-0 pt-3 pb-3">
//                        <div class="text-center"><h4>Accommodation Detail Photos</h4></div>
//                    </div>
//                      <div class="row ">`,
//        // loop item
//        cardEnd = `   </div>
//                    </div>
//                </div>`;
//    //
//    Array.prototype.forEach.call(row.accommodationPhotosDto,
//        function (item) {
//            card += `<div class="col-lg-4">
//                         <div class="card e-co-product">
//                             <a href="">
//                                 <img id="${item.id}" src="${item.photoPath}" alt="" class="img-fluid">
//                             </a>
//                         </div><!--end card-->
//                     </div><!--end col-->`;
//        });
//    card += cardEnd;
//    return card;
//}

//#endregion

//#region modal for ContactInfo
//$(document).on("click", "#contactInfo", function () {

//    var contactInfoId = $(this).data("id");
//    $.ajax({
//        url: "/Dashboard/ContactInfo/GetContactInfo",
//        data: { id: contactInfoId }
//    }).done(function (response) {
//        $("#contactInfoModal .modal-dialog").html(response);
//    }).fail(function (xhr) {
//        window.Swal.fire({
//            icon: 'error',
//            title: 'Oops...',
//            text: xhr.responseText
//        });
//    });
//});
//#endregion



