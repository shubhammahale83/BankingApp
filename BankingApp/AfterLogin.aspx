<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AfterLogin.aspx.cs" Inherits="BankingApp.AfterLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="25px" ForeColor="#00CCFF" style="z-index: 1; left: 202px; top: -4px; position: absolute; height: 42px; width: 714px; text-align: center" Text="Welcome @Username to the 'BANK OF INDIA'"></asp:Label>
    <br />
    <br />
    <asp:ImageButton ID="ImageButton3" href="Deposite.aspx" runat="server" ImageUrl="http://www.clker.com/cliparts/J/i/R/D/B/4/withdraw-md.png" style="z-index: 1; left: 593px; top: 69px; position: absolute; height: 37px; width: 112px" />
    <asp:ImageButton ID="ImageButton2" href="Withdraw.aspx" runat="server" Height="68px" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTDfMhGoOKayVIJmDH1-y-OUDOtntChZG_PnzuIiRpu-CStJzVZcr2yLAfbDOq50cfGEQ&amp;usqp=CAU" style="z-index: 1; left: 415px; top: 51px; position: absolute" Width="126px" />
    <br />
</asp:Content>
