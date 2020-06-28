
			
		for (var start = 1; start<300000 ; start++)

			setTimeout(function loadXMLDoc()
		{
		//while (true){
			var xmlhttp;
			if (window.XMLHttpRequest)
			{
				//  IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
				xmlhttp=new XMLHttpRequest();
			}
			else
			{
				// IE6, IE5 浏览器执行代码
				xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
			}
			xmlhttp.onreadystatechange=function()
			{
				if (xmlhttp.readyState==4 && xmlhttp.status==200)
				{
					document.getElementById("title").innerHTML=(xmlhttp.responseText);
				}
			}
			xmlhttp.open("GET","config.txt",true);
			xmlhttp.send();
		
			var xmlhttp1;
			if (window.XMLHttpRequest)
			{
				//  IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
				xmlhttp1=new XMLHttpRequest();
			}
			else
			{
				// IE6, IE5 浏览器执行代码
				xmlhttp1=new ActiveXObject("Microsoft.XMLHTTP");
			}
			xmlhttp1.onreadystatechange=function()
			{
				if (xmlhttp1.readyState==4 && xmlhttp1.status==200)
				{
					document.getElementById("side-control").innerHTML=(xmlhttp1.responseText);
				}
			}
			xmlhttp1.open("GET","side.txt",true);
			xmlhttp1.send();

			var xmlhttp2;
			if (window.XMLHttpRequest)
			{
				//  IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
				xmlhttp2=new XMLHttpRequest();
			}
			else
			{
				// IE6, IE5 浏览器执行代码
				xmlhttp2=new ActiveXObject("Microsoft.XMLHTTP");
			}
			xmlhttp2.onreadystatechange=function()
			{
				if (xmlhttp2.readyState==4 && xmlhttp1.status==200)
				{
					document.getElementById("little-title").innerHTML=(xmlhttp2.responseText);
				}
			}
			xmlhttp2.open("GET","config-s.txt",true);
			xmlhttp2.send();

			}, 300 * start);
