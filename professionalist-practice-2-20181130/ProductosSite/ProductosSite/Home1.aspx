<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home1.aspx.cs" Inherits="ProductosSite.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tbody>
                <tr>
                    <td>Codigo</td>
                    <td>
                        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nombre</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Categoria</td>
                    <td>
                        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Precio Costo</td>
                    <td>
                        <asp:TextBox ID="txtCostPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Margen</td>
                    <td>
                        <asp:TextBox ID="txtMargin" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>IVA</td>
                    <td></td>
                </tr>
                <tr>
                    <td>Precio Bruto</td>
                    <td>
                        <asp:Label ID="lblGrossPrice" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Precio Venta</td>
                    <td>
                        <asp:Label ID="lblSellPrice" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td>
                        <asp:Button ID="btnList" runat="server" Text="Listar" />
                        <asp:Button ID="btnInsert" runat="server" Text="Insertar" />
                        <asp:Button ID="btnDelete" runat="server" Text="Borrar" />
                        <asp:Button ID="btnEdit" runat="server" Text="Modificar" />
                        <asp:Button ID="btnGetData" runat="server" Text="Obtener Datos" />
                        <asp:Button ID="btnExit" runat="server" Text="Salir" />
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
    </form>
</body>
</html>
