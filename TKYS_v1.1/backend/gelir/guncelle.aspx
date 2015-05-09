<%@ Page Title="" Language="C#" MasterPageFile="~/backend/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_gelir_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        <asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt_miktar" runat="server"></asp:TextBox>
        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" />
    </form>
</asp:Content>


