''' <summary>
''' Contiene elementi relativi alla gestione dei prodotti presenti nel database di ITSuite.
''' </summary>
Public Class ProductsHelperEx
    ''' <summary>
    ''' Contiene elementi relativi ai PC presenti nel database di ITSuite
    ''' </summary>
    Partial Public Class PC
        ''' <summary>
        ''' La classe contenente i dati del PC richiesto.
        ''' </summary>
        Partial Public Class PCDataReuslt
            Public PCDomain As String
            Public PCName As String
            Public PCBrand As String
            Public PCModel As String
            Public SN As String
            Public Inventory As String
            Public Department As String
            Public Room As String
            Public Author As String
            Public Pavilion As String
            Public Floor As String
            Public Building As String
            Public OS As String
            Public Ram As String
            Public Cpu As String
            Public IP As String
            Public PrivateSoftware As String
            Public AddDate As String
            Public AddTime As String
            Public Notes As String
            Public Status As String
            Public Year As String
            Public PCType As String
            Public PCMonitorBrand As String
            Public PCMonitorModel As String
            Public PCMonitorInch As String
            Public PCMonitorInv As String
            Public PCMonitorSN As String
            Public PCMonitorNotes As String
            Public PCMonitorStatus As String
            Public PCMonitorYear As String
            Public IDConnPrinter As String
            Public IDConnHW As String
            Public PCDriverFolder As String
        End Class

        ''' <summary>
        ''' Restituisce i dati del PC richiesto salvato nel database di ITSuite.
        ''' </summary>
        ''' <param name="id">String - l'id del PC richiesto (in debug deve essere 1)</param>
        ''' <returns></returns>
        Public Shared Function GetPcData(id As String) As PCDataReuslt
            Dim PcRes As New PCDataReuslt()
            If id = "1" Then
                PcRes.PCDomain = "PCDomain Test"
                PcRes.PCName = "PCName Test"
                PcRes.PCBrand = "PCBrand Test"
                PcRes.PCModel = "PCModel Test"
                PcRes.SN = "SN Test"
                PcRes.Inventory = "Inventory Test"
                PcRes.Department = "Department Test"
                PcRes.Room = "Room Test"
                PcRes.Author = "Author Test"
                PcRes.Pavilion = "Pavilion Test"
                PcRes.Floor = "Floor Test"
                PcRes.Building = "Building Test"
                PcRes.OS = "OS Test"
                PcRes.Ram = "Ram Test"
                PcRes.Cpu = "Cpu Test"
                PcRes.IP = "IP Test"
                PcRes.PrivateSoftware = "PrivateSoftware Test"
                PcRes.AddDate = "AddDate Test"
                PcRes.AddTime = "AddTime Test"
                PcRes.Notes = "Notes Test"
                PcRes.Status = "Status Test"
                PcRes.Year = "Year Test"
                PcRes.PCType = "PCType Test"
                PcRes.PCMonitorBrand = "PCMonitorBrand Test"
                PcRes.PCMonitorModel = "PCMonitorModel Test"
                PcRes.PCMonitorInch = "PCMonitorInch Test"
                PcRes.PCMonitorInv = "PCMonitorInv Test"
                PcRes.PCMonitorSN = "PCMonitorSN Test"
                PcRes.PCMonitorNotes = "PCMonitorNotes Test"
                PcRes.PCMonitorStatus = "PCMonitorStatus Test"
                PcRes.PCMonitorYear = "PCMonitorYear Test"
                PcRes.IDConnPrinter = "IDConnPrinter Test"
                PcRes.IDConnHW = "IDConnHW Test"
                PcRes.PCDriverFolder = "PCDriverFolder Test"
            Else
                PcRes = Nothing
            End If

            Return PcRes
        End Function

        ''' <summary>
        ''' Restituisce la lista dei PC presente nel database di ITSuite.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetPcList() As List(Of PCDataReuslt)
            Dim PcResList As New List(Of PCDataReuslt)
            For i = 0 To 2
                Dim PcRes As New PCDataReuslt
                PcRes.PCDomain = "PCDomain Test " & i + 1
                PcRes.PCName = "PCName Test " & i + 1
                PcRes.PCBrand = "PCBrand Test " & i + 1
                PcRes.PCModel = "PCModel Test " & i + 1
                PcRes.SN = "SN Test " & i + 1
                PcRes.Inventory = "Inventory Test " & i + 1
                PcRes.Department = "Department Test " & i + 1
                PcRes.Room = "Room Test " & i + 1
                PcRes.Author = "Author Test " & i + 1
                PcRes.Pavilion = "Pavilion Test " & i + 1
                PcRes.Floor = "Floor Test " & i + 1
                PcRes.Building = "Building Test " & i + 1
                PcRes.OS = "OS Test " & i + 1
                PcRes.Ram = "Ram Test " & i + 1
                PcRes.Cpu = "Cpu Test " & i + 1
                PcRes.IP = "IP Test " & i + 1
                PcRes.PrivateSoftware = "PrivateSoftware Test " & i + 1
                PcRes.AddDate = "AddDate Test " & i + 1
                PcRes.AddTime = "AddTime Test " & i + 1
                PcRes.Notes = "Notes Test " & i + 1
                PcRes.Status = "Status Test " & i + 1
                PcRes.Year = "Year Test " & i + 1
                PcRes.PCType = "PCType Test " & i + 1
                PcRes.PCMonitorBrand = "PCMonitorBrand Test " & i + 1
                PcRes.PCMonitorModel = "PCMonitorModel Test " & i + 1
                PcRes.PCMonitorInch = "PCMonitorInch Test " & i + 1
                PcRes.PCMonitorInv = "PCMonitorInv Test " & i + 1
                PcRes.PCMonitorSN = "PCMonitorSN Test " & i + 1
                PcRes.PCMonitorNotes = "PCMonitorNotes Test " & i + 1
                PcRes.PCMonitorStatus = "PCMonitorStatus Test " & i + 1
                PcRes.PCMonitorYear = "PCMonitorYear Test " & i + 1
                PcRes.IDConnPrinter = "IDConnPrinter Test " & i + 1
                PcRes.IDConnHW = "IDConnHW Test " & i + 1
                PcRes.PCDriverFolder = "PCDriverFolder Test " & i + 1
                PcResList.Add(PcRes)
            Next

            Return PcResList
        End Function
    End Class

End Class
