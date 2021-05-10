Imports System.Data.SqlClient

Public Class Form1
    Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click

        Dim conexion As String
        conexion = "Data Source=JARCORGAMING;Initial Catalog=Practica2;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("insert into distribuitors values(" & codigo.Text & ",'" & fecha.Text & "','" & nombre.Text & "','" & aPaterno.Text & "','" & aMaterno.Text & "','" & colonia.Text & "','" & calle.Text & "','" & nCasa.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MsgBox("Se resgistraron los datos correctamente")

        codigo.Text = ""
        fecha.Text = ""
        nombre.Text = ""
        aPaterno.Text = ""
        aMaterno.Text = ""
        colonia.Text = ""
        calle.Text = ""
        nCasa.Text = ""


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub codigo_TextChanged(sender As Object, e As EventArgs) Handles codigo.TextChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Dim conexion As String
        conexion = "Data Source=JARCORGAMING;Initial Catalog=Practica2;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select*from distribuitors where id= " & TextBox9.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            TextBox7.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            TextBox6.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            TextBox5.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            TextBox4.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            TextBox3.Text = ds.Tables("datos").Rows(0).Item(5).ToString
            TextBox2.Text = ds.Tables("datos").Rows(0).Item(6).ToString
            TextBox1.Text = ds.Tables("datos").Rows(0).Item(7).ToString
        Else
            MsgBox("Usuario no existe")
        End If

    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub
End Class
