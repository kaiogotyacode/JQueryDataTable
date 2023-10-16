// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(() => {

    $('#people-table').DataTable({
        "ordering": true,
        "paging": true,
        "searching": true

    });

 });



function deletePeople(id) {
    $.ajax({
        url: `Home/Delete/${id}`,
        method: 'DELETE',
        success: function (success) {
            document.location.reload();
        },
        error: function (error) {
            document.location.reload();
        }
    });
}















