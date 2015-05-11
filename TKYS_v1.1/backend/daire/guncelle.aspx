<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_daire_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Blok:<asp:TextBox ID="txt_blok" runat="server"></asp:TextBox>
        <br />
        Kat:<asp:TextBox ID="txt_kat" runat="server"></asp:TextBox>
        <br />
        Daire No:<asp:TextBox ID="txt_daire_no" runat="server"></asp:TextBox>
        <br />
        Daire Genişliği:<asp:TextBox ID="txt_daire_genisligi" runat="server"></asp:TextBox>m2
        <br />
        Kullanıcı ID:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" />
    </form>
</asp:Content>

