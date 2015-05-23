using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_borc_borc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        borc();
    }

    protected void borc()
    {
        borc_vt borc = new borc_vt();
        var sonuc = borc.kullanici_borc(((kullanici_bilgisi)Session[SiteTanim.KullaniciSession]).id);

        if(sonuc.basarili_mi)
        {
            rpt_borc.DataSource = sonuc.veri;
            rpt_borc.DataBind();
        }
    }
}