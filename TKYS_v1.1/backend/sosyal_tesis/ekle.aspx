<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_sosyal_tesis_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad bölümü doldurulmalıdır.">Ad bölümü doldurulmalıdır.</asp:RequiredFieldValidator>
        <br />
        Kapasite:<asp:TextBox ID="txt_kapasite" runat="server" TextMode="Number"></asp:TextBox>
        <br />
    <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" />
    </form>
</asp:Content>


