<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_isler_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        İş Adı:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad bölümü doldurulmalıdır.">Ad bölümü doldurulmalıdır.</asp:RequiredFieldValidator>
                                <br />
        İş Detayı:<asp:TextBox ID="txt_detay" runat="server"></asp:TextBox><br />
        İş Türü:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList1" ErrorMessage="İş türünü seçiniz.">İş türünü seçiniz.</asp:RequiredFieldValidator>
        <br />
        İşi Yapacak Personel:<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Personel seçiniz.">Personel seçiniz.</asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" />
    </form>
</asp:Content>

