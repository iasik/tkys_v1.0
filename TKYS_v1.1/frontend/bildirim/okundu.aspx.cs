using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_bildirim_okundu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["id"]==null)
        {
            Response.Redirect("bildirim.aspx");
        }
        else
        {
            okundu(Convert.ToInt32(Request.QueryString["id"]));
        }
    }

    public void okundu(int id)
    {
        bildirim_vt bildirim = new bildirim_vt();
        var sonuc = bildirim.Sil(id);
        if(sonuc.basarili_mi)
        {
            Response.Redirect("bildirim.aspx");
        }
        else
            Response.Redirect("bildirim.aspx");
    }
}