using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_etkinlik_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        etkinlik_vt etkinlikvt = new etkinlik_vt();
        var sonuc = etkinlikvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_etkinlik.DataSource = sonuc.veri;
            rpt_etkinlik.DataBind();
        }
        else
        {
            etkinlik veri = new etkinlik();
            veri.id = 0;
            veri.ad = "bos";
            veri.detay = "bos";
            veri.tarih = System.DateTime.Now;//şuanki zamanı ekledik
            veri.kullanici_id = 0;
            rpt_etkinlik.DataSource = veri;
            rpt_etkinlik.DataBind();
        }
    }
}