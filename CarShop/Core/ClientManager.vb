Imports System.IO
Imports System.Text.RegularExpressions

Public Class ClientManager
    Private _ClientFile As String = "client.txt"
    Public Sub SaveClient(ByRef client As Client)
        client.ClientNumber = GenerateClientNumber(client.Surname)
        Dim fileWriter As StreamWriter
        fileWriter = New StreamWriter(_ClientFile, True)
        fileWriter.WriteLine(client.ToString())
        fileWriter.Close()
    End Sub


    Public Function GetClientIDs() As List(Of String)
        Dim clientIds As List(Of String) = New List(Of String)
        If (File.Exists(_ClientFile)) Then
            Dim fileReader As StreamReader
            fileReader = New StreamReader(_ClientFile)
            Dim line As String = ""
            Do While fileReader.Peek() <> -1 ' Loop until the end of the file is reached
                line = fileReader.ReadLine()
                Dim clientId = line.Split(",")(0)
                clientIds.Add(clientId)
            Loop
            fileReader.Close()
        End If
        Return clientIds
    End Function

    Private Function GenerateClientNumber(surname As String) As String
        Dim clientNumber As String = surname.Substring(0, 3).ToUpper()
        Dim num As Int32 = ReadMaxNumberFromFile()
        num += 1
        clientNumber += num.ToString().PadLeft(5, "0")
        Return clientNumber
    End Function

    Private Function ReadMaxNumberFromFile() As Integer
        Dim num As Int32 = 0
        'get max id
        If (File.Exists(_ClientFile)) Then
            Dim fileReader As StreamReader
            fileReader = New StreamReader(_ClientFile)
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
        Dim validator = New NumberValidator
        Return validator.CheckForNumeric(contactNumber)
    End Function

    Public Function ValidateEmail(email As String) As Boolean
        Dim validateEmailRegex = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim valid As Boolean = validateEmailRegex.IsMatch(email)
        Return valid
    End Function
End Class
