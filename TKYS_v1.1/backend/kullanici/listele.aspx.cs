using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_kullanici_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        kullanici_vt kullanicivt = new kullanici_vt();
        var sonuc = kullanicivt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_kullanici.DataSource = sonuc.veri;
            rpt_kullanici.DataBind();
        }
        else
        {
            kullanici veri = new kullanici();
            veri.id = 0;
            veri.ad = "bos";
            veri.soyad = "bos";
            veri.cinsiyet = false;
            veri.cep_telefonu = "05XX XXX XX XX";
            veri.e_posta = "bos";
            veri.kullanici_adi = "admin";
            veri.sifre = "admin";
            veri.yetki = "1";

            rpt_kullanici.DataSource = veri;
            rpt_kullanici.DataBind();
        }
    }
}