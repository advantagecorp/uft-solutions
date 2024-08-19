Dim dbConnection, dbQuery, dbResults, recordCounter

' Create and open a connection to an ActiveX object database
Set dbConnection = CreateObject("ADODB.Connection")
dbConnection.Open("dsn=Flight") ' Created with the DSN Administrator

' Create a result set and run a query to populate it with data
dbQuery = "SELECT CityName FROM Cities ORDER BY CityName ASC LIMIT 3"
Set dbResults = CreateObject("ADODB.Recordset")
dbResults.Open dbQuery, dbConnection ' Run the query and get the results

dbResults.MoveFirst
recordCounter = 1
DataTable.GetSheet("Global").AddParameter "p_fromCity", "" ' Create the parameter

Do Until dbResults.EOF
	DataTable.SetCurrentRow recordCounter
	DataTable("p_fromCity") = dbResults.Fields("CityName")
	recordCounter = recordCounter + 1
	dbResults.MoveNext
Loop

dbConnection.Close
Set dbConnection = Nothing
Set dbResults = Nothing
	
For i = 1 to recordCounter - 1
	DataTable.GetSheet("Global").SetCurrentRow(i)
	fromCity = DataTable("p_fromCity", dtGlobalSheet)
	WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").Select fromCity @@ hightlight id_;_1953559624_;_script infofile_;_ZIP::ssf2.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").Select "Seattle" @@ hightlight id_;_1950404432_;_script infofile_;_ZIP::ssf4.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfCalendar("Date").SetDate "4-Sep-2033" @@ hightlight id_;_1950986840_;_script infofile_;_ZIP::ssf6.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfComboBox("Class").Select "Business" @@ hightlight id_;_1950407408_;_script infofile_;_ZIP::ssf11.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfComboBox("numOfTickets").Select "2" @@ hightlight id_;_1950407216_;_script infofile_;_ZIP::ssf15.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfButton("FIND FLIGHTS").Click @@ hightlight id_;_1950988664_;_script infofile_;_ZIP::ssf16.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfTable("flightsDataGrid").SelectCell 2,0 @@ hightlight id_;_1950407696_;_script infofile_;_ZIP::ssf17.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfButton("SELECT FLIGHT").Click @@ hightlight id_;_1950409040_;_script infofile_;_ZIP::ssf18.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfEdit("passengerName").Set "John Jackson" @@ hightlight id_;_1950408176_;_script infofile_;_ZIP::ssf19.xml_;_
	WpfWindow("OpenText MyFlight Sample").WpfButton("ORDER").Click @@ hightlight id_;_1950410816_;_script infofile_;_ZIP::ssf20.xml_;_
	Wait 5
	WpfWindow("OpenText MyFlight Sample").WpfButton("NEW SEARCH").Click
Next

