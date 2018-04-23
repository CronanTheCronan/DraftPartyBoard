<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DraftBoard.aspx.cs" Inherits="VirtualDraftBoardApplication.DraftBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:DropDownList ID="ddlTeamSelect" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddlPositionSelect" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnFilter" runat="server" Text="Go!" OnClick="btnFilter_Click" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
    </div>
</asp:Content>
