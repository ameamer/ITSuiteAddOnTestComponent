''' <summary>
''' Contiene elementi relativi all'identità dell'utente collegato ad ITSuite (DEBUG SVILUPPO COMPONENTI DI ITSUITE).
''' </summary>
Partial Public Class IdentityHelperEx

    ''' <summary>
    ''' Restituisce il ruolo di autenticazione dell'utente: Usertypes.Usertype.
    ''' </summary>
    Public Shared ReadOnly Property UserAuthRole As Usertypes.Usertype
        Get
            Return Usertypes.Usertype.Admin
        End Get
    End Property

    ''' <summary>
    ''' Restituisce il nome utente attualmente collegato.
    ''' </summary>
    Public Shared ReadOnly Property UserAuth As String
        Get
            Return "test"
        End Get
    End Property

    ''' <summary>
    ''' Restituisce l'ID dell'utente attualmente collegato.
    ''' </summary>
    Public Shared ReadOnly Property UserId As String
        Get
            Return "1"
        End Get
    End Property
End Class
