<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpecialEventsAdmin.aspx.cs" Inherits="SamplePages_SpecialEventsAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <h1> Special Events Adminstration</h1>
    <p> &nbsp;</p>
    <table align="center" style="width:80%">
        <tr>
            <td align="right" style="width:50%">Select an Event:</td>
            <td>&nbsp;
                <asp:DropDownList ID="SpecialEventList" runat="server"
                        width="200px" AppendDataBoundItems="True" DataSourceID="ODSSpecialEvent" DataTextField="Description" DataValueField="EventCode">
                    <asp:ListItem Value="z">Select Event</asp:ListItem>
                </asp:DropDownList> &nbsp; &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server">Fetch Reservations</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 141px"></td>
            <td style="height: 141px">
                <asp:GridView ID="ReservationList" align="center" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODSReservation" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="ReservationID" HeaderText="ReservationID" SortExpression="ReservationID" />
                        <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
                        <asp:BoundField DataField="ReservationDate" DataFormatString="{0:MMM.dd.yyy}" HeaderText="ReservationDate" SortExpression="ReservationDate" />
                        <asp:BoundField DataField="NumberInParty" HeaderText="Size" SortExpression="NumberInParty" />
                        <asp:BoundField DataField="ContactPhone" HeaderText="ContactPhone" SortExpression="ContactPhone" />
                        <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus" />
                        <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />
                        <asp:BoundField DataField="CustomerName" HeaderText="Name" SortExpression="CustomerName">
                        <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="ODSSpecialEvent" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="SpecialEvent_List" TypeName="eRestaurantSystem.BLL.AdminController"></asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="ODSReservation" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetReservationByEventCode" TypeName="eRestaurantSystem.BLL.AdminController">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ReservationList" Name="eventcode" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p></p>
</asp:Content>

