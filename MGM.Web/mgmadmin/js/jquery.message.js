


function ShowMessage(state, text, endtime, linkurl) {
	var strHtml="<div class='message "+state+"'><p>"+text+"</p></div>";
	$("body").append(strHtml);
	var mw=$(".message").width();
	var mh=$(".message").height();
	var ww=$(window).width();
	var wh=$(window).height();
	var lw=(parseInt(ww)-parseInt(mw)-10)/2;
	var lh=(parseInt(wh)-parseInt(mh)-10)/2;	
	$(".message").css("left",lw+"px");
	$(".message").css("top",lh+"px");
	$(".message").animate({opacity:"1"},500)	
	var closeTime=3000;
	if(endtime!=null&&endtime!="")
	{
		closeTime=endtime;	
	}	
	setTimeout(function(){
		
		$(".message").animate({opacity:"0"},500,function(){
			$(".message").remove();
			if(linkurl!=""&&linkurl!=null)
			{
			    if (linkurl == "back") {
			        window.history.back(-1);
			    }
			    else {
			        location.href = linkurl;
			    }
			}		
		});	
	},closeTime)
	
	
	
}
