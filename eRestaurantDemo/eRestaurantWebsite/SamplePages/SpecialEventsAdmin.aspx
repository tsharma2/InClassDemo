<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpecialEventsAdmin.aspx.cs" Inherits="SamplePages_SpecialEventsAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1> Special Events Adminstration</h1>
    <p> &nbsp;</p>
    <table align="center" style="width:80%">
        <tr>
            <td align="right" style="width:50%">Select an Event:</td>
            <td>&nbsp;
                <asp:DropDownList ID="SpecialEventList" runat="server"
                        width="200px">
                </asp:DropDownList> &nbsp; &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server">Fetch Reservations</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" align="center" runat="server" DataSourceID="ObjectDataSource1">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p></p>
</asp:Content>

