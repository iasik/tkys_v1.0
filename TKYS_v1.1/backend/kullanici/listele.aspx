<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="listele.aspx.cs" Inherits="backend_kullanici_listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link rel="stylesheet" type="text/css" href="../../theme/assets/backend/plugins/select2/select2.css"/>
        <link rel="stylesheet" type="text/css" href="../../theme/assets/backend/plugins/datatables/extensions/Scroller/css/dataTables.scroller.min.css"/>        <link rel="stylesheet" type="text/css" href="../../theme/assets/backend/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.css"/>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="page_title" Runat="Server">
    <h1>Kullanıcı <small> Listeleme işlemi</small></h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
        <div class="portlet light">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-cogs font-green-sharp"></i>
                <span class="caption-subject font-green-sharp bold uppercase">Scroller</span>
            </div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
                <a href="#portlet-config" data-toggle="modal" class="config"></a>
                <a href="javascript:;" class="reload"></a>
                <a href="javascript:;" class="remove"></a>
            </div>
        </div>
        <div class="portlet-body">
            <table class="table table-striped table-hover" id="sample_5">
                <thead>
                    <tr>

                        <th class="table-checkbox">
                            <input type="checkbox" class="group-checkable" data-set="#sample_5 .checkboxes" />
                        </th>
                        <th>id
                        </th>
                        <th>Ad
                        </th>
                        <th>Soyad
                        </th>
                        <th>Cinsiyet
                        </th>
                        <th>Telefon
                        </th>
                        <th>Eposta
                        </th>
                        <th>Kullanıcı Ad
                        </th>
                        <th>Şifre
                        </th>
                        <th>Yetki
                        </th>
                        <th style="float:right;"">İşlemler
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rpt_kullanici" runat="server" ItemType="Entity.kullanici">
                        <ItemTemplate>
                            <tr>

                                <td>
                                    <input type="checkbox" class="checkboxes" value="1" />
                                </td>

                                <td><%#Item.id %>
                                </td>
                                <td><%#Item.ad %>
                                </td>
                                <td><%#Item.soyad %>
                                </td>
                                <td><%#Item.cinsiyet%>
                                </td>
                                <td><%#Item.cep_telefonu%>
                                </td>
                                <td><%#Item.e_posta%>
                                </td>
                                <td><%#Item.kullanici_adi%>
                                </td>
                                <td><%#Item.sifre%>
                                </td>
                                <td><%#Item.yetki%>
                                </td>
                                <td style="float: right;">
                                    <div class="btn-group btn-group-circle btn-group-solid btn-group-xs">
                                        <a class="btn blue-madison" href="goruntule.aspx?id=<%#Item.id %>" title="View">
                                            <i class="fa fa-user"></i>
                                            Bak
                                        </a>
                                        <a class="btn green-seagreen" href="guncelle.aspx?id=<%#Item.id %>&?cinsiyet=<%#Item.cinsiyet %>&yetki=<%#Item.yetki %>" title="Update">
                                            <i class="fa fa-cogs"></i>
                                            Güncelle
                                        </a>
                                        <a class="btn grey-cascade" href="sil.aspx?id=<%#Item.id %>" title="Delete" data-confirm="Silinsin mi?">
                                            <i class="fa fa-bullhorn"></i>
                                            Sil
                                        </a>
                                    </div>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" Runat="Server">
    <script type="text/javascript" src="../../theme/assets/backend/plugins/select2/select2.min.js"></script>
    <script type="text/javascript" src="../../theme/assets/backend/plugins/datatables/media/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="../../theme/assets/backend/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js"></script>    <script type="text/javascript" src="../../theme/assets/backend/plugins/datatables/extensions/ColReorder/js/dataTables.colReorder.min.js"></script>    <script type="text/javascript" src="../../theme/assets/backend/plugins/datatables/extensions/Scroller/js/dataTables.scroller.min.js"></script>
    <script type="text/javascript" src="../../theme/assets/backend/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js"></script>    <script src="../../theme/assets/backend/js/table-advanced.js"></script>   <script>
       jQuery(document).ready(function () {
           TableAdvanced.init();
       });
   </script> 
</asp:Content>





