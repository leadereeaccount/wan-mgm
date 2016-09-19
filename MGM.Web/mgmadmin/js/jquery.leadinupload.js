/// <reference path="jquery-1.11.1.min.js" />


var btnfileaclick = function ($this) {

    $this.parent().siblings(".fileinput").find("input[type=file]").click();

}


var fileonchange = function ($this,formId) {


    var fileid = $this.attr("id");
    var txtid = $this.parent().siblings(".txtfilename").find("input[type=text]").attr("id");

    $("#" + formId).ajaxSubmit({

        beforeSubmit: function (formData, jqForm, options) {
        },
        success: function (data) {
            $("#" + data.txtName).val(data.filePath);
        },
        error: function (data, status, e) {
            alert("上传失败");
        },
        url: "/Tools/Update.ashx",
        type: "post",
        data: { fileid: fileid, txtid: txtid },
        dataType: "json",
        timeout: 60000
    });

}


























