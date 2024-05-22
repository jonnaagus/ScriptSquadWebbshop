document.addEventListener("DOMContentLoaded", function () {
    const navbarToggler = document.getElementById("navbar-toggler");
    const navbarDropdown = document.getElementById("navbar-dropdown");

    navbarToggler.addEventListener("click", function () {
        navbarDropdown.classList.toggle("show");
    });
});