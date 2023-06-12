<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewRamen.aspx.cs" Inherits="RaamenProject.View.Ramen.viewRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Manage Ramen
            </h1>
            <asp:GridView ID="GridView1" runat="server" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                </Columns>
            </asp:GridView>

            <asp:Button ID="addBtn" runat="server" Text="Add" OnClick="addBtn_Click" />
        </div>
    </form>
</body>
</html>
