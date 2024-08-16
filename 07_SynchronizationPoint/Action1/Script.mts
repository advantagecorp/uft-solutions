WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select "Denver" @@ hightlight id_;_1972964088_;_script infofile_;_ZIP::ssf4.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Frankfurt" @@ hightlight id_;_1964929808_;_script infofile_;_ZIP::ssf8.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("datePicker").SetDate "4-Sep-2033" @@ hightlight id_;_1964932976_;_script infofile_;_ZIP::ssf9.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1964933408_;_script infofile_;_ZIP::ssf12.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1964932640_;_script infofile_;_ZIP::ssf16.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1964879840_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1964890304_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1964935904_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson"
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click
WpfWindow("OpenText MyFlight Sample").WpfObject("Order completed").WaitProperty "enabled", true, 10000
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_2036179056_;_script infofile_;_ZIP::ssf32.xml_;_

