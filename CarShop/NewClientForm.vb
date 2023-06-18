Public Class NewClientForm

    Private _ClientManager As ClientManager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ValidateInput()) Then
            'save client
            Dim client = New Client
            client.Name = txtName.Text
            client.Surname = txtSurname.Text
            client.Email = txtEmail.Text
            client.DateOfBirth = txtDateOfBirth.Text
            client.ContactNumber = txtContactNumber.Text
            client.PassportNumber = txtPassportNumber.Text
            client.SaIdNumber = txtIdNumber.Text
            _ClientManager.SaveClient(client)
            lblClientNumber.Text = client.ClientNumber
            'open finance calculator:
            MessageBox.Show("New client added")
            Dim calc = New FinanceCalculatorForm(client.ClientNumber) With {
                .MdiParent = Me.MdiParent
            }
            calc.Show()
        End If
    End Sub


    Private Function ValidateInput() As Boolean
        Dim isValid = True

        If txtSurname.Text.Length < 3 Then
            lblSurname.ForeColor = System.Drawing.Color.Red
            Return False
        End If
        If Not String.IsNullOrEmpty(txtIdNumber.Text) And (txtIdNumber.Text.Length < 13 Or _ClientManager.CheckForNumeric(txtIdNumber.Text) = False) Then
            lblIdNumber.ForeColor = System.Drawing.Color.Red
            Return False
        End If

        If txtContactNumber.Text.Length < 10 Or _ClientManager.CheckForNumeric(txtContactNumber.Text) = False Then
            lblContactNumber.ForeColor = Color.Red
            Return False
        End If

        If txtSurname.Text.Length < 3 Then
            lblSurname.ForeColor = System.Drawing.Color.Red
            Return False
        End If
        If _ClientManager.ValidateEmail(txtEmail.Text) = False Then
            lblContactNumber.ForeColor = Color.Red
            Return False
        End If

        Return isValid
    End Function

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        If txtSurname.Text.Length < 3 Then
            lblSurname.ForeColor = System.Drawing.Color.Red
        Else
            lblSurname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtIdNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdNumber.TextChanged
        If Not String.IsNullOrEmpty(txtIdNumber.Text) And (txtIdNumber.Text.Length < 13 Or _ClientManager.CheckForNumeric(txtIdNumber.Text) = False) Then
            lblIdNumber.ForeColor = System.Drawing.Color.Red
        Else
            lblIdNumber.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtIdNumber_Leave(sender As Object, e As EventArgs) Handles txtIdNumber.Leave
        If Not String.IsNullOrEmpty(txtIdNumber.Text) And txtIdNumber.Text.Length = 13 And _ClientManager.CheckForNumeric(txtIdNumber.Text) = True Then
            Dim year = CType(txtIdNumber.Text.Substring(0, 2), Int32)
            If year > 20 Then
                year += 1900
            Else
                year += 2000
            End If
            Dim month = CType(txtIdNumber.Text.Substring(2, 2), Int32)
            Dim day = CType(txtIdNumber.Text.Substring(4, 2), Int32)

            'Set date of birth:
            Dim dob As Date = New Date(year, month, day)
            txtDateOfBirth.Text = dob.ToShortDateString
        End If
    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged
        If txtContactNumber.Text.Length < 10 Or _ClientManager.CheckForNumeric(txtContactNumber.Text) = False Then
            lblContactNumber.ForeColor = Color.Red
        Else
            lblContactNumber.ForeColor = Color.Black
        End If

    End Sub

    Private Sub NewClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _ClientManager = New ClientManager()
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If _ClientManager.ValidateEmail(txtEmail.Text) = False Then
            lblEmail.ForeColor = Color.Red
        Else
            lblEmail.ForeColor = Color.Black
        End If
    End Sub
End Class