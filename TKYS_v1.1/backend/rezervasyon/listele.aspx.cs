using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_rezervasyon_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        rezervasyon_vt rezervasyonvt = new rezervasyon_vt();
        var sonuc = rezervasyonvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_rezervasyon.DataSource = sonuc.veri;
            rpt_rezervasyon.DataBind();
        }
        else
        {
            rezervasyon veri = new rezervasyon();
            veri.id = 0;
            veri.ad = "bos";
            veri.detay = "bos";
            veri.sosyal_tesis_id = 0;
            veri.kullanici_id = 0;

            rpt_rezervasyon.DataSource = veri;
            rpt_rezervasyon.DataBind();
        }
    }
}