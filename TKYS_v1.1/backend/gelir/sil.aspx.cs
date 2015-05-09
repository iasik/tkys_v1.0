using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_gelir_sil : System.Web.UI.Page
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
        gelir_vt gelir = new gelir_vt();
        var sonuc = gelir.Sil(id);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Write("hata");
    }
}