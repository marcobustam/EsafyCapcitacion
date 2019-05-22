// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $("#menu-toggle").click(function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
        // alert("remove");
        $("#menu-toggle2").removeAttr("hidden");
        // alert("removed");
    });
    $("#menu-toggle2").click(function (e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
        // alert("add");
        $("#menu-toggle2").attr("hidden","hidden");
        // alert("added");
    });
    $('#datata').DataTable({
        "paging": true,
        "ordering": true,
        "info": true,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        }

    });

});