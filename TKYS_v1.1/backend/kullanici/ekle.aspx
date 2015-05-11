<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_kullanici_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad kısmı doldurulmalıdır.">Ad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
        <br />
        Soyad:<asp:TextBox ID="txt_soyad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_soyad" ErrorMessage="Soyad kısmı doldurulmalıdır.">Soyad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
        <br />
        Cinsiyet:<asp:RadioButtonList ID="cinsiyet" runat="server">
            <asp:ListItem Value="0">Bay</asp:ListItem>
            <asp:ListItem Value="1">Bayan</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cinsiyet" ErrorMessage="Cinsiyet seçilmelidir.">Cinsiyet seçilmelidir.</asp:RequiredFieldValidator>
        Cep Telefonu:<asp:TextBox ID="txt_cep_telefonu" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_cep_telefonu" ErrorMessage="Telefon alanı boş bırakılamaz.">Telefon alanı boş bırakılamaz.</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_cep_telefonu" ErrorMessage="Cep telefon girişi yanlış." ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">Cep telefon girişi yanlış.</asp:RegularExpressionValidator>
        <br />
        E-Posta:<asp:TextBox ID="txt_e_posta" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_e_posta" ErrorMessage="E-Posta alanı boş bırakılamaz.">E-Posta alanı boş bırakılamaz.</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_e_posta" ErrorMessage="E-Posta girişi yanlış." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">E-Posta girişi yanlış.</asp:RegularExpressionValidator>
        <br />
        Kullanıcı Adı:<asp:TextBox ID="txt_kullanici_adi" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_kullanici_adi" ErrorMessage="Kullanici adi alanı boş bırakılamaz.">Kullanici adi alanı boş bırakılamaz.</asp:RequiredFieldValidator>
        <br />
        Şifre:<asp:TextBox ID="txt_sifre" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_sifre" ErrorMessage="Şifre alanı boş bırakılamaz.">Şifre alanı boş bırakılamaz.</asp:RequiredFieldValidator>
        <br />
        Yetki:<asp:RadioButtonList ID="yetki" runat="server">
            <asp:ListItem Value="1">Yönetici</asp:ListItem>
            <asp:ListItem Value="2">Personel</asp:ListItem>
            <asp:ListItem Value="3">Site Sakini</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="yetki" ErrorMessage="Yetki seçilmelidir.">Yetki seçilmelidir.</asp:RequiredFieldValidator>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" />
    </form>
</asp:Content>

