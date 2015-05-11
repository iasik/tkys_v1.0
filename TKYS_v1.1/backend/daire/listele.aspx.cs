using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_daire_listele : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        listele();
    }
    public void listele()
    {
        daire_vt dairevt = new daire_vt();
        var sonuc = dairevt.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_daire.DataSource = sonuc.veri;
            rpt_daire.DataBind();
        }
        else
        {
            daire veri = new daire();
            veri.kat = 0;
            veri.daire_no = 0;
            veri.blok = "bos";
            veri.daire_genisligi = 0;
            veri.kullanici_id = 0;
            rpt_daire.DataSource = veri;
            rpt_daire.DataBind();
        }
    }
}