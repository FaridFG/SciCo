$(function() {
    // search action scripts start
    $(".account > header > .form button").click(function(ev){
        if(($(".account > header > .form input")).val().trim() == ""){
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

    // updating profile and cover photos starts
    $("#userImage").click(function (ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#pictureBox").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#pictureBox").fadeOut("slow");
    })

    $("#profileImage").click(function (ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#pictureBoxProfile").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#pictureBoxProfile").fadeOut("slow");
    })

    $("#coverImage").click(function (ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#pictureBoxCover").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#pictureBoxCover").fadeOut("slow");
    })

    $("#addNewPhoto").click(function (ev) {
        ev.preventDefault();
        $("#newPhoto").click();
    })
    
    $("#changeProfilePhoto").click(function (ev) {
        ev.preventDefault();
        $("#pPhoto").click();
    })

    $("#changeCoverPhoto").click(function (ev) {
        ev.preventDefault();
        $("#cPhoto").click();
    })

    if($("#pictureBox form input").val() == ""){
        $("#pictureBox img").css("display", "none");
        $("#pictureBox > div:nth-child(2) p").css("display", "block");
    } else {
        $("#pictureBox img").css("display", "block");
        $("#pictureBox > div:nth-child(2) p").css("display", "none");
    }

    if($("#pictureBoxProfile form input").val() == ""){
        $("#pictureBoxProfile img").css("display", "none");
        $("#pictureBoxProfile > div:nth-child(2) p").css("display", "block");
    } else {
        $("#pictureBoxProfile img").css("display", "block");
        $("#pictureBoxProfile > div:nth-child(2) p").css("display", "none");
    }

    if($("#pictureBoxCover form input").val() == ""){
        $("#pictureBoxCover img").css("display", "none");
        $("#pictureBoxCover > div:nth-child(2) p").css("display", "block");
    } else {
        $("#pictureBoxCover img").css("display", "block");
        $("#pictureBoxCover > div:nth-child(2) p").css("display", "none");
    }
    // updating profile and cover photos ends

    // showing new image in the div
    var newImageInput = document.querySelector("#pictureBox form input[type='file']");
    newImageInput.addEventListener("change", function() {
        openFile(event, "Img");
        if($("#pictureBox form input").val() == ""){
            $("#pictureBox img").css("display", "none");
            $("#pictureBox > div:nth-child(2) p").css("display", "block");
        } else {
            $("#pictureBox img").css("display", "block");
            $("#pictureBox > div:nth-child(2) p").css("display", "none");
        }
    })
    // showing new image in the div

    // showing profile image in the div
    var profileInput = document.querySelector("#pictureBoxProfile form input[type='file']");
    profileInput.addEventListener("change", function() {
        openFile(event, "profileImg");
        if($("#pictureBoxProfile form input").val() == ""){
            $("#pictureBoxProfile img").css("display", "none");
            $("#pictureBoxProfile > div:nth-child(2) p").css("display", "block");
        } else {
            $("#pictureBoxProfile img").css("display", "block");
            $("#pictureBoxProfile > div:nth-child(2) p").css("display", "none");
        }
    })
    // showing profile image in the div

    // showing cover image in the div
    var coverInput = document.querySelector("#pictureBoxCover form input[type='file']");
    coverInput.addEventListener("change", function() {
        openFile(event, "coverImg");
        if($("#pictureBoxCover form input").val() == ""){
            $("#pictureBoxCover img").css("display", "none");
            $("#pictureBoxCover > div:nth-child(2) p").css("display", "block");
        } else {
            $("#pictureBoxCover img").css("display", "block");
            $("#pictureBoxCover > div:nth-child(2) p").css("display", "none");
        }
    })
    // showing cover image in the div

    // function for showing images in the divs and overriding fakepath error
    var openFile = function(event, id) {
        var input = event.target;
        var reader = new FileReader();
        reader.onload = function() {
            var dataURL = reader.result;
            var picture = document.getElementById(id);
            picture.src = dataURL;
        }
        reader.readAsDataURL(input.files[0]);
    }
    // function for showing images in the divs and overriding fakepath error

    // preventing empty inputs
    $("#submitPhoto").click(function(ev){
        if($("#newPhoto").val() == ""){
            ev.preventDefault();
        }
    })
    $("#submitProfilePhoto").click(function(ev){
        if($("#pPhoto").val() == ""){
            ev.preventDefault();
        }
    })
    $("#submitCoverPhoto").click(function(ev){
        if($("#cPhoto").val() == ""){
            ev.preventDefault();
        }
    })
    // preventing empty inputs

    // modal for opening an image
    $(".photos").click(function(ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#imageModal").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#imageModal").fadeOut("slow");
    })

    $("#openProfilePhoto").click(function(ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#imageModal").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#imageModal").fadeOut("slow");
    })

    $("#openCoverPhoto").click(function(ev) {
        ev.preventDefault();
        $("#popup").fadeIn("fast");
        $("#imageModal").fadeIn("fast");
    })
    $(".close").click(function(ev){
        ev.preventDefault();
        $("#popup").fadeOut("slow");
        $("#imageModal").fadeOut("slow");
    })
    // modal for opening an image
})