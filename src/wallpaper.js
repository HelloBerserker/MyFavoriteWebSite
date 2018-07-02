var d=new Array("<i>周日</i>","<i>周一</i>","<i>周二</i>","<i>周三</i>","<i>周四</i>","<i>周五</i>","<i>周六</i>");
setInterval(gettime,1000);
function gettime(){
	var clock=document.getElementsByClassName("clock");
	var time=new Date();
	var year=time.getFullYear();
	var month=time.getMonth()+1;
	var day=time.getDate();
	var week=time.getDay();
	var hour=time.getHours();
	var minute=time.getMinutes();
	var icon="<div class='clock-icon'></div>";
	if(hour<10)
		hour="0"+hour;
	if(minute<10)
		minute="0"+minute;
	var date=icon+year+"-"+month+"-"+day+d[week]+"<i>"+hour+":"+minute+"</i>";
	clock[0].innerHTML=date;
}
function showalert(){
	var a=document.getElementsByClassName('alert');
	a[0].style.display='block';
	a[0].focuse();
}