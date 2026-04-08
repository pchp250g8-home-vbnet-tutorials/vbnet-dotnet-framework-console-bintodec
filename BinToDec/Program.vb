Imports System
Imports System.Text.RegularExpressions
Module Program
	Sub Main(args As String())
		Const MAX_INT = UInteger.MaxValue
		Dim nDecNum = 0
		Dim nBinPower = 1
		Dim nMaxBinaryLen = Math.Truncate(Math.Log2(MAX_INT))
		Dim oRegEx = New Regex("^[0-1]+$")
		Console.WriteLine("Input a binary number")
		Dim strLine = Console.ReadLine()
		Dim nStrLen = strLine.Length
		Dim bIsMatch = oRegEx.IsMatch(strLine)
		Dim bRightString = (nStrLen <= nMaxBinaryLen) AndAlso bIsMatch
		If Not bRightString Then
			Console.WriteLine("Wrong binary number format!!!")
			Console.Read()
			Return
		End If
		For i As Integer = 0 To nStrLen - 1
			Dim nBinDight As Integer = AscW(strLine.Chars(nStrLen - 1 - i)) - AscW("0"c)
			nDecNum += (nBinDight * nBinPower)
			nBinPower *= 2
		Next i
		Console.WriteLine("The decimal equivalent of the binary number {0} is {1}", strLine, nDecNum)
		Console.Read()
	End Sub
End Module
