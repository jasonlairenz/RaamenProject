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
                    <a href="">Order Ramen</a>
                    <a href="">History</a>

                
                <% } else if(getUserRole() == 2){ %>
                <%--admin--%>
                    <a href="Ramen/viewRamen.aspx">Manage Ramen</a>
                    <a href="">Order Queue</a>
                    <a href="">History</a>
                    <a href="">Report</a>
                
                <% } else if(getUserRole() == 3){ %>
                <%--staff--%>
                    <a href="">Home</a>
                    <a href="Ramen/viewRamen.aspx">Manage Ramen</a>
                    <a href="">Order Queue</a>
                <% } %>

                <a href="Profile/ViewProfile.aspx">Profile</a>
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
