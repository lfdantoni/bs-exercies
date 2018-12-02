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
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCode" ErrorMessage="Debe ser un numero" ForeColor="Red" ValidationExpression="\d*"></asp:RegularExpressionValidator>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCode" ErrorMessage="El codigo es requerido" ForeColor="Red"></asp:RequiredFieldValidator>
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
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCostPrice" ErrorMessage="Formato incorrecto" ForeColor="Red" ValidationExpression="[0-9]+(\.[0-9]*)?"></asp:RegularExpressionValidator>  
                    </td>
                </tr>
                <tr>
                    <td>Margen</td>
                    <td>
                        <asp:TextBox ID="txtMargin" runat="server" AutoPostBack="true" OnTextChanged="txtMargin_TextChanged"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtMargin" ErrorMessage="Formato incorrecto" ForeColor="Red" ValidationExpression="[0-9]+(\.[0-9]*)?"></asp:RegularExpressionValidator>  
                    </td>
                </tr>
                <tr>
                    <td>IVA</td>
                    <td>
                       <asp:TextBox ID="txtIva" runat="server" AutoPostBack="true" OnTextChanged="txtIva_TextChanged"></asp:TextBox>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtIva" ErrorMessage="Formato incorrecto" ForeColor="Red" ValidationExpression="[0-9]+(\.[0-9]*)?"></asp:RegularExpressionValidator>                      
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
                        <asp:Button ID="btnExit" runat="server" Text="Salir" OnClick="btnExit_Click" />
                    </td>
                </tr>
            </tfoot>
        </table>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <asp:Panel ID="pnlDialog" runat="server" Visible="false">
            <asp:Label ID="lblDialog" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnConfirmDialog" runat="server" Text="Si" OnClick="ConfirmDeleteProduct" />
            <asp:Button ID="btnCancelDialog" runat="server" Text="No" OnClick="btnCancelDialog_Click"/>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
