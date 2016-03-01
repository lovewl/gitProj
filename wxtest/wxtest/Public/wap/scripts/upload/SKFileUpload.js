define(['jquery'], function ($) {
    var current_img_start = 0;
    var current_img_no_range = [];
    /**
     * 文件上传后端协议
     * 出错返回协议定义
     * array('error' => $Code, 'message' => $Message)
     * 成功返回协议定义
     * array('error' => 0, 'files' => $files)
     * files结构
     * $files[文件源名] = 服务中文件唯一标示符（可以是路径或其它标示）;
     * 直接使用json_encode打印出来就可以了
     */
    var $wrap1 = $('#uploaded_wrap1');
    var Param1 = {
        fileInputObj: document.getElementById('captureFile1'),
        fileExtension: 'jpg;gif;png;jpeg',
        fileUploadUrl: uploadfile1,
        fileMaxSize: 1024 * 1024 * 8,
        /**
         * 文件上传进度
         * @param {Object} event 事件信息
         * {
     *  total : int, 文件总字节
     *  loaded : int, 文件以加载字节
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象
     * }
         */
        onProgress: function (event) {
            var img = $wrap1.find('.img_' + event.index);
            for (var i = 0; i < img.length; i++) {
                var cur_percent = parseInt((event.loaded / event.total) * 100) / 100;
                $(img[i]).find('.processing').show().css({width: (cur_percent * 100) + '%'});
            }
        },

        /**
         * 文件选择后
         * @param {Object} event 事件信息
         * {
         *  index : int, 文件唯一标识符
       *  target : FileList, 上传文件对象
       * }
         */
        onSelect: function (event) {

            if (($wrap1.find('.img-item-wrap').length + event.target.length) > 8) {
                alert('最多只能上传8张图片哦~~');
                throw {errorCode: -4, target: event.target[i]};
            }
            uploading_images += event.target.length;
            for (var i = 0; i < event.target.length; i++) {
                $('.up-ico-wrap', $wrap1).before('<a class="img-item-wrap img_' + event.index + '" href="javascript:;"></a>');

                var img = $wrap1.find('.img_' + event.index);
                var cur_img_wrap = img[img.length - 1];
                $(cur_img_wrap).html('<span class="close"></span><span class="img-wrap"></span><span class="processing"></span>');

                (function (fileno, file, $) {
                    $(fileno).find('.img-wrap').append('<img src="' + JQ.Think.public_folder + '/images/loading.gif" />');
                })(cur_img_wrap, event.target[i], jQuery);

                $(cur_img_wrap).find('.close').hide();
                $(cur_img_wrap).find('.processing').hide();

            }
        },
        /**
         * 错误处理
         * @param {Object} event 事件信息
         * {
     *  errorCode : int, 错误代码
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象
     * }
         */
        onFailure: function (event) {

            uploading_images--;
            switch (event.errorCode) {
                case SKFileUpload.ERROR_EXTENSION_NOT_MATCH:
                    alert('文件扩展名不在文件过滤列表中');
                    break;
                case SKFileUpload.ERROR_MAX_SIZE:
                    alert('上传文件大小超出了最大限制');
                    break;
                case SKFileUpload.ERROR_REQUEST_FAILED:
                    alert('上传文件时，请求后端失败');
                    break;
                default:
                    alert('文件上传失败' + event.errorCode);
                    break;
            }

            $wrap1.find('.img_' + event.index).remove();

        },
        /**
         * 文件上传成功
         * @param {Object} event 事件信息
         * {
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象,里面的File对象中有个serverData属性，是后端传递的文件唯一标示符
     * }
         */
        onSuccess: function (event) {
            uploading_images--;
            var img = $wrap1.find('.img_' + event.index);
            for (var i = 0; i < img.length; i++) {
                var $img = $(img[i]);
                $img.find('.img-wrap img').attr('src', event.target[i].serverData);
                $img.find('.img-wrap').append('<input name="pic[]" class="picage" type="hidden" value="' + event.target[i].serverData + '"/>');
                $img.find('.close').click(function () {
                    var cur_node = this.parentNode;
                    $.getJSON(rmfile + '&filename=' + encodeURIComponent($(this).next().find('input').val()), function (rs) {
                        if (rs.code != '200') {
                            if (rs.message) {
                                alert(rs.message);
                            } else {
                                alert('删除文件失败，请重试');
                            }
                            return;
                        }
                        cur_node.parentNode.removeChild(cur_node);
                        current_img_start--;
                    });
                }).show();

                $img.find('.processing').hide();
            }
        }
    };

    var p1 = new SKFileUpload();
    p1.init(Param1);

    //第二个控件
    var $wrap2 = $('#uploaded_wrap2');
    var Param2 = {
        fileInputObj: document.getElementById('captureFile2'),
        fileExtension: 'jpg;gif;png;jpeg',
        fileUploadUrl: uploadfile1,
        fileMaxSize: 1024 * 1024 * 8,
        /**
         * 文件上传进度
         * @param {Object} event 事件信息
         * {
     *  total : int, 文件总字节
     *  loaded : int, 文件以加载字节
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象
     * }
         */
        onProgress: function (event) {
            var img = $wrap2.find('.img_' + event.index);
            for (var i = 0; i < img.length; i++) {
                var cur_percent = parseInt((event.loaded / event.total) * 100) / 100;
                $(img[i]).find('.processing').show().css({width: (cur_percent * 100) + '%'});
            }
        },

        /**
         * 文件选择后
         * @param {Object} event 事件信息
         * {
         *  index : int, 文件唯一标识符
       *  target : FileList, 上传文件对象
       * }
         */
        onSelect: function (event) {

            if (($wrap2.find('.img-item-wrap').length + event.target.length) > 8) {
                alert('最多只能上传8张图片哦~~');
                throw {errorCode: -4, target: event.target[i]};
            }
            uploading_images += event.target.length;
            for (var i = 0; i < event.target.length; i++) {
                $('.up-ico-wrap', $wrap2).before('<a class="img-item-wrap img_' + event.index + '" href="javascript:;"></a>');

                var img = $wrap2.find('.img_' + event.index);
                var cur_img_wrap = img[img.length - 1];
                $(cur_img_wrap).html('<span class="close"></span><span class="img-wrap"></span><span class="processing"></span>');

                (function (fileno, file, $) {
                    $(fileno).find('.img-wrap').append('<img src="' + JQ.Think.public_folder + '/images/loading.gif" />');
                })(cur_img_wrap, event.target[i], jQuery);

                $(cur_img_wrap).find('.close').hide();
                $(cur_img_wrap).find('.processing').hide();

            }
        },
        /**
         * 错误处理
         * @param {Object} event 事件信息
         * {
     *  errorCode : int, 错误代码
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象
     * }
         */
        onFailure: function (event) {
            uploading_images--;
            switch (event.errorCode) {
                case SKFileUpload.ERROR_EXTENSION_NOT_MATCH:
                    alert('文件扩展名不在文件过滤列表中');
                    break;
                case SKFileUpload.ERROR_MAX_SIZE:
                    alert('上传文件大小超出了最大限制');
                    break;
                case SKFileUpload.ERROR_REQUEST_FAILED:
                    alert('上传文件时，请求后端失败');
                    break;
                default:
                    alert('文件上传失败' + event.errorCode);
                    break;
            }

            $wrap2.find('.img_' + event.index).remove();
        },
        /**
         * 文件上传成功
         * @param {Object} event 事件信息
         * {
     *  index : int, 文件唯一标识符
     *  target : FileList, 上传文件对象,里面的File对象中有个serverData属性，是后端传递的文件唯一标示符
     * }
         */
        onSuccess: function (event) {
            uploading_images--;
            var img = $wrap2.find('.img_' + event.index);
            for (var i = 0; i < img.length; i++) {
                var $img = $(img[i]);
                $img.find('.img-wrap img').attr('src', event.target[i].serverData);
                $img.find('.img-wrap').append('<input name="pic[]" class="picage" type="hidden" value="' + event.target[i].serverData + '"/>');
                $img.find('.close').click(function () {
                    var cur_node = this.parentNode;
                    $.getJSON(rmfile + '&filename=' + encodeURIComponent($(this).next().find('input').val()), function (rs) {
                        if (rs.code != '200') {
                            if (rs.message) {
                                alert(rs.message);
                            } else {
                                alert('删除文件失败，请重试');
                            }
                            return;
                        }
                        cur_node.parentNode.removeChild(cur_node);
                        current_img_start--;
                    });
                }).show();

                $img.find('.processing').hide();
            }
        }
    };

    var p2 = new SKFileUpload();
    p2.init(Param2);



});