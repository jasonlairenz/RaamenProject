<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="RaamenProject.View.Transaction.TransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Transaction Detail</h2>
            <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand">
                <Columns>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
