''' <summary>
''' Contiene elementi relativi ai tipi di utente di ITSuite.
''' </summary>
Public Class Usertypes

    ''' <summary>
    ''' Contiene i tipi di utenti di ITSuite.
    ''' </summary>
    Public Enum Usertype
        ''' <summary>
        ''' Utente amministratore di ITSuite.
        ''' </summary>
        Admin = 0
        ''' <summary>
        ''' Utente tecnico ticketing di ITSuite.
        ''' </summary>
        TechUser = 1
        ''' <summary>
        ''' Utente cliente di ITSuite.
        ''' </summary>
        Customer = 2
    End Enum

End Class
