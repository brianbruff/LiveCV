/// <reference path="jquery-1.7.1.min.js" />
/// <reference path="jquery-ui-1.8.16.min.js" />

var menuHandler = function () {
    var busy = false;

    var init = function () {
        // Set the inital content for the view
        //$("#content").load("PersonalDetails");

        $("#topmenu a").click(function (e) {
            selectTab($(this), e);
            e.preventDefault();
        });
    };

    var selectTab = function (ws, event) {

        if (busy)
            return;

        busy = true;

        $("#topmenu a").removeClass("highlight");
        var href = ws.get(0).href;

        var contentWrapSet = $("#content")

        //contentWrapSet.slideUp("fast", function () {
            contentWrapSet.load(href, function () {
                ws.addClass("highlight");
                ws.blur();
                contentWrapSet.slideDown("fast");
                busy = false;
            });
        //});
        }

    return {
        init: init
    }
};


$(function () {
    var topMenu = new menuHandler();
    topMenu.init();        
});