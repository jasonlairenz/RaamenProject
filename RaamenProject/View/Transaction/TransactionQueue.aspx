<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionQueue.aspx.cs" Inherits="RaamenProject.View.Transaction.TransactionQueue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Transaction Queue</h2>
            <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Verify" ShowHeader="True" Text="Verify" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
