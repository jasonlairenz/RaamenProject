<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="RaamenProject.View.Ramen.orderRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../AsetStyle/tableStyle.css" rel="stylesheet" />
    <%--<link href="orderRamenStyle.css" rel="stylesheet" />--%>
    <link href="../AsetStyle/navbarStyle.css" rel="stylesheet" />
    <link href="../AsetStyle/contentStyle.css" rel="stylesheet" />
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
                <h1>
                Order Ramen
            </h1>
            <h2>List Of Ramen</h2>
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand"  CssClass="gridview">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Order" ShowHeader="True" Text="Order" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label><br />
            <asp:TextBox ID="quantityTxt" runat="server" value="1"></asp:TextBox>



            <br />
            <h2>My Cart</h2>
            <asp:GridView ID="GridView2" runat="server" OnRowDeleting="GridView2_RowDeleting1"  CssClass="gridview">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                </Columns>
            </asp:GridView>

            <asp:Button CssClass="contentBtn" ID="clearCartBtn" runat="server" Text="Clear Cart" OnClick="clearCartBtn_Click" />
            <asp:Button CssClass="contentBtn" ID="buyBtn" runat="server" Text="Buy" OnClick="buyBtn_Click" />
            <br />
            <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
            </div>
            
        </div>
    </form>
</body>
</html>
