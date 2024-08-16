SystemUtil.Run "C:\Program Files (x86)\OpenText\UFT One\samples\Flights Application\FlightsGUI.exe"
WpfWindow("OpenText MyFlight Sample").WpfEdit("agentName").Set DataTable("p_AgentName", dtGlobalSheet) @@ hightlight id_;_1942393832_;_script infofile_;_ZIP::ssf1.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("password").Set DataTable("p_Password", dtGlobalSheet) @@ hightlight id_;_1942397816_;_script infofile_;_ZIP::ssf2.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("OK").Click @@ hightlight id_;_1942397528_;_script infofile_;_ZIP::ssf3.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfObject("John Smith").Check CheckPoint("John Smith") @@ hightlight id_;_1946106136_;_script infofile_;_ZIP::ssf4.xml_;_

