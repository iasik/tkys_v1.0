<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="frontend_genel_iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="main">
      <div class="container">
        <ul class="breadcrumb">
            <li><a href="default.aspx">Anasayfa</a></li>
            <li class="active">İletisim</li>
        </ul>
        <div class="row margin-bottom-40">
          <!-- BEGIN CONTENT -->
          <div class="col-md-12">
            <h1>İletişim</h1>
            <div class="content-page">
              <div class="row">
                <div class="col-md-12">
                  <div id="map" class="gmaps margin-bottom-40" style="height:400px;"></div>
                </div>
                <div class="col-md-9 col-sm-9">
                  <h2>İletişim Formu</h2>
                  <p>Lorem ipsum dolor sit amet, Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat consectetuer adipiscing elit, sed diam nonummy nibh euismod tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>
                  
                  <!-- BEGIN FORM-->
                  <form action="#" role="form" runat="server">
                    <div class="form-group">
                      <label for="contacts-name">İsim</label>
                        <asp:TextBox ID="txt_ad" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                      <label for="contacts-email">Eposta</label>
                       <asp:TextBox ID="txt_posta" runat="server" TextMode="Email" class="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                      <label for="contacts-message">Mesaj</label>
                      <asp:TextBox ID="txt_mesaj" runat="server" class="form-control" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </div>
                      <asp:Button ID="btn_gonder" runat="server" Text="Gönder" class="btn btn-primary" OnClick="btn_gonder_Click"/>
                          <asp:Label ID="lbl_hata" runat="server"></asp:Label>
                  </form>
                  <!-- END FORM-->
                </div>

                <div class="col-md-3 col-sm-3 sidebar2">
                  <h2>Our Contacts</h2>
                  <address>
                      <b>Kocaeli Muhendislik Fakultesi.</b> Kocaeli Universitesi Umut Tepe Yerleskesi 41380 Izmit/Kocaeli Turkiye
                    <strong>Muhendislik Fakultesi.</strong><br>
                    Umut Tepe Yerleskesi 41380<br>
                    Izmit/Kocaeli Turkiye<br>
                    <abbr title="Phone">P:</abbr> (234) 145-1810
                  </address>
                  <address>
                    <strong>Eposta</strong><br>
                    <a href="mailto:info@flysoft.com">info@flysoft.com</a><br>
                  </address>
                  <ul class="social-icons margin-bottom-40">
                    <li><a href="#" data-original-title="facebook" class="facebook"></a></li>
                    <li><a href="#" data-original-title="github" class="github"></a></li>
                    <li><a href="#" data-original-title="Goole Plus" class="googleplus"></a></li>
                    <li><a href="#" data-original-title="linkedin" class="linkedin"></a></li>
                    <li><a href="#" data-original-title="rss" class="rss"></a></li>
                  </ul>

                  <h2 class="padding-top-30">Hakkımızda</h2>
                  <p>Sediam nonummy nibh euismod tation ullamcorper suscipit</p>
                  <ul class="list-unstyled">
                    <li><i class="fa fa-check"></i> Officia deserunt molliti</li>
                    <li><i class="fa fa-check"></i> Consectetur adipiscing </li>
                    <li><i class="fa fa-check"></i> Deserunt fpicia</li>
                  </ul>        
                </div>
              </div>
            </div>
          </div>
          <!-- END CONTENT -->
        </div>
      </div>
    </div>
</asp:Content>

