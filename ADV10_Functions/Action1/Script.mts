﻿getOrdersGreaterThan(90)

'Function getOrdersGreaterThan(maxOrder)
'Dim dbConnection, dbQuery, dbResults, recordCounter
'' Create columns in the local action sheet in the datatable
'DataTable.GetSheet(2).AddParameter "OrderNo",""
'DataTable.GetSheet(2).AddParameter "Name",""
'DataTable.GetSheet(2).AddParameter "FlightNo",""
'DataTable.GetSheet(2).AddParameter "Tickets",""
'DataTable.GetSheet(2).AddParameter "Class",""
'
'' Create and open a connection to an ActiveX object database
'Set dbConnection = CreateObject("ADODB.Connection")
'dbConnection.Open("dsn=Flight") ' Created with the DSN Administrator
'
'' Create a result set and run a query to populate it with data
'dbQuery="SELECT OrderNumber, CustomerName, FlightNumber, TicketsOrdered, Class"_
'		 & " FROM Orders " _
'		 & " WHERE OrderNumber > " & maxOrder _
'		 & " ORDER BY OrderNumber DESC"
'Set dbResults = CreateObject("ADODB.Recordset")
'dbResults.Open dbQuery , dbConnection
'dbResults.MoveFirst
'recordCounter = 1
' 
'Do Until dbResults.EOF
'	DataTable.SetCurrentRow recordCounter
'	DataTable("OrderNo",2) = dbResults.Fields("OrderNumber")
'	DataTable("Name",2) = dbResults.Fields("CustomerName")
'	DataTable("FlightNo",2) =dbResults.Fields("FlightNumber")
'	DataTable("Tickets",2) = dbResults.Fields("TicketsOrdered")
'	DataTable("Class",2) = dbResults.Fields("Class")	
'	recordCounter = recordCounter + 1
'	dbResults.MoveNext
'Loop
'
'dbConnection.Close
'Set dbConnection = Nothing
'Set dbResults = Nothing
'End  Function

