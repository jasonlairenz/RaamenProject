<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewRamen.aspx.cs" Inherits="RaamenProject.View.Ramen.viewRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="viewRamenStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Manage Ramen
            </h1>
            
            <asp:GridView ID="GridView1" runat="server" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" CssClass="gridview">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" ItemStyle-CssClass="buttonField" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" ItemStyle-CssClass="buttonField" />
                </Columns>
            </asp:GridView>


            <asp:Button ID="addBtn" runat="server" Text="Add" OnClick="addBtn_Click" />
        </div>
    </form>
</body>
</html>
