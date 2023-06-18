Public Class NumberValidator
    Public Function CheckForNumeric(contactNumber As String) As Boolean
        Dim i As Integer
        Dim thisChar As Char
        Dim asciiValue As Integer
        Dim isValid As Boolean
        isValid = True
        For i = 0 To Len(contactNumber) - 1
            thisChar = contactNumber.Chars(i)
            asciiValue = Convert.ToByte(thisChar)
            If asciiValue < 48 Then isValid = False
            If asciiValue > 57 Then isValid = False
        Next i
        If isValid Then
            Return True
        Else
            Return False
        End If
        Throw New NotImplementedException()
    End Function
End Class
