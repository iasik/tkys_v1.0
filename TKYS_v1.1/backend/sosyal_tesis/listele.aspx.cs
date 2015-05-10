using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_sosyal_tesis_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        sosyal_tesis_vt sosyaltesisvt = new sosyal_tesis_vt();
        var sonuc = sosyaltesisvt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_sosyal_tesis.DataSource = sonuc.veri;
            rpt_sosyal_tesis.DataBind();
        }
        else
        {
            sosyal_tesis veri = new sosyal_tesis();
            veri.id = 0;
            veri.ad = "bos";
            veri.kapasite = 0;
            rpt_sosyal_tesis.DataSource = veri;
            rpt_sosyal_tesis.DataBind();
        }
    }
}