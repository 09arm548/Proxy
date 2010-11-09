Public Class frmMain
    ''' <summary>
    ''' Turns proxy on in registry
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnable.Click

        'sets registry value to on
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "Proxyenable", 1)


    End Sub

    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click

        'sets registry value to off
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "Proxyenable", 0)

    End Sub
End Class
