<%@ Page Language="VB" MasterPageFile="../MasterPage.Master" AutoEventWireup="false" CodeFile="itsuiteaddontest.aspx.vb" Inherits="Components_itsuiteaddontest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
   <asp:Label runat="server" ID="TitleLable"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderSubTitle" Runat="Server">
   <asp:Label runat="server" ID="SubtitleLabel"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderCentral" runat="Server">
    <asp:Label runat="server" ID="BodyLabel"></asp:Label>
    <br />
    <br />
    <asp:Label runat="server" ID="LabelInfo"></asp:Label>
    <br />
    <br />
    <b><u><%=ResXHelper.GetString("String7")%></u></b>
    <br />
    <br />
  
    <asp:Panel ID="PanelPcData" runat="server" Visible="false">
        <b><%=ResXHelper.GetString("String8")%></b>
        <br />
        <%=ResXHelper.GetString("String9")%>: <asp:Label ID="LabelBrand" runat="server"></asp:Label>
        <br />
        <%=ResXHelper.GetString("String10")%>: <asp:Label ID="LabelModel" runat="server"></asp:Label>
        <br />
        <%=ResXHelper.GetString("String11")%>: <asp:Label ID="LabelSN" runat="server"></asp:Label>
        <br />
        ...
        <br />
        <br />
        <b><%=ResXHelper.GetString("String12")%></b>
        <br />
        <table style="width: 100%; height: auto; margin-top: 3px; border-collapse: collapse;" border="1">
            <tr>
                <td style="padding: 5px;"><b><%=ResXHelper.GetString("String9")%></b></td>
                <td style="padding: 5px;"><b><%=ResXHelper.GetString("String10")%></b></td>
                <td style="padding: 5px;"><b><%=ResXHelper.GetString("String11")%></b></td>
            </tr>
            <asp:Label ID="PcListLabel" runat="server"></asp:Label>
        </table>
    </asp:Panel>
</asp:Content>
