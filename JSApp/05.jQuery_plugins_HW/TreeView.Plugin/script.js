(function ($) {
    $.fn.treeView = function () {
        var a = this.find("a");
        a.on("click", function () {
            var ul = $(this).next("ul");
            if (ul.hasClass("collapsed")) {
                ul.removeClass("collapsed").show();
            }
            else {
                ul.addClass("collapsed").hide();
            }
        });
        return this;
    }
}(jQuery));

// to see .toggle()