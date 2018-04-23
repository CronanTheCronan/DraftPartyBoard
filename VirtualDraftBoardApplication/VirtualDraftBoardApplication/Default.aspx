<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VirtualDraftBoardApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Draft Party</h1>

    <h3>Setup Your League</h3>
    <p>
        <asp:Label ID="lblLeagueName" runat="server" Text="League Name:"></asp:Label>
        <asp:TextBox ID="txtLeagueName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblNumberOfTeams" runat="server" Text="Number of Teams:"></asp:Label>
        <asp:DropDownList ID="ddlNumberOfTeams" runat="server" >
        </asp:DropDownList>
        </p>
    <p>
        <asp:Button ID="btnLeagueInit" runat="server" Text="Go" OnClick="btnLeagueInit_Click" />
    </p>
    <p>
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        
    </p>

</asp:Content>

