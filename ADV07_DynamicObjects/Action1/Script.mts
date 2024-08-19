Systemutil.Run "C:\Program Files (x86)\OpenText\UFT One\samples\Flights Application\FlightsGUI.exe"

WpFWindow("devname:=OpenText MyFlight Sample Application").WpfEdit("devname:=agentName").Set "John"
WpFWindow("devname:=OpenText MyFlight Sample Application").WpfEdit("devname:=password").Set "hp"
WpFWindow("devname:=OpenText MyFlight Sample Application").WpfButton("devname:=okButton").Click

WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select "Denver" @@ hightlight id_;_1976243792_;_script infofile_;_ZIP::ssf6.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Frankfurt" @@ hightlight id_;_1948941640_;_script infofile_;_ZIP::ssf10.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfCalendar("datePicker").SetDate "3-Sep-2033" @@ hightlight id_;_2005377976_;_script infofile_;_ZIP::ssf11.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1948952440_;_script infofile_;_ZIP::ssf15.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1948953688_;_script infofile_;_ZIP::ssf17.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1948953448_;_script infofile_;_ZIP::ssf18.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 1,0 @@ hightlight id_;_1948955800_;_script infofile_;_ZIP::ssf19.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1976246048_;_script infofile_;_ZIP::ssf20.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson" @@ hightlight id_;_1948955512_;_script infofile_;_ZIP::ssf21.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1948956616_;_script infofile_;_ZIP::ssf22.xml_;_
WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click @@ hightlight id_;_1948956808_;_script infofile_;_ZIP::ssf23.xml_;_
WpfWindow("OpenText MyFlight Sample").Close @@ hightlight id_;_1966924_;_script infofile_;_ZIP::ssf25.xml_;_



