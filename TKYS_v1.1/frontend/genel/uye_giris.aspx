<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="uye_giris.aspx.cs" Inherits="frontend_uye_giris" MasterPageFile="~/frontend/master/front.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
   <form id="form1" runat="server">
     <div >
        <div >
            Kullanıcı Adı: 
        </div>
        <div >
            <asp:TextBox ID="txbKullanici"  runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID="rqvKullanici" ControlToValidate="txbKullanici" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
        </div>
    </div>
    <div >
        <div >
           Şifreniz: 
        </div>
        <div >
            <asp:TextBox ID="txbSifre" runat="server" TextMode="Password"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID="rqvSifre" ControlToValidate="txbSifre" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>--%>
        </div>
    </div>
    <div >
        <asp:Button ID="btGirisYap" runat="server" Text="Giriş Yap" OnClick="btGirisYap_Click" /> 
        <asp:Label ID="lbMesaj" runat="server" Text=""></asp:Label>
    </div>
    <div >
        <a href="SifremiUnuttum.aspx">Şifremi Unuttum</a>
    </div>
       </form>
</asp:Content>

