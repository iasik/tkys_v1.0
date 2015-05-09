using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_gelir_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }

    public void listele()
    {
        gelir_vt veri = new gelir_vt();
        var sonuc = veri.Listele();
        if(sonuc.basarili_mi)
        {
            rpt_gelir.DataSource = sonuc.veri;
            rpt_gelir.DataBind();
        }
        else
        {
            gelir bos = new gelir();
            bos.ad = "boş";
            bos.miktar = 0;
            bos.id = 0;
        }
    }
}