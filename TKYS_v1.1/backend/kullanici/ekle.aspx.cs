using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_kullanici_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        kullanici_vt kullanicivt = new kullanici_vt();
        kullanici_bilgisi yeni_kullanici = new kullanici_bilgisi();

        yeni_kullanici.ad = txt_ad.Text;
        yeni_kullanici.soyad = txt_soyad.Text;
        if (cinsiyet.SelectedValue=="0")
        {
            yeni_kullanici.cinsiyet = false;
        }
        else
        {
            yeni_kullanici.cinsiyet = true;
        }
        yeni_kullanici.cep_telefonu = txt_cep_telefonu.Text;
        yeni_kullanici.e_posta = txt_e_posta.Text;
        yeni_kullanici.kullanici_adi = txt_kullanici_adi.Text;
        yeni_kullanici.sifre = txt_sifre.Text;
        if (yetki.SelectedValue=="1")
        {
            yeni_kullanici.yetki = UyeTip.yonetici;
        }
        else if (yetki.SelectedValue == "2")
        {
            yeni_kullanici.yetki = UyeTip.personel;
        }
        else
        {
            yeni_kullanici.yetki = UyeTip.site_sakini;
        }

       // Label1.Text = yeni_kullanici.ad + "-" + yeni_kullanici.soyad + "-" + yeni_kullanici.cinsiyet + "-" + yeni_kullanici.e_posta + "-" + yeni_kullanici.cep_telefonu + "-" + yeni_kullanici.kullanici_adi + "-" + yeni_kullanici.sifre + "-" + yeni_kullanici.yetki;
        
        var sonuc = kullanicivt.Ekle(yeni_kullanici);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}