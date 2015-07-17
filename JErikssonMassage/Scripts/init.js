var massage = massage || {};

massage.smoothScroll = function () {
    var $menuItems = $('.menu-item');
    var $cta = $('#call-to-action');

    var scrollItems = $.merge($menuItems, $cta);

    scrollItems.each(function (key, value) {
        $(value).click(function (e) {
            var scrollToId = $(this).data('href');
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