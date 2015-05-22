using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_bildirim_bildirim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BildirimleriListele();
    }

    public void BildirimleriListele() {
        bildirim_vt bildirim = new bildirim_vt();
       var sonuc = bildirim.Kullanici_Bildirim(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);
        if (sonuc.basarili_mi)
        {
            rpt_Bildirim.DataSource = sonuc.veri;
            rpt_Bildirim.DataBind();
        }
        else
        {
           
        }

    
    }
}