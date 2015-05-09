using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_gelir_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            Bul();
    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        gelir_vt gelirvt = new gelir_vt();
        gelir yeni = new gelir();
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.miktar = Convert.ToInt32(txt_miktar.Text);
        var sonuc = gelirvt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        gelir_vt gelirvt = new gelir_vt();
        var kayit = gelirvt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_miktar.Text = kayit.veri.miktar.ToString();
    }
}