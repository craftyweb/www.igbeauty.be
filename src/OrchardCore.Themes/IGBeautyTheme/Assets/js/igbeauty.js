$(document).ready(function () {
    var urlPath = window.location.pathname

    var link = document.querySelectorAll("a[href='" + urlPath + "']")

    $(link).addClass("current");
})