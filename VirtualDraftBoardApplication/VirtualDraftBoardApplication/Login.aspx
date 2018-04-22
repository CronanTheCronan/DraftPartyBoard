<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VirtualDraftBoardApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Draft Party</title>
    <link href="Content/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Draft Party</h1>
            <h2>Virtual Draft Board</h2>
        </div>
        <div>
            <asp:Login ID="Login1" runat="server" Height="263px" Width="307px"></asp:Login>
        </div>
    </form>
</body>
</html>
