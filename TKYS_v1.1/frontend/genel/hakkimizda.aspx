<%@ Page Title="" Language="C#" MasterPageFile="~/frontend/master/front.master" AutoEventWireup="true" CodeFile="hakkimizda.aspx.cs" Inherits="frontend_genel_hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="Server">
    <div class="main">
        <div class="container">
            <ul class="breadcrumb">
                <li><a href="default.aspx">Anasayfa</a></li>
                <li class="active">Hakkımızda</li>
            </ul>
            <!-- BEGIN SIDEBAR & CONTENT -->
            <div class="row margin-bottom-40">
                <!-- BEGIN CONTENT -->
                <div class="col-md-12 col-sm-12">
                    <h1>Hakkimizda</h1>
                    <div class="content-page">
                        <div class="row margin-bottom-30">
                            <!-- BEGIN INFO BLOCK -->
                            <div class="col-md-7">
                                <p>Site, rezidans, iş merkezi, plaza ve AVM gibi tüm toplu yapı yönetimlerine ve profesyonel tesis yönetim firmalarına web tabanlı yönetim yazılımı hizmeti veren Apsiyon’un temelleri 2009 yılında atıldı. Toplu yapı yönetimlerinde karşılaşılan sıkıntılara çözüm için yola çıkan üç kurucu ortağın özverili çalışmalarıyla 2010 yılında açılan www.apsiyon.com, 2012 yılında Türkiye’de yatırım yapılmaya değer en iyi 15 internet girişiminden biri seçilerek yatırımcıların dikkatini çekmeyi başardı.</p>
                                <p>Kısa sürede, Türkiye’nin en köklü ve hızlı büyüyen şirketlerinden biri olan Yıldırım Holding’den aldığı yatırımla finansal olarak güçlenen Apsiyon, Kat Mülkiyeti Kanunu hükümleri doğrultusunda hazırlanmış, kolay anlaşılır ve entegre çözümleriyle, yönetimlere sorunsuz ve hızlı hizmet sağlayarak güçlü referanslar edinmiştir.</p>
                                <p>Apsiyon, klasik muhasebe programlarının ötesinde bütün enerjisini yönetimlerin ihtiyaçlarına yönlendiren tek çözüm olarak, genç ve dinamik kadrosuyla hizmet vermeye ve sektörün öncülüğünü yapmaya devam etmektedir.</p>
                            </div>
                            <!-- END INFO BLOCK -->

                            <!-- BEGIN CAROUSEL -->
                            <div class="col-md-5 front-carousel">
                                <div id="myCarousel" class="carousel slide">
                                    <!-- Carousel items -->
                                    <div class="carousel-inner">
                                        <div class="item active">
                                            <img src="../../theme/assets/frontend/img/pics/img2-medium.jpg" alt="">
                                            <div class="carousel-caption">
                                                <p>Excepturi sint occaecati cupiditate non provident</p>
                                            </div>
                                        </div>
                                        <div class="item">
                                            <img src="../../theme/assets/frontend/img/pics/img1-medium.jpg" alt="">
                                            <div class="carousel-caption">
                                                <p>Ducimus qui blanditiis praesentium voluptatum</p>
                                            </div>
                                        </div>
                                        <div class="item">
                                            <img src="../../theme/assets/frontend/img/pics/img2-medium.jpg" alt="">
                                            <div class="carousel-caption">
                                                <p>Ut non libero consectetur adipiscing elit magna</p>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Carousel nav -->
                                    <a class="carousel-control left" href="#myCarousel" data-slide="prev">
                                        <i class="fa fa-angle-left"></i>
                                    </a>
                                    <a class="carousel-control right" href="#myCarousel" data-slide="next">
                                        <i class="fa fa-angle-right"></i>
                                    </a>
                                </div>
                            </div>
                            <!-- END CAROUSEL -->
                        </div>

                        <div class="row recent-work margin-bottom-40">

                            <div class="col-md-12">
                                <div class="owl-carousel owl-carousel7">
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/mert.jpg">
                                            <h3>
                                                <strong>Mert Çeltikoğlu</strong>
                                                <small>Ceo</small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/ibrahim.jpg">
                                            <h3>
                                                <strong>İbrahim Aşık</strong>
                                                <small>Frontend Developer
                                                </small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/kerem.jpg">
                                            <h3>
                                                <strong>Kerem Kaya</strong>
                                                <small>Backend Developer</small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/taylan.jpg">
                                            <h3>
                                                <strong>Taylan İçgen</strong>
                                                <small>Backend Developer</small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/gizem.jpg">
                                            <h3>
                                                <strong>Gizem Göklüoğlu</strong>
                                                <small>Reporter</small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="recent-work-item">
                                        <div class="thumbnail">
                                            <img alt="" src="../../theme/assets/frontend/img/people/img1-large.jpg">
                                            <h3>
                                                <strong>Lina Doe</strong>
                                                <small>Reporter</small>
                                            </h3>
                                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, justo sit amet risus etiam porta sem...</p>
                                            <ul class="social-icons social-icons-color">
                                                <li><a class="facebook" data-original-title="Facebook" href="#"></a></li>
                                                <li><a class="twitter" data-original-title="Twitter" href="#"></a></li>
                                                <li><a class="googleplus" data-original-title="Goole Plus" href="#"></a></li>
                                                <li><a class="linkedin" data-original-title="Linkedin" href="#"></a></li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END CONTENT -->
            </div>
            <!-- END SIDEBAR & CONTENT -->
        </div>
    </div>

</asp:Content>

