using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_is_turu_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        is_turu_vt isturuvt = new is_turu_vt();
        var sonuc = isturuvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_isturu.DataSource = sonuc.veri;
            rpt_isturu.DataBind();
        }
        else
        {
            is_turu veri = new is_turu();
            veri.ad = "boş";
            veri.id = 0;
            rpt_isturu.DataSource = veri;
            rpt_isturu.DataBind();
        }
    }
}