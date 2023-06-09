<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RaamenProject.View.Home" %>

<!DOCTYPE html>
<%@ Import Namespace="System.Web.Security" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <%if (getUserRole() == 1) { %>
                <%--member--%>
                <asp:BulletedList ID="memberNav" runat="server" >
                    <asp:ListItem>Order Ramen</asp:ListItem>
                    <asp:ListItem>History</asp:ListItem>
                </asp:BulletedList>


                
                <% } else if(getUserRole() == 2){ %>
                <%--admin--%>
                <asp:BulletedList ID="adminNav" runat="server" >
                    <asp:ListItem>Manage Ramen</asp:ListItem>
                    <asp:ListItem>Order Queue</asp:ListItem>
                    <asp:ListItem>History</asp:ListItem>
                    <asp:ListItem>Report</asp:ListItem>
                </asp:BulletedList>
                
                <% } else if(getUserRole() == 3){ %>
                <%--staff--%>
                <asp:BulletedList ID="staffNav" runat="server" >
                    <asp:ListItem>Home</asp:ListItem>
                    <asp:ListItem>Manage Ramen</asp:ListItem>
                    <asp:ListItem>Order Queue</asp:ListItem>
                </asp:BulletedList>
                <% } %>


                <asp:Button ID="profileBtn" runat="server" Text="Profile" OnClick="profileBtn_Click" />
                <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click" />
            </nav>

            <%if (getUserRole() == 1) { %>
                <h1>Welcome, Member!</h1>
                <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label>
            <% } else if(getUserRole() == 2){ %>
                <h1>Welcome, Admin!</h1>

                <h1>Member</h1>
                <asp:GridView ID="GridViewMemberr" runat="server"></asp:GridView>

                <h1>Staff</h1>
                <asp:GridView ID="GridViewStaff" runat="server"></asp:GridView>

             <% } else if(getUserRole() == 3){ %>
                <h1>Welcome, Staff!</h1>

                <h1>Member</h1>
                <asp:GridView ID="GridViewMember" runat="server"></asp:GridView>
            <% } %>

            
            
            <h1>Ini Dashboard</h1>
            <asp:Label ID="infoLbl" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
