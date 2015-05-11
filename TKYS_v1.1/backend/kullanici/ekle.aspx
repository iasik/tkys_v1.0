<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_kullanici_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <br />
        Soyad:<asp:TextBox ID="txt_soyad" runat="server"></asp:TextBox>
        <br />
        Cinsiyet:<asp:RadioButtonList ID="cinsiyet" runat="server">
            <asp:ListItem Value="0">Bay</asp:ListItem>
            <asp:ListItem Value="1">Bayan</asp:ListItem>
        </asp:RadioButtonList>
        Cep Telefonu:<asp:TextBox ID="txt_cep_telefonu" runat="server"></asp:TextBox>
        <br />
        E-Posta:<asp:TextBox ID="txt_e_posta" runat="server"></asp:TextBox>
        <br />
        Kullanıcı Adı:<asp:TextBox ID="txt_kullanici_adi" runat="server"></asp:TextBox>
        <br />
        Şifre:<asp:TextBox ID="txt_sifre" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        Yetki:<asp:RadioButtonList ID="yetki" runat="server">
            <asp:ListItem Value="1">Yönetici</asp:ListItem>
            <asp:ListItem Value="2">Personel</asp:ListItem>
            <asp:ListItem Value="3">Site Sakini</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" />
    </form>
</asp:Content>

