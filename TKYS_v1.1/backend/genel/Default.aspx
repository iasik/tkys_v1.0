<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="backend_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="page_title" Runat="Server">
    <h1>Gösterge Paneli<small> Genel İstatistiksel Veriler</small></h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
    <div class="row">
        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-12">
            <div class="dashboard-stat blue-madison">
                <div class="visual">
                    <i class="fa fa-comments"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <%Response.Write(site_sakini_sayisi); %>
                    </div>
                    <div class="desc">
                        Site Sakini
                    </div>
                </div>
                <a class="more" href="#">Daha fazlası <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-12">
            <div class="dashboard-stat red-intense">
                <div class="visual">
                    <i class="fa fa-bar-chart-o"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <%Response.Write(gelir+" TL"); %>
                    </div>
                    <div class="desc">
                        Gelirler Toplamı
                    </div>
                </div>
                <a class="more" href="#">Daha Fazlası <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-12">
            <div class="dashboard-stat green-haze">
                <div class="visual">
                    <i class="fa fa-shopping-cart"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <%Response.Write(gider + " TL"); %>
                    </div>
                    <div class="desc">
                        Giderler Toplamı
                    </div>
                </div>
                <a class="more" href="#">Daha Fazlası <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-6 col-xs-12">
            <div class="dashboard-stat purple-plum">
                <div class="visual">
                    <i class="fa fa-globe"></i>
                </div>
                <div class="details">
                    <div class="number">
                        <%Response.Write(para_durumu + " TL"); %>
                    </div>
                    <div class="desc">
                        Para Durumu
                    </div>
                </div>
                <a class="more" href="#">Daha fazlası <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>
    </div>
    <!-- END DASHBOARD STATS -->
    <div class="row">
        <div class="col-md-12 col-sm-6">
            <div class="portlet light ">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="icon-cursor font-purple-intense hide"></i>
                        <span class="caption-subject font-purple-intense bold uppercase">Genel İstatistikler</span>
                    </div>
                    <div class="actions">
                    </div>
                </div>
                <div class="portlet-body">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="easy-pie-chart">
                                <div class="number transactions" data-percent="55">
                                    <span>
                                        <%Response.Write(site_sakini_sayisi);%></span>

                                </div>
                                <a class="title" href="#">Site Sakini<i class="icon-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                        <div class="margin-bottom-10 visible-sm">
                        </div>
                        <div class="col-md-4">
                            <div class="easy-pie-chart">
                                <div class="number visits" data-percent="85">
                                    <span>
                                        <%Response.Write(etkinlik_sayisi); %> </span>
                                </div>
                                <a class="title" href="#">Son Etkinlikler <i class="icon-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                        <div class="margin-bottom-10 visible-sm">
                        </div>
                        <div class="col-md-4">
                            <div class="easy-pie-chart">
                                <div class="number bounce" data-percent="46">
                                    <span>
                                        <%Response.Write(is_sayisi); %> </span>

                                </div>
                                <a class="title" href="#">Son İşler <i class="icon-arrow-right"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6 col-sm-6">
            <div class="portlet light ">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="icon-share font-blue-steel hide"></i>
                        <span class="caption-subject font-blue-steel bold uppercase">Son 10 Kullanıcı</span>
                    </div>
                    <div class="actions">
                        
                    </div>
                </div>
                <div class="portlet-body">
                    <div class="scroller" style="height: 300px;" data-always-visible="1" data-rail-visible="0">
                        <ul class="feeds">
                            <asp:Repeater ID="rpt_son_uyeler" runat="server" ItemType="Entity.kullanici">
                                <ItemTemplate>
                                    <li>
                                        <div class="col1">
                                            <div class="cont">
                                                <div class="cont-col1">
                                                    <div class="label label-sm <%#Item.yetki=="2"? "label-warning":"label-info" %>">
                                                        <i class="<%#Item.id%2==0? "fa fa-user":"fa fa-plus" %>"></i>
                                                    </div>
                                                </div>
                                                <div class="cont-col2">
                                                    <div class="desc">
                                                        <%#Item.kullanici_adi+"  "+Item.ad + " " + Item.soyad %>  
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col2">
                                            <div class="date">
                                                <%#Item.yetki%>
                                            </div>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                        </ul>
                    </div>
                    <div class="scroller-footer">
                        <div class="btn-arrow-link pull-right">
                            <a href="#">Tüm Kayıtları Gör</a>
                            <i class="icon-arrow-right"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-sm-6">
            <div class="portlet light ">
                <div class="portlet-title">
                    <div class="caption">
                        <i class="icon-share font-blue-steel hide"></i>
                        <span class="caption-subject font-blue-steel bold uppercase">Son 10 Etkinlik</span>
                    </div>
                    <div class="actions">
                        
                    </div>
                </div>
                <div class="portlet-body">
                    <div class="scroller" style="height: 300px;" data-always-visible="1" data-rail-visible="0">
                        <ul class="feeds">
                            <asp:Repeater ID="rtp_son_etkinliker" runat="server" ItemType="Entity.etkinlik">
                                <ItemTemplate>
                                    <li>
                                        <div class="col1">
                                            <div class="cont">
                                                <div class="cont-col1">
                                                    <div class="label label-sm label-info">
                                                        <i class="fa fa-paper-plane"></i>
                                                    </div>
                                                </div>
                                                <div class="cont-col2">
                                                    <div class="desc">
                                                        <%#Item.ad + " " + Item.detay + " " + Item.kullanici.ad %>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col2">
                                            <div class="date">
                                                <%#Item.tarih%>
                                            </div>
                                        </div>
                                    </li>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                        </ul>
                    </div>
                    <div class="scroller-footer">
                        <div class="btn-arrow-link pull-right">
                            <a href="#">Tüm Kayıtları Gör</a>
                            <i class="icon-arrow-right"></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>

