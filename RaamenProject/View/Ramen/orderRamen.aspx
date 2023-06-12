<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderRamen.aspx.cs" Inherits="RaamenProject.View.Ramen.orderRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Order Ramen
            </h1>
            <h2>List Of Ramen</h2>
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Order" ShowHeader="True" Text="Order" />
                </Columns>
            </asp:GridView>

            <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label><br />
            <asp:TextBox ID="quantityTxt" runat="server" value="1"></asp:TextBox>



            <br />
            <h2>My Cart</h2>
            <asp:GridView ID="GridView2" runat="server" OnRowDeleting="GridView2_RowDeleting1">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
