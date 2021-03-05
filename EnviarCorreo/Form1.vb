Imports System.Collections.ArrayList

Public Class FrmCorreo
    Public ORIGEN As String
    Public zip As New ArrayList
    Public jpg As New ArrayList
    Public o, o1, O2 As Integer

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim VHTML As String
        Dim ep As String

        Try
            VHTML = txtHTML.Text

            If (txtRutaArchivo.Text IsNot Nothing) Then
                ep = System.IO.Path.GetExtension(txtRutaArchivo.Text)
                If (ep = ".jpg") Then
                    o += 1
                    rbArchivos.Text = rbArchivos.Text & vbCrLf & "Archivo .jpg: <" & txtRutaArchivo.Text & "> ---------> IMG" & o & vbCrLf & vbCrLf

                    jpg.Add(txtRutaArchivo.Text)
                End If

                If (ep = ".zip") Then
                    o1 += 1
                    rbArchivos.Text = rbArchivos.Text & vbCrLf & "Archivo .zip: <" & txtRutaArchivo.Text & "> ---------> ZIP" & o1 & vbCrLf & vbCrLf

                    zip.Add(txtRutaArchivo.Text)
                End If

                If (ep = ".pdf") Then
                    o1 += 1
                    rbArchivos.Text = rbArchivos.Text & vbCrLf & "Archivo .pdf: <" & txtRutaArchivo.Text & "> ---------> PDF" & o1 & vbCrLf & vbCrLf
                    zip.Add(txtRutaArchivo.Text)
                End If
            End If

            ORIGEN = txtEmisor.Text.ToLower
            ORIGEN = ORIGEN.Remove(0, ORIGEN.IndexOf("@") + 1)
            ' MsgBox(ORIGEN)

            enviarCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text, VHTML)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Try
            'Creamos el cuadro de archivos
            Dim dialog As New OpenFileDialog()
            Dim ext As String
            Dim ruta As String

            dialog.InitialDirectory = "C://Users/"
            dialog.Multiselect = False
            dialog.RestoreDirectory = True
            dialog.Filter = "Archivos .jpg|*.jpg|Archivos .zip|*.zip|Archivos .pdf|*.pdf"
            dialog.ReadOnlyChecked = True
            dialog.Title = "Archivos"

            If (dialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
                ruta = dialog.FileName
                ext = System.IO.Path.GetExtension(CType(ruta, String))
                'MsgBox(ext)

                If (ext = ".jpg") Then
                    o += 1
                    rbArchivos.Text = rbArchivos.Text & "Archivo .jpg: <" & ruta & "> ---------> IMG" & o & vbCrLf & vbCrLf
                    jpg.Add(ruta)
                End If

                If (ext = ".zip") Then
                    o1 += 1
                    rbArchivos.Text = rbArchivos.Text & "Archivo .zip: <" & ruta & "> ---------> ZIP" & o1 & vbCrLf & vbCrLf
                    zip.Add(ruta)
                End If
                If (ext = ".pdf") Then
                    o2 += 1
                    rbArchivos.Text = rbArchivos.Text & "Archivo .pdf: <" & ruta & "> ---------> PDF" & o1 & vbCrLf & vbCrLf
                    zip.Add(ruta)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmCorreo_Click(sender As Object, e As EventArgs) Handles Me.Click
        MsgBox("Programa hecho por Luis Angel Glez Gtz", MsgBoxStyle.Information, Title:="Derechos de autor")
    End Sub

 
    Private Sub FrmCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHTML.Text = "<html><body>" & vbCrLf & vbCrLf & "aqui tu codigo HTML" & vbCrLf & vbCrLf & "</body></html>"

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class

