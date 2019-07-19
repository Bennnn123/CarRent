<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BCTwo.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登入</title>
    <link href="../logincss/style.css" rel="stylesheet" />
    <style>
        h1{
            color:#ffffff;
        }
    </style>
</head>
<body>
    <div id="login">
        <form name='form-login' runat="server" id="f1">
            <h1>UUU租車 | 後臺管理系統</h1>
            <span class="fontawesome-user"></span>
            <%--<input type="text" id="user" placeholder="Username" />--%>
            <asp:TextBox ID="txtUser" runat="server" placeholder="Username" />

            <span class="fontawesome-lock"></span>
            <%--<input type="password" id="pass" placeholder="Password" />--%>
            <asp:TextBox ID="txtPass" runat="server" placeholder="Password" TextMode="Password" />

            <%--<input type="submit" value="Login" />--%>
            <asp:Button ID="btnSend" runat="server" Text="Login" OnClick="btnSend_Click" />
        </form>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script src="../logincss/script.js"></script>
</body>
</html>
