<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="ProductosSite.ListadoProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
        <asp:Button ID="btnBack" runat="server" Text="Volver al Home" OnClick="btnBack_Click" />
    </div>
    </form>
</body>
</html>
