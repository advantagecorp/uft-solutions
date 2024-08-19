Dim flyFromCity, flyToCity
Dim randomName, randomTickets, randomClass
Const numClasses = 3

' Input the departure and arrival cities from the tester
flyFromCity = InputBox("What is the departure city?")
flyToCity = InputBox("What is the arrival city?")

' Simulate test data using random numbers
randomName = string(RandomNumber(1,20), "X")
randomTickets = RandomNumber(1, 5)
randomClass = RandomNumber(1, numClasses)

WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select flyFromCity
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select flyToCity
WpfWindow("OpenText MyFlight Sample").WpfCalendar("Date").SetDate "09/04/2033"
Select Case randomClass
	Case 1:
		WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "First"
	Case 2:
		WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business"
	Case 3:
		WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Economy"
End Select

WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select randomTickets
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1950988664_;_script infofile_;_ZIP::ssf16.xml_;_

WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1950407696_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1950409040_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set randomName @@ hightlight id_;_1950408176_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1950410816_;_script infofile_;_ZIP::ssf20.xml_;_
Wait 5
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click



