using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UyeVeritabani uye = new UyeVeritabani();
        kullanici k1 = new kullanici();
        k1.ad = ad.Text;
        k1.soyad = soyad.Text;
        k1.cinsiyet = true;
        k1.cep_telefonu =cep_tel.Text;
        k1.e_posta= posta.Text;
        k1.kullanici_adi = kullanici.Text;
        k1.sifre = sifre.Text;
        k1.yetki = "1";


        var islem = uye.UyeOl(k1);
        if (islem.BasariliMi)
            Label1.Text = "Good job boyy.. :D";
        else
            Label1.Text = "olmadı be .s";
    }
}