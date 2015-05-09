using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_gelir_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }

    public void listele()
    {
        gelir_vt gelirvt = new gelir_vt();
        var sonuc = gelirvt.Listele();
        if(sonuc.basarili_mi)
        {
            rpt_gelir.DataSource = sonuc.veri;
            rpt_gelir.DataBind();
        }
        else
        {
            gelir veri = new gelir();
            veri.ad = "boş";
            veri.miktar = 0;
            veri.id = 0;
            rpt_gelir.DataSource = veri;
            rpt_gelir.DataBind();
        }
    }
}