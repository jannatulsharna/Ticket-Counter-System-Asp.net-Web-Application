<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="TicketCounter.signUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1><b> Sign Up Page</b></h1>
    <br />
    <table>
        <tr>
            <td>
                User ID
            </td>
            <td>
                <asp:TextBox ID="tbxId" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                User Name
            </td>
            <td>
                <asp:TextBox ID="tbxUserName" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                User Password
            </td>
            <td>
                <asp:TextBox ID="tbxPasword" runat="server" TextMode="Password"/>
            </td>
        </tr>
        <tr>
            <td>
                User Phone Number
            </td>
            <td>
                <asp:TextBox ID="tbxNumber" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
              
            </td>
            <td>
                <asp:Button ID="btnSignUp" Text="Sign UP" runat="server" OnClick="btnSignUp_Click" />
                <asp:Label ID="lblShow" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
              
            </td>
            <td>
                <asp:Button ID="btnSignIn" Text="Sign In" runat="server" OnClick="btnSignIn_Click" />
                
            </td>
        </tr>
    </table> 
</asp:Content>
 