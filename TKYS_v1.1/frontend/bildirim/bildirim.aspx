<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="bildirim.aspx.cs" Inherits="frontend_bildirim_bildirim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">

    <asp:Repeater ID="rpt_Bildirim" runat="server" ItemType="Entity.bildirim">

        <ItemTemplate>
              
                                <td><%#Item.id %>
                                </td>
                                <td><%#Item.ad %>
                                </td>
                                <td><%#Item.detay %>
                                </td>

        </ItemTemplate>
    </asp:Repeater>


</asp:Content>

