<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_isler_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <form id="form" runat="server">
        İş Adı:<asp:TextBox ID="txt_ad" runat="server"></asp:TextBox><br />
        İş Detayı:<asp:TextBox ID="txt_detay" runat="server"></asp:TextBox><br />
        İş Türü:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
        İşi Yapacak Personel:<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" />
    </form>
</asp:Content>

