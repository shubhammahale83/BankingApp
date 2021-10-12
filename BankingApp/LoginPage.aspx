<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="BankingApp.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            width: 100%;
        }
        .auto-style15 {
            position: absolute;
            top: 8px;
            left: 436px;
            z-index: 1;
            width: 78px;
            height: 36px;
        }
        .auto-style16 {
            width: 302px;
            height: 60px;
        }
        .auto-style17 {
        width: 245px;
        height: 60px;
    }
        .auto-style19 {
            width: 302px;
            height: 38px;
        }
        .auto-style20 {
            width: 245px;
            height: 38px;
        }
        .auto-style22 {
            width: 302px;
            height: 36px;
        }
        .auto-style23 {
            width: 245px;
            height: 36px;
        }
        .auto-style25 {
            position: absolute;
            top: 71px;
            left: 111px;
            z-index: 1;
        }
        .auto-style26 {
            position: absolute;
            top: 112px;
            left: 111px;
            z-index: 1;
        }
        .auto-style27 {
            position: absolute;
            top: 158px;
            left: 383px;
            z-index: 1;
            width: 79px;
            height: 36px;
        }
        .auto-style28 {
            position: absolute;
            top: 158px;
            left: 481px;
            z-index: 1;
            width: 73px;
            height: 35px;
        }
        .auto-style29 {
            position: absolute;
            top: 160px;
            left: 115px;
            z-index: 1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style12">
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17">
                <asp:Label ID="Label1" runat="server" BackColor="#FF33CC" BorderColor="Fuchsia" BorderStyle="Solid" CssClass="auto-style15" Font-Bold="True" Font-Size="25px" ForeColor="Black" Text="Sign In"></asp:Label>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style19">
                <asp:Label ID="Label2" runat="server" CssClass="auto-style25" Text="UserName"></asp:Label>
            </td>
            <td class="auto-style20">
                <asp:TextBox ID="txtUserName" runat="server" Width="240px"></asp:TextBox>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="Label3" runat="server" CssClass="auto-style26" Text="Password"></asp:Label>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="txtPassword" runat="server" Width="241px"></asp:TextBox>
            </td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lblmes" runat="server" CssClass="auto-style29"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:Button ID="btnLogin" runat="server" CssClass="auto-style27" OnClick="btnLogin_Click" Text="Sign In" BackColor="#66FF66" BorderColor="#66FF66" BorderStyle="Solid" Font-Bold="True" />
                <asp:Button ID="btnRegister" runat="server" CssClass="auto-style28" Text="Register" BackColor="#FF3300" BorderColor="#FF3300" BorderStyle="Solid" Height="36px" Width="79px" href="UserRegister.aspx"/>
            </td>
            <td class="auto-style13"></td>
        </tr>
    </table>
</asp:Content>
