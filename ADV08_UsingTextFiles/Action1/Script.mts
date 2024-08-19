Dim objFSO, objFile, strText
Set objFSO=CreateObject("Scripting.FileSystemObject")
Set objFile=objFSO.CreateTextFile("C:\Users\demo\Documents\UFT One\TestFile.txt",true)

objFile.WriteLine "Nothing in the world can take the place of persistence."
objFile.WriteLine "Talent will not; nothing is more common than unsuccessful men with talent."
objFile.WriteLine "Genius will not; unrewarded genius is almost a proverb."
objFile.WriteLine "Education will not; the world is full of educated derelicts."
objFile.WriteLine "Persistence and determination alone are omnipotent."
objFile.WriteLine "- Calvin Coolidge"
objFile.WriteBlankLines(1)	

objFile.Close()

Dim objFSO2, objFile2
Set objFSO2=CreateObject("Scripting.FileSystemObject")
Set objFile2=objFSO2.OpenTextFile("C:\Users\demo\Documents\UFT One\TestFile.txt",1)

Do Until objFile2.AtEndOfStream
	strText=objFile2.ReadLine
	Reporter.ReportEvent micDone,"text","The line says: " & strText
	Print strText
Loop

objFile2.Close()
