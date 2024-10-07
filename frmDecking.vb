Imports System.Text.RegularExpressions
Imports System.Transactions
Imports System.Xml.Schema

Public Class frmDecking
    Const _decLumberRate As Decimal = 21.5
    Const _decRedwoodRate As Decimal = 17
    Const _decCompositeRate As Decimal = 8.5

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        If (IsNumeric(txtNumberOfFootage.Text) And txtNumberOfFootage.Text.Length > 0) Then
            Dim dblFootage As Double = Convert.ToDouble(txtNumberOfFootage.Text)
            If (dblFootage > 0) Then
                Dim dblCost As Double
                If (radLumber.Checked) Then
                    dblCost = _decLumberRate * dblFootage
                ElseIf (radRedwood.Checked) Then
                    dblCost = _decRedwoodRate * dblFootage
                Else
                    dblCost = _decCompositeRate * dblFootage
                End If
                lblCost.Text = dblCost.ToString("C2")
            Else
                MsgBox("Enter a Positive Value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "illegal operation")
            End If
        Else
            MsgBox("Enter a numeric value", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "illegal Operation")
        End If
        txtNumberOfFootage.Clear()
        txtNumberOfFootage.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCost.Text = ""
        txtNumberOfFootage.Clear()
        txtNumberOfFootage.Focus()
    End Sub

    Private Sub frmDecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
        txtNumberOfFootage.Focus()
        radComposite.Checked = False
        radRedwood.Checked = False
        radLumber.Checked = True
    End Sub
End Class
