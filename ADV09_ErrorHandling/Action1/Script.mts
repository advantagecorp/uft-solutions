Systemutil.Run "C:\Program Files (x86)\OpenText\UFT One\samples\Flights Application\FlightsGUI.exe"
WpfWindow("OpenText MyFlight Sample").WpfEdit("agentName").Set Datatable.Value("AgentName","Global") @@ hightlight id_;_2029315136_;_script infofile_;_ZIP::ssf1.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("password").Set Datatable.Value("Password","Global") @@ hightlight id_;_1948699168_;_script infofile_;_ZIP::ssf2.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("OK").Click @@ hightlight id_;_2145843256_;_script infofile_;_ZIP::ssf3.xml_;_

If WpfWindow("OpenText MyFlight Sample").Dialog("Login Failed").Exist(1) Then
    WpfWindow("OpenText MyFlight Sample").Dialog("Login Failed").WinButton("OK").Click
    wait(1)
    WpfWindow("OpenText MyFlight Sample").WpfButton("Cancel").Click
    Reporter.ReportEvent micFail, "Log In", "Log in was NOT successful."   
Else 
    Reporter.ReportEvent micPass, "Log In", "Log in was successful."
    WpfWindow("OpenText MyFlight Sample").Close
    ExitActionIteration    
End If

 @@ hightlight id_;_1508374_;_script infofile_;_ZIP::ssf17.xml_;_

