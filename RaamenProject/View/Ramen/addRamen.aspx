<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addRamen.aspx.cs" Inherits="RaamenProject.View.addRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="addRamenStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Ramen</h1><br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><br />
                <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox><br />
            </div>

            <div>
                <asp:Label ID="Label4" runat="server" Text="Meat"></asp:Label><br />
                <asp:DropDownList id="meatBtn" runat="server" >
                    <asp:ListItem Value="1" Selected="True">Chicken</asp:ListItem>
                    <asp:ListItem Value="2" >Beef</asp:ListItem>
                    <asp:ListItem Value="3" >Pork</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div>
                <asp:Label ID="Label3" runat="server" Text="Borth"></asp:Label><br />
                <asp:TextBox ID="borthTxt" runat="server"></asp:TextBox><br />
            </div>

            <div>
                <asp:Label ID="Label7" runat="server" Text="Price"></asp:Label><br />
                <asp:TextBox type="number" ID="priceTxt" runat="server"></asp:TextBox><br />
            </div>

            <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label><br />

            <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
        </div>
    </form>
</body>
</html>
