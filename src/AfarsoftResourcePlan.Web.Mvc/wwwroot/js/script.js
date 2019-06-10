(function () {
    //var activeId = $("#tab-content-tabitem > .active").attr("id");
    //var $ = JQuery.noConflict();
    var $ = function (params) {
        var activeId = $("#tab-content-tabitem > .active").attr("id");
        var $$ = JQuery.noConflict();
        return $$("#" + activeId + " " + params)
    }
})();
