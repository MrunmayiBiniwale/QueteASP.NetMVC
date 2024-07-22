// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { data } = require("jquery");

// Write your JavaScript code.

function deleteArticle(Id) {
    debugger;
    if (confirm("Do you want to delete this article?")) {
        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: '/Article/DeleteArticle',
            data: { id: Id },
            success: function (data) {
                debugger;
                if (data.id > 0) {
                    alert("Article deleted successfully!");
                    window.location.href = "/Article/ListArticles";
                }
            },
            error: function () {
                alert("Error occured! Please try again.");
            }
        });         
    }
}



