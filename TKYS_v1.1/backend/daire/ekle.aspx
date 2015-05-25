<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_daire_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="page_title" Runat="Server">
    <h1>Daire <small> Ekleme işlemi</small></h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
    <div class="portlet light">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-cogs font-green-sharp"></i>
                <span class="caption-subject font-green-sharp bold uppercase">Daire Formu</span>
            </div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
                <a href="#portlet-config" data-toggle="modal" class="config"></a>
                <a href="javascript:;" class="reload"></a>
                <a href="javascript:;" class="remove"></a>
            </div>
        </div>
        <div class="portlet-body">
            <form id="form" runat="server" class="form-horizontal">
                <div class="form-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Blok:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_blok" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_blok" ErrorMessage="Bu bölüm boş bırakılamaz.">Bu bölüm boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Kat:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_kat" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                    <asp:RequiredFieldValidator class="help-block" ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_kat" ErrorMessage="Kat Bu bölüm boş bırakılamaz.">Bu bölüm boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Daire No:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_daire_no" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator12" runat="server" ControlToValidate="txt_daire_no" ErrorMessage="Bu bölüm boş bırakılamaz.">Bu bölüm boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Daire Genişliği(m2):</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_daire_genisligi" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator13" runat="server" ControlToValidate="txt_daire_genisligi" ErrorMessage="Bu bölüm boş bırakılamaz.">Bu bölüm boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Kullanıcı:</label>

                                <div class="col-md-8">
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator9" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Kullanıcı kısmı seçilmelidir.">Kullanıcı kısmı seçilmelidir.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-actions">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-offset-4 col-md-9">
                                        <asp:Button ID="btn_ekle" runat="server" Text="Button" OnClick="btn_ekle_Click" class="btn green" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
