WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select DataTable("p_FlightFrom", dtGlobalSheet) @@ hightlight id_;_1958781272_;_script infofile_;_ZIP::ssf3.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select DataTable("p_FlightTo", dtGlobalSheet) @@ hightlight id_;_1958781800_;_script infofile_;_ZIP::ssf5.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("datePicker").SetDate "4-Sep-2033" @@ hightlight id_;_1958782280_;_script infofile_;_ZIP::ssf6.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1958781944_;_script infofile_;_ZIP::ssf8.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1958781464_;_script infofile_;_ZIP::ssf11.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1958781368_;_script infofile_;_ZIP::ssf12.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1958775896_;_script infofile_;_ZIP::ssf13.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1997139744_;_script infofile_;_ZIP::ssf14.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set DataTable("p_PassengerName", dtGlobalSheet) @@ hightlight id_;_1997141616_;_script infofile_;_ZIP::ssf15.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1639280_;_script infofile_;_ZIP::ssf18.xml_;_
'WpfWindow("OpenText MyFlight Sample").WpfObject("$410.00").Check CheckPoint("$410.00") @@ hightlight id_;_1916820832_;_script infofile_;_ZIP::ssf19.xml_;_
Wait 5
WpfWindow("OpenText MyFlight Sample").WpfObject("Order 182 completed").Output CheckPoint("Order 182 completed") @@ hightlight id_;_2103610208_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfObject("TicketPrice").Output CheckPoint("TicketPrice") @@ hightlight id_;_2103610208_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_1997151744_;_script infofile_;_ZIP::ssf17.xml_;_


'Optional steps 
'WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select RandomNumber("p_RandomTickets")'
'WpfWindow("OpenText MyFlight Sample").WpfObject("Order 182 completed").Check CheckPoint("Order 182 completed_2")
