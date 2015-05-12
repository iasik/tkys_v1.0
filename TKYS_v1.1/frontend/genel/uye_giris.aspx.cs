using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_uye_giris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btGirisYap_Click(object sender, EventArgs e)
    {

        kullanici_vt uye = new kullanici_vt();
        var sonuc = uye.Giris(txbKullanici.Text, txbSifre.Text);
        if (sonuc.basarili_mi)//giriş yapıldıysa yönlendir...
        {
            lbMesaj.Text = "Kullanıcı Girişi yapıldı.";
            Session[SiteTanim.KullaniciSession] = sonuc.veri;
            Response.Redirect("Default.aspx");
            /*if(sonuc.veri.yetki==UyeTip.site_sakini)
                Response.Redirect("Default.aspx");
            else
                Response.Redirect("../backend/Default.aspx");*/
        }
        else
        {
            if (sonuc.hata_bilgi != null)
            {
                lbMesaj.Text = "Bir hata oluştu";
            }
            else
            {
                lbMesaj.Text = sonuc.mesaj;
            }
        }
    
    }
}