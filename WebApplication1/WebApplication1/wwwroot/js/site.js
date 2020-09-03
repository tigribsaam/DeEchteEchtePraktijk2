// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function DateFormat(date, id) {
    let formattedDate = (date.getMonth() + 1) + "-" + (date.getDate()) + "-" + date.getFullYear()
    document.getElementById(id).innerHTML = formattedDate
    console.log(formattedDate)
}
