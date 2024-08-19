Dim randomName, passName

WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select "Denver" @@ hightlight id_;_1953559624_;_script infofile_;_ZIP::ssf2.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Frankfurt" @@ hightlight id_;_1950404432_;_script infofile_;_ZIP::ssf4.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("Date").SetDate "4-Sep-2033" @@ hightlight id_;_1950986840_;_script infofile_;_ZIP::ssf6.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1950407408_;_script infofile_;_ZIP::ssf11.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1950407216_;_script infofile_;_ZIP::ssf15.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1950988664_;_script infofile_;_ZIP::ssf16.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1950407696_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click

randomName = string(RandomNumber(1,20), "X")
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set randomName @@ hightlight id_;_1950408176_;_script infofile_;_ZIP::ssf19.xml_;_

' Capture data from the passengerName field at runtime
passName = WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").GetROProperty("text")
 msgbox passName

WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1950410816_;_script infofile_;_ZIP::ssf20.xml_;_
Wait 5

If WpfWindow("OpenText MyFlight Sample").WpfObject("Order completed").Exist Then
	Reporter.ReportEvent micPass, "Order number generated", "Order generated"
Else
	Reporter.ReportEvent micFail, "Order number NOT generated", "Order NOT generated"
End If

WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_1950409376_;_script infofile_;_ZIP::ssf21.xml_;_



