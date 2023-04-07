// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".toggle-items-btn").click(function () {
        var itemsList = $(this).parent().find(".items-list");
        itemsList.toggle();
        if (itemsList.is(":visible")) {
            $(this).text("Hide Items");
        } else {
            $(this).text("Show Items");
        }
    });
});

