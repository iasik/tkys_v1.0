using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_borc_sil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Request.QueryString["id"]) != null)
            sil(Convert.ToInt32(Request.QueryString["id"]));
        else
            Response.Redirect("listele.aspx");
    }

    public void sil(int id)
    {
        borc_vt borcvt = new borc_vt();
        var sonuc = borcvt.Sil(id);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Write("hata");
    }
}