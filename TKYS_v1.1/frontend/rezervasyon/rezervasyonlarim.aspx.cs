using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_rezervasyon_rezervasyonlarim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Rezervasyonlarim();
    }

    public void Rezervasyonlarim()
    {
        rezervasyon_vt rezervasyon = new rezervasyon_vt();
        var sonuc = rezervasyon.ListeleID(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);
        if (sonuc.basarili_mi)
        {
            rpt_Rezervasyonum.DataSource = sonuc.veri;
            rpt_Rezervasyonum.DataBind();
        }
        else
        {

        }


    }
}