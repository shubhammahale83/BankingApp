<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Deposite.aspx.cs" Inherits="BankingApp.Deposite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            width: 100%;
            height: 193px;
        }
        .auto-style15 {
            width: 321px;
            height: 71px;
        }
        .auto-style16 {
            width: 326px;
            height: 71px;
            text-align: center;
        }
        .auto-style17 {
            height: 71px;
        }
        .auto-style18 {
            position: absolute;
            top: 16px;
            left: 428px;
            z-index: 1;
        }
        .auto-style19 {
            width: 326px;
            height: 65px;
        }
        .auto-style21 {
            position: absolute;
            top: 227px;
            left: 432px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style22 {
            width: 321px;
            text-align: center;
            height: 65px;
        }
        .auto-style23 {
            height: 65px;
        }
        .auto-style24 {
            width: 321px;
            text-align: right;
            height: 38px;
        }
        .auto-style25 {
            width: 326px;
            text-align: center;
            height: 38px;
        }
        .auto-style26 {
            height: 38px;
        }
        .auto-style27 {
            width: 321px;
            text-align: right;
            height: 44px;
        }
        .auto-style28 {
            width: 326px;
            text-align: center;
            height: 44px;
        }
        .auto-style29 {
            height: 44px;
        }
        .auto-style30 {
            position: absolute;
            top: 227px;
            z-index: 1;
            width: 62px;
            height: 25px;
            left: 117px;
        }
        .auto-style31 {
            position: absolute;
            top: 226px;
            left: 563px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="auto-style12">
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style16">
                <asp:Label ID="lblDeposite" runat="server" BackColor="#99CC00" BorderColor="#99CC00" BorderStyle="Inset" CssClass="auto-style18" Font-Bold="True" Font-Size="XX-Large" Text="Deposite"></asp:Label>
            </td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style27">
                <asp:Label ID="lblAccountNo" runat="server" Text="Account No"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:TextBox ID="TxtAcc" runat="server" Width="161px"></asp:TextBox>
            </td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style27">
                <asp:Label ID="lblIFSCcode" runat="server" Text="IFSC Code"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:TextBox ID="txtIFSC" runat="server" Width="163px"></asp:TextBox>
            </td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style24">
                <asp:Label ID="lblAmount" runat="server" Text="Amount in ₹"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:TextBox ID="txtAmount" runat="server" Width="164px"></asp:TextBox>
            </td>
            <td class="auto-style26"></td>
        </tr>
        <tr>
            <td class="auto-style22">
                <asp:Label ID="lblbal" runat="server" CssClass="auto-style30" Font-Bold="True" Font-Overline="True" Font-Size="20px" ForeColor="#FF3300"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:Button ID="btnDeposite" runat="server" BackColor="#FF3300" BorderColor="#FF3300" BorderStyle="Outset" CssClass="auto-style21" Font-Bold="True" Font-Overline="False" Font-Size="20px" ForeColor="White" Text="Submit" OnClick="btnDeposite_Click" />
            </td>
            <td class="auto-style19">
                <asp:Button ID="btnShow" runat="server" BackColor="#9933FF" BorderColor="#FF3300" BorderStyle="Outset" CssClass="auto-style31" Font-Bold="True" Font-Overline="False" Font-Size="20px" ForeColor="White" Text="Balance" OnClick="btnShow_Click" />
            </td>
            <td class="auto-style23"></td>
        </tr>
    </table>
</asp:Content>
