<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="borc.aspx.cs" Inherits="frontend_borc_borc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="portlet">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-gift"></i>Bildirimler
            </div>
            <div class="tools">
                <a class="collapse" href="javascript:;"></a>
                <a class="config" data-toggle="modal" href="#portlet-config"></a>
                <a class="reload" href="javascript:;"></a>
                <a class="remove" href="javascript:;"></a>
            </div>
        </div>
        <div class="portlet-body">
            <asp:Repeater ID="rpt_borc" runat="server" ItemType="Entity.borc">

                <ItemTemplate>
                    <div class="alert alert-block alert-danger fade in">
                        <button type="button" class="close" data-dismiss="alert"></button>
                        <h4 class="alert-heading"><%#Item.ad %></h4>
                        <p>
                            <%#Item.miktar %>
                        </p>
                        <p>
                            <a class="btn red" href="odeme.aspx?id=<%#Item.id %>">Öde </a>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>

