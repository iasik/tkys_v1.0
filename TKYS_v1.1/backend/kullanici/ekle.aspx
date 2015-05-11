<%@ Page Title="" Language="C#" MasterPageFile="~/backend/master/backend.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="backend_kullanici_ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
    <div class="portlet light">
        <div class="portlet-title">
            <div class="caption">
                <i class="fa fa-cogs font-green-sharp"></i>
                <span class="caption-subject font-green-sharp bold uppercase">Kullanıcı Formu</span>
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
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ad" ErrorMessage="Ad kısmı doldurulmalıdır." CssClass="help-block ">Ad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Soyad:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_soyad" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator class="help-block" ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_soyad" ErrorMessage="Soyad kısmı doldurulmalıdır.">Soyad kısmı doldurulmalıdır.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Cinsiyet:</label>
                                <div class="col-md-8">
                                    <asp:RadioButtonList ID="cinsiyet" runat="server" CssClass="radio-list">
                                        <asp:ListItem Value="0">Bay</asp:ListItem>
                                        <asp:ListItem Value="1">Bayan</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator class="help-block" ID="RequiredFieldValidator3" runat="server" ControlToValidate="cinsiyet" ErrorMessage="Cinsiyet seçilmelidir.">Cinsiyet seçilmelidir.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Cep Telefonu:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_cep_telefonu" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_cep_telefonu" ErrorMessage="Telefon alanı boş bırakılamaz.">Telefon alanı boş bırakılamaz.</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator CssClass="help-block" ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_cep_telefonu" ErrorMessage="Cep telefon girişi yanlış." ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">Cep telefon girişi yanlış.</asp:RegularExpressionValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">E-Posta:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_e_posta" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_e_posta" ErrorMessage="E-Posta alanı boş bırakılamaz.">E-Posta alanı boş bırakılamaz.</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator CssClass="help-block" ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_e_posta" ErrorMessage="E-Posta girişi yanlış." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">E-Posta girişi yanlış.</asp:RegularExpressionValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Kullanıcı Adı:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_kullanici_adi" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_kullanici_adi" ErrorMessage="Kullanici adi alanı boş bırakılamaz.">Kullanici adi alanı boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Şifre:</label>
                                <div class="col-md-8">
                                    <asp:TextBox ID="txt_sifre" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator class="help-block" ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_sifre" ErrorMessage="Şifre alanı boş bırakılamaz.">Şifre alanı boş bırakılamaz.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label col-md-2">Yetki:</label>
                                <div class="col-md-8">
                                    <asp:RadioButtonList ID="yetki" runat="server" CssClass="radio-list">
                                        <asp:ListItem Value="1">Yönetici</asp:ListItem>
                                        <asp:ListItem Value="2">Personel</asp:ListItem>
                                        <asp:ListItem Value="3">Site Sakini</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator CssClass="help-block" ID="RequiredFieldValidator6" runat="server" ControlToValidate="yetki" ErrorMessage="Yetki seçilmelidir.">Yetki seçilmelidir.</asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-actions">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-offset-4 col-md-9">
                                        <asp:Button class="btn green" ID="btn_ekle" runat="server" Text="Ekle" OnClick="btn_ekle_Click" />
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

