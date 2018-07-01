<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidatorControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Ingrese nombre: <asp:TextBox runat="server" id="txt_nombre"/>
        <asp:RequiredFieldValidator ErrorMessage="Debe completar el nombre" EnableClientScript="false" ControlToValidate="txt_nombre" runat="server" />
        <br /><br />

        Ingrese edad: <asp:TextBox runat="server" id="txt_edad"/>
        <asp:RangeValidator ControlToValidate="txt_edad" runat="server" EnableClientScript="false" MinimumValue="0" MaximumValue="99" Text="Rango de edad incorrecto" Type="Integer"/>
        <br /><br />

        Ingrese contraseña: <asp:TextBox runat="server" id="txt_password" TextMode="Password" /><br />
        Repita contraseña: <asp:TextBox runat="server" ID="txt_rep_password" TextMode="Password" />
        <asp:CompareValidator ErrorMessage="Las contraseñas no coinciden" EnableClientScript="false" ControlToValidate="txt_password" ControlToCompare="txt_rep_password" Operator="Equal" Type="String" runat="server" />
        <br /><br />

        Ingrese email: <asp:TextBox runat="server" id="txt_email"/>
        <asp:RegularExpressionValidator ErrorMessage="Formato de email incorrecto" EnableClientScript="false" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="txt_email" runat="server" />
        <br /><br />

        Ingrese un numero menor a 10: <asp:TextBox runat="server" id="txt_numero"/>
        <asp:CustomValidator ErrorMessage="Numero incorrecto" EnableClientScript="false" ControlToValidate="txt_numero" ID="numberValidator" OnServerValidate="numberValidator_ServerValidate" runat="server" />
        <br /><br />
        <button type="submit" runat="server">Enviar</button>
    </form>
</body>
</html>
