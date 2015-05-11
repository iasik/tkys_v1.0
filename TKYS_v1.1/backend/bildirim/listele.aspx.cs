using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_bildirim_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        bildirim_vt bildirimvt = new bildirim_vt();
        var sonuc = bildirimvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_bildirim.DataSource = sonuc.veri;
            rpt_bildirim.DataBind();
        }
        else
        {
            bildirim veri = new bildirim();
            veri.id = 0;
            veri.ad = "bos";
            veri.detay = "bos";
            veri.kullanici_id = 0;

            rpt_bildirim.DataSource = veri;
            rpt_bildirim.DataBind();
        }
    }
}