define(["jquery"], function ($) {
    var common = {};
    var loadingobj = null;
    common.loading = function (str) {
        $("body").append($(loading(str)));
        return $("#loading");
    }
    
    common.loadingClose = function () {
        $("#loading").remove();
    }

    function loading(str) {
        str = str || "加载中";
        return '<div class="pa loading animated pulse" id="loading"><div class="lBox oh"><img src="./images/loading.gif" alt="" class="db"><p>'+str+'</p></div></div>';
    }

    return common;
});