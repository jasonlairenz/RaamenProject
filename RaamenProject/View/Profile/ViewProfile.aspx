<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="RaamenProject.View.Profile.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ViewProfileStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Profile</h1>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label> 
            <asp:Label ID="usernameLbl" runat="server" Text=""></asp:Label> <br />

            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="emailLbl" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
            <asp:Label ID="genderLbl" runat="server" Text=""></asp:Label><br />

            <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
            <asp:Label ID="passLbl" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        </div>
    </form>
</body>
</html>
