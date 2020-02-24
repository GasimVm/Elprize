$('#table tbody').on('dblclick', 'tr', function () {
    window.location.href = $(this).attr('data-href');
});