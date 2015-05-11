<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_kullanici_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <br />
        Soyad:<asp:TextBox ID="txt_soyad" runat="server"></asp:TextBox>
        <br />
        Cinsiyet:<asp:RadioButton ID="RadioButton1" Text="Bay" runat="server" GroupName="cinsiyet" /><asp:RadioButton ID="RadioButton2" Text="Bayan" runat="server" GroupName="cinsiyet" />
        <br />
        Cep Telefonu:<asp:TextBox ID="txt_cep_telefonu" runat="server"></asp:TextBox>
        <br />
        E-Posta:<asp:TextBox ID="txt_e_posta" runat="server"></asp:TextBox>
        <br />
        Kullanıcı Adı:<asp:TextBox ID="txt_kullanici_adi" runat="server"></asp:TextBox>
        <br />
        Şifre:<asp:TextBox ID="txt_sifre" runat="server" ></asp:TextBox>
        <br />
        Yetki:<asp:RadioButtonList ID="yetki" runat="server">
            <asp:ListItem Value="1">Yönetici</asp:ListItem>
            <asp:ListItem Value="2">Personel</asp:ListItem>
            <asp:ListItem Value="3">Site Sakini</asp:ListItem>
        </asp:RadioButtonList>
        <br />        
        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" Runat="Server">
</asp:Content>

