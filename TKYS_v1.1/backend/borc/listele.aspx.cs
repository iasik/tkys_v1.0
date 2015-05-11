using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_borc_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        borc_vt borcvt = new borc_vt();
        var sonuc = borcvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_borc.DataSource = sonuc.veri;
            rpt_borc.DataBind();
        }
        else
        {
            borc veri = new borc();
            veri.id = 0;
            veri.ad = "bos";
            veri.miktar = 0;
            veri.kullanici_id = 0;

            rpt_borc.DataSource = veri;
            rpt_borc.DataBind();
        }
    }
}