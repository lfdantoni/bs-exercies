<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProductosSite.Home1" %>

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
                        $<asp:TextBox ID="txtCostPrice" runat="server" AutoPostBack="true" OnTextChanged="txtCostPrice_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Margen</td>
                    <td>
                        <asp:TextBox ID="txtMargin" runat="server" AutoPostBack="true" OnTextChanged="txtMargin_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>IVA</td>
                    <td>
                       <asp:TextBox ID="txtIva" runat="server" AutoPostBack="true" OnTextChanged="txtIva_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Precio Bruto</td>
                    <td>
                        $<asp:Label ID="lblGrossPrice" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Precio Venta</td>
                    <td>
                        $<asp:Label ID="lblSellPrice" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnList" runat="server" Text="Listar" OnClick="btnList_Click"/>
                        <asp:Button ID="btnInsert" runat="server" Text="Insertar" OnClick="btnInsert_Click"/>
                        <asp:Button ID="btnDelete" runat="server" Text="Borrar" OnClick="btnDelete_Click"/>
                        <asp:Button ID="btnEdit" runat="server" Text="Modificar" OnClick="btnEdit_Click"/>
                        <asp:Button ID="btnGetData" runat="server" Text="Obtener Datos" OnClick="btnGetData_Click" />
                        <asp:Button ID="btnExit" runat="server" Text="Salir" />
                    </td>
                </tr>
            </tfoot>
        </table>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
