<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="uye_giris.aspx.cs" Inherits="frontend_uye_giris" MasterPageFile="~/frontend/master/front.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="row margin-bottom-40">
          <!-- BEGIN CONTENT -->
          <div class="col-md-9 col-sm-9">
            <h1>Giriş</h1>
            <div class="content-form-page">
              <div class="row">
                <div class="col-md-7 col-sm-7">
                      <form id="form1" runat="server" class="form-horizontal form-without-legend">
                    <div class="form-group">
                      <label for="email" class="col-lg-4 control-label">Kullanıcı Adı <span class="require">*</span></label>
                      <div class="col-lg-8">
                        <asp:TextBox ID="txbKullanici"  runat="server" CssClass="form-control"></asp:TextBox>
                      </div>
                    </div>
                    <div class="form-group">
                      <label for="password" class="col-lg-4 control-label">Parola <span class="require">*</span></label>
                      <div class="col-lg-8">
                        <asp:TextBox ID="txbSifre" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-lg-8 col-md-offset-4 padding-left-0">
                        <a href="#">Şifremi Unuttum</a>
                      </div>
                    </div>
                    <div class="row">
                      <div class="col-lg-8 col-md-offset-4 padding-left-0 padding-top-20">
                        <asp:Button ID="btGirisYap" runat="server" Text="Giriş Yap" OnClick="btGirisYap_Click" CssClass="btn btn-primary" /> 
                          <asp:Label ID="lbMesaj" runat="server" Text=""></asp:Label>
                      </div>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- END CONTENT -->
        </div>
        <!-- END SIDEBAR & CONTENT -->
</asp:Content>

