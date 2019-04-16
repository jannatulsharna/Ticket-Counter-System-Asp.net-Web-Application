<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="TicketDetails.aspx.cs" Inherits="TicketCounter.TicketDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><b> Ticket Confirmation </b></h1>
    <br />
    <br />
    <table>
        <tr>
            <td>
                Your Name
            </td>
            <td>
                <asp:TextBox ID="tbxName" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Bus Time
            </td>
            <td>
                <asp:TextBox ID="tbxTime" runat="server" />
            </td>
        </tr>
         <tr>
            <td>
                Bus Destination
            </td>
            <td>
                <asp:TextBox ID="tbxdes" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Your Journey Day
            </td>
            <td>
                <asp:TextBox ID="tbxDay" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Number Of Ticket
            </td>
            <td>
                <asp:TextBox ID="tbxA" runat="server" />
            </td>
        </tr>
         <tr>
            <td>
                Your Cost
            </td>
            <td>
                <asp:TextBox ID="tbxCost" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                <asp:Label ID="lblShow" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
