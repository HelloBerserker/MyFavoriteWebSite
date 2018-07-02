 window.onscroll=function(){
        var top=window.pageYOffset;
        var fixed=document.getElementsByClassName("right-wrap")[0];
        var totop=document.getElementsByClassName("tothetop")[0];
        var left=fixed.offsetLeft+"px";
        if(top>180)
        {
        	fixed.style.position="fixed";
        	fixed.style.top="0px";
        	fixed.style.left=left; 
            totop.style.display="block";    	
        }
        else
        {
        	fixed.style.position="relative";
        	fixed.style.top="0px";
        	fixed.style.left="0px";
            totop.style.display="none"; 
        }
    }
 $( function () {
            var speed = 1000;//自定义滚动速度
            //回到顶部
            $( ".tothetop").click( function () {
                $( "html,body").animate({ "scrollTop" : 0 }, speed);
                });           
        });
 $(function(){
    $(".btn.check").click(function(){
        $(this).css({"background-color":"#00BFF3","color":"#FFF"}).addClass("good");//color:#FFF, background:#00BFF3        
    })
 })