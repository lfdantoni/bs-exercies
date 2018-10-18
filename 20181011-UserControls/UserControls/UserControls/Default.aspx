<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControls.Default" %>
<%@ Register Src="~/UserControls/PhoneNumberControl.ascx" TagName="PhoneNumber" TagPrefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc:PhoneNumber ID="PhoneNumber" runat="server"></uc:PhoneNumber>
        <asp:Button ID="Button1" runat="server" Text="Valid Number" OnClick="Button1_Click"/>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
