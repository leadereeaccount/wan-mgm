$(function () {
    $(".UploadAdd").click(function () {
        $("#imgFile").click();
    })
    $("#imgFile").bind("change", function () {

        $("#myform").ajaxSubmit({
            beforeSubmit: function (formData, jqForm, options)            {

            },
            success: ShowImg,
            error: function (data, status, e) {
                alert("上传失败");
            },
            url: "/Tools/upload_json.ashx",
            type: "post",
            dataType: "json",
            timeout: 60000
        });
    })
})


function ShowImg(data) {

    if (data.error == 0) {
        var htmlImg = "<div class=\"UploadImg\"><img src=\"" + data.url + "\" /><div onclick=\"FiledUploadDel($(this),'" + data.url + "')\" class=\"delImg\"><img src=\"/Upload/img/delImgico.png\" /></div></div>";
        $(".UploadAdd").before(htmlImg);
        $("#hidImgList").val($("#hidImgList").val() + data.url + ",");
    }
}



function FiledUploadDel(th, imgurl) {
    var node = th.parents(".UploadImg");
    $.ajax({
        type: "post",
        url: "/Tools/DeleteUpoadFile.ashx",
        data: {
            delfile: function () {
                return imgurl;
            }
        },
        dataType: "json",
        success: function (data, textStatus) {
            if (data.error == 1) {
                alert(data.msbox);
            }
            else {

                $("#hidImgList").val($("#hidImgList").val().replace(imgurl + ",", ""));
                node.remove();
                
            }
        },
        error: function (data, status, e) {
            alert("删除文件失败:" + e);
        }
    });


    

}
