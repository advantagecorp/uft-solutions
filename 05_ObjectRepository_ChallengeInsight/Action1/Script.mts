WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select "Denver" @@ hightlight id_;_1972964088_;_script infofile_;_ZIP::ssf4.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Frankfurt" @@ hightlight id_;_1964929808_;_script infofile_;_ZIP::ssf8.xml_;_
WpfWindow("OpenText MyFlight Sample").InsightObject("datePicker1").Click ' Position cursor on calendar field
WpfWindow("OpenText MyFlight Sample").Type micCtrlDwn + "a" + micCtrlUp ' Select all text in field @@ hightlight id_;_918152_;_script infofile_;_ZIP::ssf39.xml_;_
WpfWindow("OpenText MyFlight Sample").Type  micDel ' Hit delete key
WpfWindow("OpenText MyFlight Sample").InsightObject("datePicker1").Type "09/04/2033"
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1964933408_;_script infofile_;_ZIP::ssf12.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1964932640_;_script infofile_;_ZIP::ssf16.xml_;_
WpfWindow("OpenText MyFlight Sample").InsightObject("FindFlights1").Click
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1964890304_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1964935904_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson"
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_2036179056_;_script infofile_;_ZIP::ssf32.xml_;_

