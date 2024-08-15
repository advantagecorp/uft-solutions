If Not WpfWindow("OpenText MyFlight Sample").Exist(1) Then
	SystemUtil.Run "C:\Program Files (x86)\OpenText\UFT One\samples\Flights Application\FlightsGUI.exe"
	Print "Login window not present at the beginning of the test."
	Reporter.ReportEvent micWarning, "CheckLogin", "No Login window found – starting Flight GUI."
Else
	Print "Login window was already open."
	Reporter.ReportEvent micPass, "CheckLogin", "Flight GUI was found…"
End If
WpfWindow("OpenText MyFlight Sample").WpfEdit("agentName").Set "John" @@ hightlight id_;_1942393832_;_script infofile_;_ZIP::ssf1.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("password").SetSecure "650db17be46e917ca399" @@ hightlight id_;_1942397816_;_script infofile_;_ZIP::ssf2.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("OK").Click @@ hightlight id_;_1942397528_;_script infofile_;_ZIP::ssf3.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfObject("John Smith").Check CheckPoint("John Smith")

