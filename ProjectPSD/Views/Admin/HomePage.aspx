<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_PSD.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN HOME PAGE</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>WELCOME TO RAiso!</h1>
        <div>
            <h2>Stationery List</h2>
            <asp:GridView ID="StationeryGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="NAME" SortExpression="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="PRICE" SortExpression="StationeryPrice" />
                    <asp:ButtonField ButtonType="Button" CommandName="Edit" Text="UPDATE" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="DELETE" />
                </Columns>
            </asp:GridView>
            <div class="insert-button">
                <asp:Button ID="insertButton" runat="server" Text="INSERT" />
            </div>
        </div>
    </form>
</body>
</html>
