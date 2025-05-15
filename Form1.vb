Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Customer_Name As String = TextBox1.Text
        Dim Phone_No As Integer = TextBox5.Text
        Dim Residence As String = TextBox2.Text
        Dim Previous As Double = TextBox4.Text
        Dim Current As Double = TextBox3.Text

        Dim reading As Double = Current - Previous
        Dim Bill As Double

        Select Case reading
            Case 0 To 4
                Bill = reading * 10 + 500
            Case 5 To 6
                Bill = reading * 20 + 500
            Case 1 To 9
                Bill = reading * 15 + 500
            Case Is > 10
                Bill = reading * 10 + 500
        End Select

        Label11.Text = "========Water Billing system=========" & vbCrLf &
            "Customer Name :  " & Customer_Name & vbCrLf &
            "Phone Number :  " & Phone_No & vbCrLf &
            "Residence : " & Residence & vbCrLf &
            "Previous Water Reading : " & Previous & vbCrLf &
            "Current Water Reading : " & Current & vbCrLf &
            "Water per Unit Consumed : " & reading & vbCrLf &
            "Final Water Bill: " & Bill & vbCrLf &
            "=================================="
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
