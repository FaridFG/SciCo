var terms = document.querySelector("#agreement input");
var submit = document.querySelector("#signup button");

submit.addEventListener("click", function(ev) {
    if (terms.checked === false) {
        ev.preventDefault();
        document.querySelector("#agreeTerms").style.display = "block";
    }
});