<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="ProductosSite.ListadoProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
            SelectMethod="GetAllProductos" TypeName="ProductosSite.Services.ProductService">
        </asp:ObjectDataSource>
        <asp:GridView ID="gvProducts" runat="server" CssClass="table table-dark" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" >
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Código"></asp:BoundField>
                <asp:BoundField DataField="nombre" HeaderText="Nombre"></asp:BoundField>
                <asp:BoundField DataField="categoria" HeaderText="categoria"></asp:BoundField>
                <asp:BoundField DataField="preciocosto" HeaderText="Precio Costo"></asp:BoundField>
                <asp:BoundField DataField="margen" HeaderText="Margen"></asp:BoundField>
                <asp:BoundField DataField="iva" HeaderText="IVA"></asp:BoundField>
                <asp:BoundField DataField="preciobruto" HeaderText="Precio Bruto"></asp:BoundField>
                <asp:BoundField DataField="precioventa" HeaderText="Precio Venta"></asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnBack" runat="server" Text="Volver al Home" OnClick="btnBack_Click" />
    </div>
    </form>
</body>
</html>
