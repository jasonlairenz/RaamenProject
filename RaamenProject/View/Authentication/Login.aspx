<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RaamenProject.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link href="LoginStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br />
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="passTxt" type="password" runat="server"></asp:TextBox><br 
            </div>

         <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label><br />
         <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" /><br />

        <asp:Label ID="infoLbl" runat="server" Text=""></asp:Label><br />

        <p>Don't have account? <a href="Register.aspx">Register Here!</a> </p>
        
    </form>
</body>
</html>
