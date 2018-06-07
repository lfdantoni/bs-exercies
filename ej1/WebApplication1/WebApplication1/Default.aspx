<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <label for="nombre">Nombre</label>
        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <br />
        <label for="apellido">Apellido</label>
        <asp:TextBox ID="Apellido" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="Resultado" runat="server" Text=""></asp:Label>

        <asp:Button ID="Mostrar" runat="server" Text="Button" OnClick="Mostrar_Click" />
    </div>
    </form>
</body>
</html>
