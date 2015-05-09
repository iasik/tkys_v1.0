<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="listele.aspx.cs" Inherits="backend_gelir_listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <table class="table table-striped table-hover" id="sample_5">
        <thead>
            <tr>
                <th>id
                </th>
                <th>Ad
                </th>
                <th class="hidden-xs">Miktar
                </th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rpt_gelir" runat="server" ItemType="Entity.gelir">
                <ItemTemplate>
                    <tr>
                        <td><%#Item.id %>
                        </td>
                        <td><%#Item.ad %>
                        </td>
                        <td><%#Item.miktar %>
                        </td>
                        <td>
                            <a href="guncelle.aspx?id=<%#Item.id %>">Güncelle</a>
                            <a href="sil.aspx?id=<%#Item.id %>">Sil</a>
                        </td> 
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

