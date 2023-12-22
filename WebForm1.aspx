<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Question_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUserName">User Name:</label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddUser" Text="Add User" runat="server" OnClick="btnAddUser_Click" />
            <br />
            <span id="lblMessage" runat="server"></span>
        </div>
    </form>
</body>
</html>
