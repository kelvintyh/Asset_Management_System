﻿Public Class Frm_RoleChoose
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frm_LoginAdmin.ShowDialog()
    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Frm_LoginStaff.ShowDialog()
    End Sub

    Private Sub Frm_RoleChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initiateData()
    End Sub
End Class