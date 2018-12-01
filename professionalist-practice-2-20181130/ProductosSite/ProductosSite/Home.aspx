<%@ Page Title="" Language="C#" MasterPageFile="~/Products.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProductosSite.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GVProducts" runat="server">
        <RowStyle BackColor="White" ForeColor="#003399" /> 
    </asp:GridView>
</asp:Content>
