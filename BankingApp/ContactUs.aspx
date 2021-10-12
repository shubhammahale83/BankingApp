<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="BankingApp.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            position: absolute;
            top: 27px;
            left: 433px;
            z-index: 1;
            height: 21px;
        }
        .auto-style13 {
            width: 100%;
        }
        .auto-style14 {
            width: 319px;
        }
        .auto-style15 {
            width: 319px;
            height: 32px;
        }
        .auto-style16 {
            height: 32px;
        }
        .auto-style17 {
            width: 319px;
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
        }
        .auto-style20 {
            width: 319px;
            height: 70px;
        }
        .auto-style21 {
            height: 70px;
        }
        .auto-style22 {
            position: absolute;
            top: 313px;
            left: 381px;
            z-index: 1;
            width: 111px;
            height: 39px;
        }
        .auto-style23 {
            width: 211px;
            height: 23px;
        }
        .auto-style24 {
            width: 211px;
            height: 32px;
        }
        .auto-style25 {
            width: 211px;
        }
        .auto-style26 {
            width: 211px;
            height: 70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" BackColor="#00CCFF" BorderColor="Lime" BorderStyle="Solid" CssClass="auto-style12" ForeColor="White" Text="Contact US - Send Email"></asp:Label>
    </p>
    <br/>
    <table class="auto-style13">
        <tr>
            <td class="auto-style17">
                <asp:Label ID="Label2" runat="server" Text="To Email"></asp:Label>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="txtto" runat="server" Width="209px"></asp:TextBox>
            </td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Label ID="Label3" runat="server" Text="Attach File"></asp:Label>
            </td>
            <td class="auto-style24">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label4" runat="server" Text="Body Information"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:TextBox ID="txtBody" runat="server" Height="130px" TextMode="MultiLine" Width="214px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20">
                <asp:Label ID="lblmes" runat="server"></asp:Label>
            </td>
            <td class="auto-style26" id="Button1_Click">
                <asp:Button ID="Button1" runat="server" BackColor="Red" BorderColor="#CC0000" BorderStyle="Solid" CssClass="auto-style22" ForeColor="White" Text="Submit" OnClick="Button1_Click" />
            </td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
