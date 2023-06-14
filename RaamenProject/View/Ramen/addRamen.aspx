<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addRamen.aspx.cs" Inherits="RaamenProject.View.addRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link href="addRamenStyle.css" rel="stylesheet" />--%>
    <link href="../AsetStyle/contentStyle.css" rel="stylesheet" />
    <link href="../AsetStyle/navbarStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <nav>
                <div>
                    <h1 class="logo">Raamen</h1>
                </div>

                <div>
                    <%if (getUserRole() == 1) { %>
                    <%--member--%>
                        <asp:Button CssClass="navBtn" ID="orderRamenBtn" runat="server" Text="Order" OnClick="orderRamenBtn_Click" />
                        <asp:Button CssClass="navBtn" ID="historyBtn1" runat="server" Text="History" OnClick="historyBtn_Click" />
          
                    <% } else if(getUserRole() == 2){ %>
                    <%--admin--%>
                            <asp:Button CssClass="navBtn" ID="manageRamenBtn1" runat="server" Text="Manage Ramen" OnClick="manageRamenBtn_Click" />
                            <asp:Button CssClass="navBtn" ID="orderQueueBtn1" runat="server" Text="Order Queue" OnClick="orderQueueBtn_Click" />
                            <asp:Button CssClass="navBtn" ID="historyBtn2" runat="server" Text="History" OnClick="historyBtn_Click"/>
                            <asp:Button CssClass="navBtn" ID="reportBtn" runat="server" Text="Report" OnClick="reportBtn_Click" />
                
                    <% } else if(getUserRole() == 3){ %>
                        <%--staff--%>
                        <asp:Button CssClass="navBtn" ID="homeBtn" runat="server" Text="Home" OnClick="homeBtn_Click1" />
                        <asp:Button CssClass="navBtn" ID="manageRamenBtn2" runat="server" Text="Manage Ramen" OnClick="manageRamenBtn_Click" />
                        <asp:Button CssClass="navBtn" ID="orderQueueBtn2" runat="server" Text="Order Queue" OnClick="orderQueueBtn_Click" />
                    <% } %>

                        <asp:Button CssClass="navBtn" ID="profileBtn" runat="server" Text="Profile" OnClick="profileBtn_Click" />
                        <asp:Button CssClass="navBtn" ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click" />
                    </div>
                </nav>

            <div class="content">
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

            <asp:Button CssClass="contentBtn" ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
            </div>
            
        </div>
    </form>
</body>
</html>
