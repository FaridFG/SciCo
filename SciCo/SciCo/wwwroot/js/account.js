$(function() {
    // search action scripts start
    $(".account > header > .form button").click(function(ev){
        if(($(".account > header > .form input")).val() == ""){
            ev.preventDefault();
            alert("You must enter user's name and surname to search...");
        }
    })
    // search action scripts end

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

    document.addEventListener("scroll", function() {
        if (window.visualViewport.pageTop > 570) {
            $("aside.left > div").css({
                "transform": "translateX(0)",
                "transition": "transform .6s",
                "border": "none",
                "box-shadow": "none"
            });
            $("aside.left").css({
                "height": "calc(100vh - 75px)",
                "top": "75px",
                "background-color": "#fff",
                "border-right": "3px solid rgb(73, 76, 98)"
            })
            $("aside.left > div:nth-child(1)").css({
                "margin-top": "30px"
            });
            $("aside.left > div").mouseleave(function() {
                $(this).css({
                    "transform": "translateX(0)"
                });
            });
        } else {
            $("aside.left > div").css({
                "transform": "translateX(-70%)",
                "transition": "transform .3s",
                "border-right": "5px solid rgb(73, 76, 98)",
                "box-shadow": "0 3px 3px 3px rgba(50, 51, 63, 0.2)"
            });
            $("aside.left").css({
                "height": "auto",
                "top": "115px",
                "background": "none",
                "border-right": "none"
            });
            $("aside.left > div:nth-child(1)").css({
                "margin-top": "0"
            });
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
        }
    })
    // left aside section ends

    // write message section starts
    $("#write").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeIn(1000);
        $("#messageBox").fadeIn(1000);
    })
    $("#close").click(function(ev){
        ev.preventDefault();
        $("#popup").slideUp("fast");
        $("#messageBox").slideUp("fast");
    })
    // write message section ends

    // delete my account popup starts
    $("#delete").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#deleteBox").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#deleteBox").fadeOut("slow");
    })
    // delete my account popup ends

    // profile options section starts
    // let profileOptions = document.querySelectorAll("#options > ul > li");
    // let options = Array.from(profileOptions);
    // options.splice(3, 1);
    // $(options[0]).addClass("active");

    // for (var i = 0; i < options.length; i++) {
    //     options[i].addEventListener("click", function() {
    //         if (!($(options[i]).hasClass("active"))) {
    //             $(".active").removeClass("active");
    //             $(this).addClass("active");
    //         } else {
    //             $(this).addClass("active");
    //         }
    //     })
    // }
    // profile options section ends
})