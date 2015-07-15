var massage = massage || {};

massage.smoothScroll = function () {
    var $menuItems = $('.menu-item');
    var $cta = $('#call-to-action');
    
    
    $menuItems.each(function (key, value) {
        $(value).click(function (e) {
            var scrollToId = $(this).data('href');
            console.log('scrollToId', scrollToId);
            $('html, body').animate({
                scrollTop: $(scrollToId).offset().top
            }, 700);
            e.preventDefault();
        });
    });


};

$(document).ready(function () {
    massage.smoothScroll();
});