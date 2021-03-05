Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal HTML As String)
        Try
            Dim VISTAHTML As AlternateView = AlternateView.CreateAlternateViewFromString(HTML, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)

            If (FrmCorreo.jpg.Count <> 0) Then

                For Each ft As String In FrmCorreo.jpg
                    Dim foto As LinkedResource = New LinkedResource(ft, System.Net.Mime.MediaTypeNames.Image.Jpeg)
                    foto.ContentId = "IMG" & FrmCorreo.o
                    VISTAHTML.LinkedResources.Add(foto)
                Next
                correos.AlternateViews.Add(VISTAHTML)
            End If

            If (FrmCorreo.zip.Count <> 0) Then

                For Each rutass As String In FrmCorreo.zip
                    Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(rutass)
                    'MsgBox(CType(rutass, String))
                    correos.Attachments.Add(archivo)
                Next

            End If


            ' FrmCorreo.Enabled = False
            If asunto = "" Then asunto = "Sin asunto de " & emisor
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            '  If ruta <> "" Then
            ' Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
            ' correos.Attachments.Add(archivo)
            ' End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas
            If FrmCorreo.ORIGEN = "gmail.com" Then
                envios.Host = "SMTP.GMAIL.COM"
            ElseIf FrmCorreo.ORIGEN = "hotmail.com" Or FrmCorreo.ORIGEN = "outlook.com" Then
                envios.Host = "SMTP.LIVE.COM"
            Else
                MsgBox("Host desconosido")
            End If

            'envios.Host = "SMTP.GMAIL.COM"
            envios.EnableSsl = True 'SISTEMA DE SEGURIDAD
            envios.Port = "587"



            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")
            '  FrmCorreo.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Module
