''' <summary>
''' Contiene elementi relativi alle informazioni del componente aggiuntivo (DEBUG SVILUPPO COMPONENTI DI ITSUITE).
''' </summary>
Public Class ComponentHelperEx

    ''' <summary>
    ''' Impostare TRUE se il componente è abilitato per gli utenti "Tecnici ticketing", altrimenti FALSE
    ''' </summary>
    ''' <param name="TechnicalName">String - il nome tecnico del componente aggiuntivo</param>
    Public Shared Function isComponentForTechUser(TechnicalName As String) As Boolean
        Dim res As Boolean = True
        Return res
    End Function

    ''' <summary>
    ''' Impostare TRUE se il componente è abilitato per gli utenti "Clienti", altrimenti FALSE
    ''' </summary>
    ''' <param name="TechnicalName">String - il nome tecnico del componente aggiuntivo</param>
    Public Shared Function isComponentForCustomerUser(TechnicalName As String) As Boolean
        Dim res As Boolean = True
        Return res
    End Function

End Class
