/**
参数说明:
c: 提示主体内容,
i: 提示框图片
btn_one_text: 第1按钮文字 
btn_two_text：第2按钮文字
close: 0|1 是否显示关闭X
btn_two_show: 0|1 是否显示第2按钮
callback：整体设置回调
cancelCallback: function(o) //关闭按钮回调 返回false时，窗口不关闭
btnOneCallback: function(o) //按钮1回调 返回false时，窗口不关闭
btnTwoCallback: function(o) //按钮1回调 返回false时，窗口不关闭
================================================
使用说明
requirejs.config({
            baseUrl: '../Public/js/',
            paths: {
                jquery: "vonder/jquery", 
                common: "common"
            });
            
 require(['jquery', 'common'], function ($, c) {
    
    c.tip({
            c: "所选部位已加入购物车~",
            btn_one_text: "查看购物车",
            i: "../Public/images/cart.png",
            close: 1,
            btnOneCallback:function(o){
                alert(1);
                return false;
            }
        });
    
    c.tip({
            c: "您还未选择部位哦~"
        });
    
    c.loading();
    c.loadingClose();
    
 });            

*/

define(["jquery"], function ($) {
    var common = {};
    var loadingobj = null;
    common.tip = function (opts) {
        var opt = {
            c: "提示内容",
            i: JQ.Think.tpl_public + "/images/notice.png",
            url_one: "javascript:void(0);",
            btn_one_text: "我知道了",

            url_two: "javascript:void(0);",
            btn_two_text: "取消",
            btn_two_show: 0,
            close: 0,

        }
        opt = $.extend(opt, opts);
        $("body").append($(tips(opt)));
        if (opt.close) $("#closeico").css("visibility", "visible");

        if (opt.callback) opt.callback($("#tip"));

        if (opt.cancelCallback) {
            $("#closeico").click(function () {
                var bkstatus = opt.cancelCallback($("#tip"));
                if (bkstatus !== false) {
                    $("#tip").remove();
                }
            });
        } else {
            $("#closeico").click(function () {
                $("#tip").remove();
            });
        }


        if (opt.btnOneCallback) {
            $("#tipBtn").click(function () {
                var bkstatus = opt.btnOneCallback($("#tip"));
                if (bkstatus !== false) {
                    $("#tip").remove();
                }
            });

        } else {
            $("#tipBtn").click(function () {
                $("#tip").remove();
            });
        }

        if (opt.btn_two_show) {
            if (opt.btnTwoCallback) {
                $("#tipBtn2").click(function () {
                    var bkstatus = opt.btnTwoCallback($("#tip"));
                    if (bkstatus !== false) {
                        $("#tip").remove();
                    }
                });

            } else {
                $("#tipBtn2").click(function () {
                    $("#tip").remove();
                });
            }
        }
    }

    common.loading = function (str) {
        $("body").append($(loading(str)));
        //loadingobj = $("#loading");
        return $("#loading");
    }

    common.loadingClose = function () {
        $("#loading").remove();
        //loadingobj = null;
    }

    common.radio = function (o) {
        o.wrap('<a href="javascript:void(0);" class="db radios pr"></a>');
        o.before('<span class="raBtn db pa"></span>');
        o.parents("a").click(function () {
            if ($(this).hasClass("on")) $("input", this).val(0);
            else $("input", this).val(1);
            $(this).toggleClass("on");
        });
    }

    common.floatval = function (n) {
        var ret = parseFloat(n);
        return isNaN(ret) ? 0 : ret;
    }
    common.intval = function (n) {
        var ret = parseInt(n);
        return isNaN(ret) ? 0 : ret;
    }

    function tips(opt) {
        var winhtml = '<div class="px loading animated pulse" id="tip"><div class="tipBox oh pr"><span class="closeico db pa" id="closeico"></span><img src="' + opt.i + '" alt="" class="db" id="tipimg"><p id="tipcon">' + opt.c + '</p><a href="' + opt.url_one + '" class="tipBtn pa" id="tipBtn">' + opt.btn_one_text + '</a>';
        if (opt.btn_two_show) {
            winhtml += '<a href="' + opt.url_two + '" class="tipBtn pa" id="tipBtn2">' + opt.btn_two_text + '</a>';
        }
        winhtml += '</div></div>';
        return winhtml;
    }

    function loading(str) {
        str = str || "加载中";
        return '<div class="px loading animated pulse" id="loading"><div class="lBox oh"><img src="' + JQ.Think.tpl_public + '/images/loading.gif" alt="" class="db"><p>' + str + '</p></div></div>';
    }


    function hideAddressBar_ios() {
        if (document.documentElement.scrollHeight <= document.documentElement.clientHeight) {
            var bodyTag = document.getElementsByTagName('body')[0];
            bodyTag.style.height = document.documentElement.clientWidth / screen.width * screen.height + 'px';
        }
        setTimeout(function () {
            window.scrollTo(0, 1);
        }, 100);
    };
    function hideAddressBar_android() {
        var n = navigator.userAgent;
        if (n.match(/UCBrowser/i)) {
            //uc浏览器
            hideAddressBar_ios();
            return false;
        }
        var self = document.getElementsByTagName('body')[0];
        if (self.requestFullscreen) {
            self.requestFullscreen();
        } else if (self.mozRequestFullScreen) {
            self.mozRequestFullScreen();
        } else if (self.webkitRequestFullScreen) {
            self.webkitRequestFullScreen();
        }
    };
    window.addEventListener("load", function () {
        navigator.userAgent.match(/Android/i) ? hideAddressBar_android() : hideAddressBar_ios();
    });



    return common;
});