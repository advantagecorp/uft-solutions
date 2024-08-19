strFlyFrom = WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").GetROProperty("all items")
countFlyFrom = WpfWindow("OpenText MyFlight Sample").WpfComboBox("fromCity").GetItemsCount()
arrFlyFrom = split(strFlyFrom, Chr(10))

strFlyTo = WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").GetROProperty("all items")
countFlyTo = WpfWindow("OpenText MyFlight Sample").WpfComboBox("toCity").GetItemsCount()
arrFlyTo = split(strFlyTo, Chr(10))

' Departure city check
For i = 0 to countFlyFrom - 1
	Datatable.SetCurrentRow i+1
	Datatable.Value("ActDepCity") = arrFlyFrom(i)
	result = Datatable.Value("CityCheck")
	If result = "TRUE" Then
       	Reporter.ReportEvent micPass,"Departure City", "Both are equal"	
	Else
	  	Reporter.ReportEvent micFail,"Departure City", "Not equal! Expected: " & Datatable.Value("ExpDepCity") & "   Actual: " & arrFlyFrom(i)	
	End If
Next

' Arrival city check
For i = 0 to countFlyTo - 1
	Datatable.SetCurrentRow i+1
	Datatable.Value("ActArrCity") = arrFlyTo(i)
	result = Datatable.Value("CityCheck2")
	If result = "TRUE" Then
       	Reporter.ReportEvent micPass,"Arrival City", "Both are equal"	
	Else
		Reporter.ReportEvent micFail,"Arrival City", "Not equal! Expected: " & Datatable.Value("ExpArrCity") & "   Actual: " & arrFlyTo(i)	
	End If
	
Next


