using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class frontend_borc_odeme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["id"]!=null)
        {
            borc_ode(Convert.ToInt32(Request.QueryString["id"]));
        }
    }

    protected void borc_ode(int id)
    {
        borc_vt borc = new borc_vt();
        var sonuc_borc = borc.Bul(id);
        if(sonuc_borc.basarili_mi)
        {
            gelir_vt gelirvt = new gelir_vt();
            gelir gelir_bilgisi = new gelir();
            gelir_bilgisi.ad = ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).ad + " " + ((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).soyad + " " + sonuc_borc.veri.ad;
            gelir_bilgisi.miktar = sonuc_borc.veri.miktar;

            var sonuc_gelir = gelirvt.Ekle(gelir_bilgisi);
            if(sonuc_gelir.basarili_mi)
            {
                var sonuc = borc.Sil(id);
                if(sonuc.basarili_mi)
                {
                    Response.Redirect("borc.aspx");
                }
                else
                    Response.Redirect("hatasayfasi.aspx");
            }
            else
                Response.Redirect("hatasayfasi.aspx");

        }
        else
            Response.Redirect("hatasayfasi.aspx");
    }
}