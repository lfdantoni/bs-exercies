<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controles.aspx.cs" Inherits="TP2.Controles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" id="pepe"/>
        <asp:TextBox runat="server" id="pepe2"/>
        <asp:Button Text="TEST" runat="server" id="test_btn" OnClick="test_btn_Click"/>
        <asp:Label Text="" BorderColor="Red" ID="error" runat="server" />
        <asp:CompareValidator ErrorMessage="" 
            ControlToValidate="pepe" 
            ControlToCompare="pepe2"
            Type="Integer"
            Operator="GreaterThan"
            EnableClientScript="false"
            runat="server"
            id="validate" />
        
    </form>
</body>
</html>
