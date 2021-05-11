Imports System.Configuration.Assemblies
Imports System.Runtime.InteropServices
Imports System.Resources

Partial Class Components_itsuiteaddontest
    Inherits System.Web.UI.Page

    ''' <summary>
    ''' Inizializza il file di risorse .resx relativo alla lingua.
    ''' </summary>
    Public Shared ResXHelper As ResXResourceSet

    ''' <summary>
    ''' Caricamento della pagina completato.
    ''' </summary>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Ricavo codice lingua dell'utente, se impostato. Se non impostato, il risultato della funzione sarà "DEFAULT".
        Dim UserLang As String = ITSuite_ExternalAPI.GlobalizationHelperEx.GetUserLang()
        Select Case UserLang
            Case "IT" ' L'utente ha impostato la lingua IT
                Dim rsxfile As String = Server.MapPath("itsuiteaddontestIT.resx")
                ResXHelper = New ResXResourceSet(rsxfile)

            Case "DEFAULT" ' L'utente non ha impostato nessuna lingua. Si utilizzerà la lingua di sistema.
                ' Ricavo la lingua del sistema in uso.
                Select Case System.Globalization.RegionInfo.CurrentRegion.Name
                    Case "IT" ' Se lingua di sistema IT
                        Dim rsxfile As String = Server.MapPath("itsuiteaddontestIT.resx")
                        ResXHelper = New ResXResourceSet(rsxfile)

                    Case Else ' Se altra lingua di sistema
                        Dim rsxfile As String = Server.MapPath("itsuiteaddontestEN.resx")
                        ResXHelper = New ResXResourceSet(rsxfile)
                End Select

            Case Else ' L'utente ha impostato un'altra lingua non presente. Si utilizzerà la lingua di default.
                Dim rsxfile As String = Server.MapPath("itsuiteaddontestEN.resx")
                ResXHelper = New ResXResourceSet(rsxfile)
        End Select

        ' Imposto le stringhe in base alla lingua rilevata
        Page.Title = ResXHelper.GetString("String4") & " | ITSuite by Ame Amer (admin@ameamer.com)"
        TitleLable.Text = ResXHelper.GetString("String4")
        SubtitleLabel.Text = ResXHelper.GetString("String5")
        BodyLabel.Text = ResXHelper.GetString("String6")

        ' Rilevo il tipo dell'utente collegato e imposto i valori necessari in base ad esso ("admin", "personale", "cliente").
        Select Case ITSuite_ExternalAPI.IdentityHelperEx.UserAuthRole
            Case ITSuite_ExternalAPI.Usertypes.Usertype.Admin ' Amministratori
                LabelInfo.Text = ResXHelper.GetString("String1")
                ' Popolo dati ricavati da un PC specifico
                Dim pcdata As Boolean = PrintPcData("1")
                If Not pcdata Then ' se il PC non è presente nel database
                    LabelBrand.Text = ResXHelper.GetString("String14") & " - " & ITSuite_ExternalAPI.IdentityHelperEx.UserAuthRole
                    LabelModel.Text = ResXHelper.GetString("String14")
                    LabelSN.Text = ResXHelper.GetString("String14")
                End If
                ' Popolo lista di tutti i PC
                Dim pclistresult As Boolean = PrintPcList()
                If Not pclistresult Then
                    PcListLabel.Text = PcListLabel.Text & "<tr><td style='padding:5px;' colspan='3'>" & ResXHelper.GetString("String13") & "</td></tr>"
                End If
                PanelPcData.Visible = True

            Case ITSuite_ExternalAPI.Usertypes.Usertype.TechUser ' Tecnici ticketing
                Dim isfortechusers As Boolean = ITSuite_ExternalAPI.ComponentHelperEx.isComponentForTechUser("ITSuiteAddOnTestComponent")
                If Not isfortechusers Then
                    Response.Redirect("../logout.aspx")
                Else
                    LabelInfo.Text = ResXHelper.GetString("String2")
                    ' Popolo dati ricavati da un PC specifico
                    Dim pcdata As Boolean = PrintPcData("1")
                    If Not pcdata Then ' se il PC non è presente nel database
                        LabelBrand.Text = ResXHelper.GetString("String14")
                        LabelModel.Text = ResXHelper.GetString("String14")
                        LabelSN.Text = ResXHelper.GetString("String14")
                    End If
                    ' Popolo lista di tutti i PC
                    Dim pclistresult As Boolean = PrintPcList()
                    If Not pclistresult Then
                        PcListLabel.Text = PcListLabel.Text & "<tr><td style='padding:5px;' colspan='3'>" & ResXHelper.GetString("String13") & "</td></tr>"
                    End If
                    PanelPcData.Visible = True
                End If

            Case ITSuite_ExternalAPI.Usertypes.Usertype.Customer ' Clienti
                Dim isfortechusers As Boolean = ITSuite_ExternalAPI.ComponentHelperEx.isComponentForCustomerUser("ITSuiteAddOnTestComponent")
                If Not isfortechusers Then
                    Response.Redirect("../logout.aspx")
                Else
                    LabelInfo.Text = ResXHelper.GetString("String3")
                    ' Popolo dati ricavati da un PC specifico
                    Dim pcdata As Boolean = PrintPcData("1")
                    If Not pcdata Then ' se il PC non è presente nel database
                        LabelBrand.Text = ResXHelper.GetString("String14")
                        LabelModel.Text = ResXHelper.GetString("String14")
                        LabelSN.Text = ResXHelper.GetString("String14")
                    End If
                    ' Popolo lista di tutti i PC
                    Dim pclistresult As Boolean = PrintPcList()
                    If Not pclistresult Then
                        PcListLabel.Text = PcListLabel.Text & "<tr><td style='padding:5px;' colspan='3'>" & ResXHelper.GetString("String13") & "</td></tr>"
                    End If
                    PanelPcData.Visible = True
                End If

            Case Else ' Tipo utente non rilevato. Effettuo il logout.
                Response.Redirect("../logout.aspx")
        End Select
    End Sub

    ''' <summary>
    ''' Visualizza la lista dei PC. Restituisce TRUE se sono presenti PC, altrimenti FALSE.
    ''' </summary>
    ''' <returns></returns>
    Public Function PrintPcList() As Boolean
        Dim pclist As New List(Of ITSuite_ExternalAPI.ProductsHelperEx.PC.PCDataReuslt)
        pclist = ITSuite_ExternalAPI.ProductsHelperEx.PC.GetPcList()
        Dim res As Boolean = False
        If pclist.Count() = 0 Then
            res = False
        Else
            For Each r As ITSuite_ExternalAPI.ProductsHelperEx.PC.PCDataReuslt In pclist
                PcListLabel.Text = PcListLabel.Text & "<tr><td style='padding:5px;'>" & r.PCBrand & "</td>" &
                        "<td style='padding:5px;'>" & r.PCModel & "</td>" &
                        "<td style='padding:5px;'>" & r.SN & "</td></tr>"
            Next
            res = True
        End If
        Return res
    End Function

    ''' <summary>
    ''' Visualizza i dettagli di un PC. Restituisce TRUE se il PC è presente, altrimenti FALSE.
    ''' </summary>
    ''' <param name="id">String - l'ID del PC da cui ricavare i dati</param>
    ''' <returns></returns>
    Public Function PrintPcData(id As String) As Boolean
        Dim res As Boolean = False
        Dim chk As ITSuite_ExternalAPI.ProductsHelperEx.PC.PCDataReuslt = ITSuite_ExternalAPI.ProductsHelperEx.PC.GetPcData(id)
        If chk IsNot Nothing Then
            LabelBrand.Text = chk.PCBrand
            LabelModel.Text = chk.PCModel
            LabelSN.Text = chk.SN
            res = True
        Else
            res = False
        End If
        Return res
    End Function

End Class
