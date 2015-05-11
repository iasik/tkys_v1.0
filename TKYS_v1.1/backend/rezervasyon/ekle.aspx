<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_rezervasyon_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        Ad:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad kısmı doldurulmalıdır.">Ad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
        <br />
        Detay:<asp:TextBox ID="txt_detay" runat="server"></asp:TextBox>
        <br />
        Sosyal Tesis Seç:<asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Seçim yapılmalıdır.">Seçim yapılmalıdır.</asp:RequiredFieldValidator>
        <br />
        Kullanıcı Seç:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Seçim yapılmalıdır.">Seçim yapılmalıdır.</asp:RequiredFieldValidator>
        <br />
    <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" />
    </form>
</asp:Content>

