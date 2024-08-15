AIUtil.SetContext Browser("creationtime:=0")
AIUtil("profile").Click
AIUtil("input", "Username").Type "demo_user"
AIUtil("input", "Password").Type "Password1"
AIUtil("button", "SIGN IN").Click
AIUtil.FindTextBlock("SPEAKERS").Click
AIUtil.FindTextBlock("Bose SoundLink Wireless").Click
AIUtil("plus").Click
AIUtil.FindTextBlock("ADD TO CART").Click
AIUtil.FindTextBlock("dvantageDEMo").Click
AIUtil("shopping_cart").Click
AIUtil("button", "CHECKOUT ($258.00)", "FromTop", 1).Click
AIUtil("button", "NEXT").Click
AIUtil("input", "SafePay username").Type "demo_user"
AIUtil("input", "SafePay password").Type "Password1"
AIUtil("check_box", "Save changes in profile for future use").Click
AIUtil("button", "PAY NOW").Click
AIUtil.FindTextBlock("$258.00").CheckExists True
AIUtil.FindTextBlock("$180.00").CheckExists True
Set regex = AIRegex("^\$4\d+.\d\d") ' Find dollar amount with cents that begins with $ and 4
AIUtil.FindTextBlock(regex, "FromTop", 1).CheckExists True
tp = AIUtil.FindTextBlock(regex, micFromTop, 1).GetText
If (tp = "$438.00") Then
	Reporter.ReportEvent micPass, "TotalPrice", "Total price = " + AIUtil.FindTextBlock(regex, micFromTop, 1).GetText
Else
	Reporter.ReportEvent micFail, "TotalPrice", "Total price was not accurate."
End If
AIUtil.FindTextBlock("dvantageDEMo").Click
AIUtil("profile").Click
AIUtil.FindTextBlock("Sign out").Click

