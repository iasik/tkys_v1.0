<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_bildirim_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <br />
        Detay:<asp:TextBox ID="txt_detay" runat="server"></asp:TextBox>
        <br />
        Kullanıcı ID:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
    <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" />
    </form>
</asp:Content>

