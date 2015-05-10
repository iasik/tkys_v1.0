using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_gider_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }

    public void listele()
    {
        gider_vt gidervt = new gider_vt();
        var sonuc = gidervt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_gider.DataSource = sonuc.veri;
            rpt_gider.DataBind();
        }
        else
        {
            gelir veri = new gelir();
            veri.ad = "boş";
            veri.miktar = 0;
            veri.id = 0;
            rpt_gider.DataSource = veri;
            rpt_gider.DataBind();
        }
    }
}