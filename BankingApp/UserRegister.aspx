<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="BankingApp.UserRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            position: absolute;
            top: 8px;
            left: 476px;
            z-index: 1;
            right: 611px;
        }
        .auto-style13 {
            width: 100%;
        }
        .auto-style15 {
            width: 320px;
        }
        .auto-style16 {
            width: 382px;
        }
    .auto-style17 {
        position: absolute;
        top: 289px;
        left: 509px;
        z-index: 1;
        width: 64px;
        height: 30px;
        right: 602px;
    }
    .auto-style18 {
        position: absolute;
        top: 290px;
        left: 610px;
        z-index: 1;
        width: 64px;
        height: 30px;
        right: 501px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" BackColor="Lime" BorderColor="#66FF33" BorderStyle="Solid" CssClass="auto-style12" Font-Size="25px" ForeColor="White" Text="Register"></asp:Label>
    <br />
    <br />
    <br />
    <table class="auto-style13">
        <tr>
            <td class="auto-style16">
                <asp:Label ID="lblName" runat="server" Text="Ful Name"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtUserName" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label3" runat="server" Text="Account Number"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtAccount" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtAddress" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label5" runat="server" Text="Mobile Number"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtMobile" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label6" runat="server" Text="Adhar card Number"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtAdhar" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label7" runat="server" Text="Username For Login"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtUserLog" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtPass" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Label ID="Label9" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td class="auto-style15">
                <asp:TextBox ID="txtPassConf" runat="server" Width="310px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
<asp:Button ID="Button1" runat="server" href="LoginPage.aspx" BackColor="#FF3300" BorderColor="#FF3300" BorderStyle="Solid" CssClass="auto-style18" Font-Bold="True" Height="32px" Text="SignIn" Width="66px"/>
&nbsp;<asp:Label ID="lblmes" runat="server" style="z-index: 1; left: 53px; top: 286px; position: absolute"></asp:Label>
    <br />
<asp:Button ID="btnRegister" runat="server" BackColor="Lime" BorderColor="Lime" BorderStyle="Solid" CssClass="auto-style17" Font-Bold="True" ForeColor="Black" Height="32px" Text="Register" Width="66px" OnClick="btnRegister_Click"/>
    <br />
</asp:Content>
