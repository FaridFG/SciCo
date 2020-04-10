$(function() {
    // incoming, logout, and more profile options section starts
    var buttons = document.getElementsByClassName("button");
    for (var i = 0; i < buttons.length; i++) {
        buttons[i].addEventListener("click", function(ev) {
            ev.preventDefault();
            if (($(this).nextAll(".subMenu").hasClass("show")) !== true) {
                $(".show").removeClass("show");
                $(this).nextAll(".subMenu").addClass("show");
            } else {
                $(this).nextAll(".subMenu").removeClass("show");
            }
        })
    }
    // incoming, logout, and more profile options section ends

    // left aside section starts
    $("aside.left > div").hover(function() {
        $(this).css({
            "transform": "translateX(0)",
            "transition": "transform .3s"
        });
    }, function() {
        $(this).css({
            "transform": "translateX(-70%)",
            "transition": "transform .4s"
        });
    });
    // left aside section ends
})