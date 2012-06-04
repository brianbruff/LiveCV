// <reference path="jquery-1.7.1.min.js" />
// <reference path="jquery-ui-1.8.16.min.js" />

var menuHandler = function () {
    var busy = false;

    var init = function () {
        var wsMenu = $("#topmenu a");
        wsMenu.removeClass("highlight");

        // Now find 
        var currentUrl = window.location.href.toLowerCase();
        if (currentUrl.substr(-1) == '/')
            currentUrl = currentUrl.substr(0, currentUrl.length - 1);

        wsMenu.each(function (index, element) {            
            if (element.href.toLowerCase() == currentUrl)
                $(this).addClass("highlight");
        });
        

    };

    

    return {
        init: init
    }
};


$(function () {
    var topMenu = new menuHandler();
    topMenu.init();        
});