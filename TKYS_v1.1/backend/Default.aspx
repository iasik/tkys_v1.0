<%@ Page Title="" Language="C#" MasterPageFile="~/backend/backend.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="backend_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
    <form id="form1" runat="server">
    <div>
    
    
    <asp:TextBox ID="ad" runat="server"></asp:TextBox>
    <asp:TextBox ID="soyad" runat="server"></asp:TextBox>
    <asp:TextBox ID="cinsiyet" runat="server"></asp:TextBox>
    <asp:TextBox ID="cep_tel" runat="server"></asp:TextBox>
    <asp:TextBox ID="posta" runat="server"></asp:TextBox>
    <asp:TextBox ID="kullanici" runat="server"></asp:TextBox>
    <asp:TextBox ID="sifre" runat="server"></asp:TextBox>
    <asp:TextBox ID="yetki" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    Page content goes here<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</asp:Content>

