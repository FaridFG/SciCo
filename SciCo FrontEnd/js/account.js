$(function() {
    // incoming and logout section starts
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
    // incoming and logout section ends

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

    // more profile options click function starts
    $("#more").click(function(ev) {
        ev.preventDefault();
        if (!($("#accountOptions").hasClass("show"))) {
            $("#accountOptions").addClass("show");
        }
        else {
            $("#accountOptions").removeClass("show");
        }
    })
    // more profile options click function ends
})