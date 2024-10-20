Public Class Form1
    Private RatePerHour As Object

    ' Define rates as constants
    Private Const PAYE_RATE As Double = 0.16
    Private Const NSSF_RATE As Double = 0.03
    Private Const NHIF_RATE As Double = 0.07
    Private Const ALLOWANCE_RATE As Double = 0.25


    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Declare variables
        Dim workedHours As Double
        Dim ratePerHour As Double
        Dim workedDays As Integer
        Dim grossPay As Double
        Dim paye As Double
        Dim nssf As Double
        Dim nhif As Double
        Dim totalDeductions As Double
        Dim allowance As Double
        Dim grossSalary As Double
        Dim Deduction As Double
        Dim netSalary As Double

        ' Get input values from the user

        If Not Double.TryParse(TextBox1.Text, workedHours) Then
            MessageBox.Show("invalid Enter valid hours worked")
            Exit Sub
        End If

        If Not Double.TryParse(TextBox2.Text, ratePerHour) Then
            MessageBox.Show("incorrect hours input new hour rate")
            Exit Sub
        End If

        If Not Integer.TryParse(TextBox3.Text, workedDays) Then
            MessageBox.Show("incorrect days")
            Exit Sub
        End If



        ' Calculate Gross Pay
        grossPay = workedHours * ratePerHour * workedDays
        TextBox4.Text = grossPay.ToString("C")

        'calculate diduction based on the rate
        paye = grossPay * PAYE_RATE
        nssf = grossPay * NSSF_RATE
        nhif = grossPay * NHIF_RATE

        'display deduction to their respective boxes
        TextBox5.Text = paye.ToString("C")
        TextBox6.Text = nssf.ToString("C")
        TextBox7.Text = nhif.ToString("C")


        ' Calculate Total Deductions
        totalDeductions = paye + nssf + nhif
        TextBox8.Text = totalDeductions.ToString("C")

        'to calculate allowance4
        allowance = grossPay * ALLOWANCE_RATE
        TextBox9.Text = allowance.ToString("C")

        'Calculate Gross Salary
        grossSalary = grossPay + allowance
        TextBox10.Text = grossSalary.ToString("C")

        'Decuctions
        Deduction = totalDeductions
        TextBox11.Text = Deduction.ToString("C")

        ' Calculate Net Salary
        netSalary = grossPay - totalDeductions + allowance
        TextBox12.Text = netSalary.ToString("C")
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class
