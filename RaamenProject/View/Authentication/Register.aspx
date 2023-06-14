<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RaamenProject.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="RegisterStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label><br />
                <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox><br />
            </div>
            
            <div>
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><br />
                <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox><br />
            </div>
        
            <div>
                <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label><br />
                <asp:RadioButtonList ID="genderBtn" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem >Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div>
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="passTxt" type="password" runat="server"></asp:TextBox><br />
            </div>

            <div>
                <asp:Label ID="Label5" runat="server" Text="Confirmation Password"></asp:Label><br />
                <asp:TextBox ID="confirmTxt" type="password" runat="server"></asp:TextBox><br />
            </div>

            <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" /><br />
            
            <p>Already have account? <a href="Login.aspx">Login Here!</a></p>
            
    </form>
</body>
</html>
