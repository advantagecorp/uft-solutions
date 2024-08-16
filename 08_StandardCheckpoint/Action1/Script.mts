WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select "Denver"
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Frankfurt" @@ hightlight id_;_1964929808_;_script infofile_;_ZIP::ssf8.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("datePicker").SetDate "4-Sep-2033" @@ hightlight id_;_1964932976_;_script infofile_;_ZIP::ssf9.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business"
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1964932640_;_script infofile_;_ZIP::ssf16.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1964879840_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1964890304_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1964935904_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson"
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click
wait 3 ' UFT One will overrun the Flight GUI if we don't wait just a bit
If  WpfWindow("OpenText MyFlight Sample").WpfObject("Order completed").Exist (6) Then
    WpfWindow("OpenText MyFlight Sample").WpfObject("Order completed").Check CheckPoint("Order completed")	
End If
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_2142876408_;_script infofile_;_ZIP::ssf34.xml_;_

