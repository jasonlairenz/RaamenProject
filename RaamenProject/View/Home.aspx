<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RaamenProject.View.Home" %>

<!DOCTYPE html>
<%@ Import Namespace="System.Web.Security" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AsetStyle/navbarStyle.css" rel="stylesheet" />
    
    <link href="AsetStyle/tableStyle.css" rel="stylesheet" />
    <link href="AsetStyle/contentStyle.css" rel="stylesheet" />
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

                <%if (getUserRole() == 1) { %>
                    <br />
                    <h1>Welcome, Member!</h1><br />
                    <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label><br />
                    <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label><br />

                <% } else if(getUserRole() == 2){ %>
                    <h1>Welcome, Admin!</h1><br />
                    <asp:Label ID="roleLbl2" runat="server" Text=""></asp:Label><br />

                    <h1>Member</h1><br />
                    <asp:GridView CssClass="gridview" ID="GridViewMemberr" runat="server"></asp:GridView>

                    <h1>Staff</h1><br />
                    <asp:GridView CssClass="gridview" ID="GridViewStaff" runat="server"></asp:GridView>

                <% } else if(getUserRole() == 3){ %>
                    <h1>Welcome, Staff!</h1><br />
                    <asp:Label ID="roleLbl3" runat="server" Text=""></asp:Label><br />

                    <h1>Member</h1><br />
                    <asp:GridView CssClass="gridview" ID="GridViewMember" runat="server"></asp:GridView>
                <% } %>
                <br />
            </div>

            

        </div>
    </form>
</body>
</html>
