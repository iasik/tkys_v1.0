using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_etkinlik_etkinlik : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        etkinlik();
    }

    protected void etkinlik()
    {
        etkinlik_vt etkinlik = new etkinlik_vt();
        var sonuc = etkinlik.Listele();
        if(sonuc.basarili_mi)
        {
            rpt_etkinlik.DataSource = sonuc.veri;
            rpt_etkinlik.DataBind();
        }

    }
}