using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_isler_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        is_vt isturuvt = new is_vt();
        var sonuc = isturuvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_isler.DataSource = sonuc.veri;
            rpt_isler.DataBind();
        }
        else
        {
            isler veri = new isler();
            veri.ad = "boş";
            veri.detay = "boş";
            veri.id = 0;
            veri.is_turu = 0;
            veri.kullanici_id = 0;
            rpt_isler.DataSource = veri;
            rpt_isler.DataBind();
        }
    }
}