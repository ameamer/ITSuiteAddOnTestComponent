''' <summary>
''' Contiene elementi relativi alla globalizzazione del componente aggiuntivo (DEBUG SVILUPPO COMPONENTI DI ITSUITE).
''' </summary>
Public Class GlobalizationHelperEx

    ''' <summary>
    ''' La sigla del linguaggio utilizzato dell'utente attualmente collegato ad ITSuite (es. "IT", "EN", ecc...).
    ''' "DEFAULT" se non è stata impostata nessuna lingua o è stata impostata la lingua di sistema.
    ''' </summary>
    Public Shared Function GetUserLang() As String
        Return "DEFAULT"
    End Function
End Class
