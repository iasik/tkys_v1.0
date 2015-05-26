<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="rezervasyonlarim.aspx.cs" Inherits="frontend_rezervasyon_rezervasyonlarim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">


    <div class="portlet">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-gift"></i>Yapilan Rezervasyon
            </div>
            <div class="tools">
                <a class="collapse" href="javascript:;"></a>
                <a class="config" data-toggle="modal" href="#portlet-config"></a>
                <a class="reload" href="javascript:;"></a>
                <a class="remove" href="javascript:;"></a>
            </div>
        </div>
        <div class="portlet-body">
            <asp:Repeater ID="rpt_Rezervasyonum" runat="server" ItemType="Entity.rezervasyon">
                <ItemTemplate>
                    <div class="alert alert-block alert-danger fade in">
                        <button type="button" class="close" data-dismiss="alert"></button>
                        <p>
                            <%#Item.sosyal_tesis.ad %>
                        </p>
                        <h4 class="alert-heading"><%#Item.ad %></h4>
                        <p>
                            <%#Item.detay %>
                        </p>
                        
                        
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>

