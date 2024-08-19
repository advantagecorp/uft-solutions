Dim CitiesCount
Dim flyFromChoice, flyToChoice

' The number of items in the list can be found using GetItemsCount()
CitiesCount = WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").GetItemsCount()

' List items can be selected by either name OR number
' They are numbered starting at 0, so 10 items are numbered 0-9
flyFromChoice = RandomNumber(0 , citiesCount - 1)
flyToChoice = RandomNumber(0 , citiesCount - 1)

While flyToChoice = flyFromChoice  ' If they are the same city
	flyToChoice = RandomNumber(0 , citiesCount - 1)
Wend

Select Case flyFromChoice
	Case 7
		flyToChoice = RandomNumber(0 , citiesCount - 3) ' Don't select the last three items
	Case 9
		flyToChoice = RandomNumber(0 , citiesCount - 1) ' Don't select the last item (Zurich)
End Select 

WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select flyFromChoice @@ hightlight id_;_1953559624_;_script infofile_;_ZIP::ssf2.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select flyToChoice @@ hightlight id_;_1950404432_;_script infofile_;_ZIP::ssf4.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("Date").SetDate "4-Sep-2033" @@ hightlight id_;_1950986840_;_script infofile_;_ZIP::ssf6.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1950407408_;_script infofile_;_ZIP::ssf11.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1950407216_;_script infofile_;_ZIP::ssf15.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1950988664_;_script infofile_;_ZIP::ssf16.xml_;_

' Choose a random flight from the Flights Table after getting the count of items
flightsTableCount=WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").RowCount
flightsTableChoice=RandomNumber(0 , flightsTableCount - 1)

WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell flightsTableChoice, 0 @@ hightlight id_;_1950407696_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1950409040_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson" @@ hightlight id_;_1950408176_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1950410816_;_script infofile_;_ZIP::ssf20.xml_;_
Wait 5
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click

