<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="etkinlik.aspx.cs" Inherits="frontend_etkinlik_etkinlik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="portlet">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-gift"></i>Eklinlikler
            </div>
            <div class="col-md-1" style="float:right">
                <a class="btn green" href="ekle.aspx" style="float:right">Ekle</a>
            </div>
            <div class="tools">
                
                <a class="collapse" href="javascript:;"></a>
                <a class="config" data-toggle="modal" href="#portlet-config"></a>
                <a class="reload" href="javascript:;"></a>
                <a class="remove" href="javascript:;"></a>
            </div>
        </div>
        <div class="portlet-body">
            <asp:Repeater ID="rpt_etkinlik" runat="server" ItemType="Entity.etkinlik">

                <ItemTemplate>
                    <div class="alert alert-block alert-success fade in col-md-5" style="text-align:center;margin-right:45px;margin-left:45px;">
                        <button type="button" class="close" data-dismiss="alert"></button>
                        <h4 class="alert-heading"><%#Item.ad %></h4>
                        <p>
                            Düzenleyen:<%#Item.kullanici.ad +" "+ Item.kullanici.soyad %><br />
                            Detay:<%#Item.detay %><br />
                            Tarih:<%#Item.tarih %>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>

