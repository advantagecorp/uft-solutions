On error resume next
WpfWindow("OpenText MyFlight Sample Application").Activate
WpfWindow("OpenText MyFlight Sample Application").WpfComboBox("fromCity").Select Datatable.Value("CityFrom","Global")
WpfWindow("OpenText MyFlight Sample Application").WpfComboBox("toCity").Select Datatable.Value("CityTo","Global")
' If error occurs then the err.number is not 0
If err.number<>0 Then
	reporter.ReportEvent micFail, "Error Occurred", "Error Number: " & Err.Number & " Error Source: " & Err.source&" --Error Description is: " & Err.Description
	' Moving on to the next iteration
	ExitActionIteration
End If

WpfWindow("OpenText MyFlight Sample Application").WpfCalendar("datePicker").SetDate "09/04/2033"
WpfWindow("OpenText MyFlight Sample Application").WpfComboBox("Class").Select Datatable.Value("Class","Global")
WpfWindow("OpenText MyFlight Sample Application").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_2139500552_;_script infofile_;_ZIP::ssf26.xml_;_
tickets=WpfWindow("OpenText MyFlight Sample Application").WpfComboBox("numOfTickets").GetROProperty("text")
WpfWindow("OpenText MyFlight Sample Application").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1905326680_;_script infofile_;_ZIP::ssf27.xml_;_
WpfWindow("OpenText MyFlight Sample Application").WpfTable("flightsDataGrid").SelectCell 1,1 @@ hightlight id_;_1928772576_;_script infofile_;_ZIP::ssf28.xml_;_
WpfWindow("OpenText MyFlight Sample Application").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_3213198_;_script infofile_;_ZIP::ssf8.xml_;_

' Retrieving the price and substituting in the ExpPrice column
total=WpfWindow("OpenText MyFlight Sample Application").WpfObject("Price").GetROProperty("text")
'msgbox total
DataTable.Value("ActPrice","Global")=CCur(total)

' Retrieving the price and multiplying the number of tickets and substituting their product in the ActPrice field
price=WpfWindow("OpenText MyFlight Sample Application").WpfObject("Price").GetROProperty("text")
DataTable.Value("ExpPrice","Global")=ccur(price)*tickets

WpfWindow("OpenText MyFlight Sample Application").WpfButton("ORDER").Click
WpfWindow("OpenText MyFlight Sample Application").WpfButton("NEW SEARCH").Click




