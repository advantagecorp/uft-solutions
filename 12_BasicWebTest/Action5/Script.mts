SystemUtil.Run "C:\Program Files\Google\Chrome\Application\chrome.exe"
Browser("Advantage Shopping").Navigate "http://nimbusserver.aos.com:8000/#/"
Browser("Advantage Shopping").Page("Advantage Shopping").Link("UserMenu").Click @@ hightlight id_;_10000000_;_script infofile_;_ZIP::ssf1.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("username").Set "demo_user" @@ hightlight id_;_10000000_;_script infofile_;_ZIP::ssf2.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("password").SetSecure "6514963fe4080292ddc3ebbbec1454291a52e872c475b364" @@ hightlight id_;_10000000_;_script infofile_;_ZIP::ssf3.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("sign_in_btnundefined").Click @@ hightlight id_;_10000000_;_script infofile_;_ZIP::ssf4.xml_;_
