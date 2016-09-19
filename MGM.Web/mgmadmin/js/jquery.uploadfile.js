/// <reference path="jquery-1.11.1.min.js" />

(function ($) {

    $.extend({
        leadinUpload: function (options) {
            var opts = $.extend({}, defaults, options);

            if (opts.uploadtype == "add") {

                //添加上传控件按钮图片
                var strHtml = "<div class=\"UploadAdd\"><img src=\"/img/AddImgBtn.png\" /></div><input type=\"file\" name=\"imgFile\"  id=\"imgFile\" class=\"UploadFiled\" />";
                $("." + opts.uploadBoxClass).html(strHtml);
            }
            //隐藏file控件，点击图片弹出文件选择器
            $(".UploadAdd").click(function () {
                $("." + opts.uploadBoxClass).find("#imgFile").click();
            })
            $("#imgFile").bind("change", function () { UploadChange(opts); });
            $(document).on("click", ".delImg", function () {
                UploadDel($(this), opts);
            })
           
        }
    })

    var defaults = {
        uploadBoxClass: "uploadBox",//上传控件容器
        FormId: "myform",//form的ID
        UploadFiled: "/Tools/imgFile.ashx",//上传处理文件
        DeleteFiled: "/Tools/DeleteUpoadFile.ashx",//删除处理文件
        HidFileStore: "hidImgList",//文件名存储input[type=hidden]控件ID
        UploadMultiple:false,//是否可以选择多张图片true可以选择多张图片
        delType: "1",
        uploadtype:"add"
    }

    //选择图片处理函数
    function UploadChange(opts) {
       
        $("#" + opts.FormId).ajaxSubmit({
            beforeSubmit: function (formData, jqForm, options) {
            },
            success: function (data) {
                uploadSuccess(data, opts);
            },
            error: function (data, status, e) {
                alert("上传失败");
            },
            url: opts.UploadFiled,
            type: "post",
            dataType: "json",
            timeout: 60000
        });
        
    }

    //上传成功处理函数
    function uploadSuccess(data, opts) {
        if (data.error == 0) {

            var imgpath = data.url;

            if (opts.UploadMultiple) {
                var htmlImg = "<div class=\"UploadImg\"><img src=\"" + data.url + "\" /><div class=\"delImg\"><img src=\"/img/delImgico.png\" /><input type=\"hidden\" name=\"imgPath\" value='" + data.url + "'/></div></div>";
                $(".UploadAdd").before(htmlImg);
                $("#" + opts.HidFileStore).val($("#" + opts.HidFileStore).val() + imgpath + ",");
            }
            else {
               
                $(".UploadImg").each(function () {
                    var $this = $(this);
                    var strurl = $this.find("input[name=imgPath]").val();
                    UploadDelMethod(strurl, $this, opts);  
                })
                var htmlImg = "<div class=\"UploadImg\"><img src=\"" + imgpath + "\" /><div class=\"delImg\"><img src=\"/img/delImgico.png\" /><input type=\"hidden\" name=\"imgPath\" value='" + imgpath + "'/></div></div>";
                $(".UploadAdd").before(htmlImg);
                $("#" + opts.HidFileStore).val(imgpath);
            }
        }
        else {
            alert(data.message);
        }
    }


    //删除上传图片
    function UploadDel($this,opts) {

        var strurl = $this.find("input[name=imgPath]").val();
        var node = $this.parents(".UploadImg");
        UploadDelMethod(strurl, node, opts);

    }



    function UploadDelMethod(strurl, node, opts) {
        $.ajax({
            type: "post",
            url: opts.DeleteFiled,
            data: {
                delfile: function () {
                    return strurl;
                }
            },
            dataType: "json",
            success: function (data, textStatus) {
                if (opts.UploadMultiple) {
                    $("#" + opts.HidFileStore).val($("#" + opts.HidFileStore).val().replace(strurl + ",", ""));
                }
                else {
                    //$("#" + opts.HidFileStore).val("");
                    $("#" + opts.HidFileStore).val($("#" + opts.HidFileStore).val().replace(strurl, ""));
                }
                node.remove();
            },
            error: function (data, status, e) {
                alert("删除文件失败:" + e);
            }
        });
    }






})(jQuery)

