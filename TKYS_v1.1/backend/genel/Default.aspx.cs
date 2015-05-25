using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_Default : System.Web.UI.Page
{
    protected int daire_sayisi = 0;
    protected int site_sakini_sayisi = 0;
    protected int gelir = 0;
    protected int gider = 0;
    protected int para_durumu = 0;
    protected int etkinlik_sayisi = 0;
    protected int is_sayisi = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        daire();
        giderler();
        gelirler();
        site_sakini();
        para();
        isler();
        etkinlikler();
    }

    protected void daire()
    {
        daire_vt daire = new daire_vt();
        var sonuc = daire.Listele();
        if(sonuc.basarili_mi)
        {
            daire_sayisi = sonuc.veri.Count();
        }
    }

    protected void giderler()
    {
        gider_vt gidervt = new gider_vt();
        var sonuc = gidervt.Listele();
        if(sonuc.basarili_mi)
        {
            foreach(var veri in sonuc.veri)
            {
                gider += Convert.ToInt32(veri.miktar);
            }

        }
    }

    protected void gelirler()
    {
        gelir_vt gelirvt = new gelir_vt();
        var sonuc = gelirvt.Listele();
        if (sonuc.basarili_mi)
        {
            foreach (var veri in sonuc.veri)
            {
                gelir += Convert.ToInt32(veri.miktar);
            }

        }
    }

    protected void site_sakini()
    {
        kullanici_vt kullanicivt = new kullanici_vt();
        var sonuc = kullanicivt.site_sakini_listele();
        if(sonuc.basarili_mi)
        {
            site_sakini_sayisi = sonuc.veri.Count();
        }
        var kullanicilar = kullanicivt.son_kayitlar();
        if(kullanicilar.basarili_mi)
        {
            rpt_son_uyeler.DataSource = kullanicilar.veri;
            rpt_son_uyeler.DataBind();
        }
    }

    protected void para()
    {
        para_durumu = gelir - gider;
    }

    protected void isler()
    {
        is_vt isvt = new is_vt();
        var sonuc = isvt.Listele();
        if(sonuc.basarili_mi)
        {
            is_sayisi = sonuc.veri.Count();
        }
    }
    protected void etkinlikler()
    {
        etkinlik_vt etkinlikvt = new etkinlik_vt();
        var sonuc = etkinlikvt.Listele();
        if (sonuc.basarili_mi)
        {
            etkinlik_sayisi = sonuc.veri.Count();
        }
        var etkinlikler = etkinlikvt.son_kayitlar();
        if(etkinlikler.basarili_mi)
        {
            rtp_son_etkinliker.DataSource = etkinlikler.veri;
            rtp_son_etkinliker.DataBind();
        }

    }


}