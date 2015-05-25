<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="guncelle.aspx.cs" Inherits="backend_rezervasyon_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="page_title" Runat="Server">
    <h1>Rezervasyon <small> Güncelleme işlemi</small></h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
        <div class="portlet light">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-cogs font-green-sharp"></i>
                <span class="caption-subject font-green-sharp bold uppercase">Gider Formu</span>
            </div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
                <a href="#portlet-config" data-toggle="modal" class="config"></a>
                <a href="javascript:;" class="reload"></a>
                <a href="javascript:;" class="remove"></a>
            </div>
        </div>
        <div class="portlet-body">
            <form id="form1" runat="server" class="form-horizontal">
                <div class="form-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Ad:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_ad" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad kısmı doldurulmalıdır.">Ad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Detay:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_detay" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Sosyal Tesis:</label>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Seçim yapılmalıdır.">Seçim yapılmalıdır.</asp:RequiredFieldValidator>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Ad:</label>
                                <div class="col-md-8">
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Seçim yapılmalıdır.">Seçim yapılmalıdır.</asp:RequiredFieldValidator>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-actions">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-offset-4 col-md-9">
                                        <asp:Button ID="btn_guncelle" runat="server" Text="Button" OnClick="btn_guncelle_Click" CssClass="btn red" />
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

