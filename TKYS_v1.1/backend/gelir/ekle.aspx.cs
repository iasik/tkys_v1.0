using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class backend_gelir_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        gelir_vt gelirvt = new gelir_vt();

        gelir yeni_gelir = new gelir();
        yeni_gelir.ad = txt_ad.Text;
        yeni_gelir.miktar = Convert.ToInt32(txt_miktar.Text);
        var sonuc = gelirvt.Ekle(yeni_gelir);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}