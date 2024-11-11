Imports System.Reflection.Emit

Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32

    ' Number input buttons
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button3.Click, Button2.Click, Button19.Click, Button15.Click, Button14.Click, Button13.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub

    ' Clear button (C)
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Label1.Text = "0"
        Label3.Text = ""
    End Sub

    ' Arithmetic operation buttons (+, -, *, /, Mod, Exp)
    Private Sub arithmatic_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button5.Click, Button23.Click, Button20.Click, Button16.Click, Button12.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label3.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op
    End Sub

    ' Equals button (=)
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Try
            s = Val(Label1.Text)

            Select Case op
                Case "+"
                    a = f + s
                Case "-"
                    a = f - s
                Case "*"
                    a = f * s
                Case "/"
                    If s = 0 Then
                        Throw New DivideByZeroException("Cannot divide by zero.")
                    End If
                    a = f / s
                Case "Mod"
                    a = f Mod s
                Case "Exp"
                    a = f ^ s
            End Select

            Label1.Text = a.ToString()
            Label3.Text = ""
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Binary conversion (Dec -> Bin)
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    ' Scientific functions (Sin, Cos, Tan, Log)
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    ' Load event to set the scientific calculator layout
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Scientific Calculator"
        Me.Height = 423
        Me.Width = 393
        Button26.Width = 75
        Button26.Height = 23
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
