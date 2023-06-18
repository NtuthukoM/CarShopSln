Imports System.IO
Imports System.Text.RegularExpressions

Public Class ClientManager
    Public Sub SaveClient(ByRef client As Client)
        client.ClientNumber = GenerateClientNumber(client.Surname)
        Dim fileWriter As StreamWriter
        fileWriter = New StreamWriter("client.txt", True)
        fileWriter.WriteLine(client.ToString())
        fileWriter.Close()
    End Sub


    Private Function GenerateClientNumber(surname As String) As String
        Dim clientNumber As String = surname.Substring(0, 3).ToUpper()
        Dim num As Int32 = ReadMaxNumberFromFile()
        num += 1
        clientNumber += num.ToString().PadLeft(5, "0")
        Return clientNumber
    End Function

    Private Shared Function ReadMaxNumberFromFile() As Integer
        Dim num As Int32 = 0
        'get max id
        If (File.Exists("client.txt")) Then
            Dim fileReader As StreamReader
            fileReader = New StreamReader("client.txt")
            Dim line As String = ""
            Do While fileReader.Peek() <> -1 ' Loop until the end of the file is reached
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()

            If (Not String.IsNullOrEmpty(line)) Then
                Dim maxClientNumber = line.Split(",")(0)
                maxClientNumber = maxClientNumber.Substring(3)
                num = CType(maxClientNumber, Int32)
            End If
        End If

        Return num
    End Function

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

    Public Function ValidateEmail(email As String) As Boolean
        Dim validateEmailRegex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim valid As Boolean = validateEmailRegex.IsMatch(email)
        Return valid
    End Function
End Class
