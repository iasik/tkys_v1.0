using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_gider_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        gider_vt gidervt = new gider_vt();

        gider yeni_gider = new gider();
        yeni_gider.ad = txt_ad.Text;
        yeni_gider.miktar = Convert.ToInt32(txt_miktar.Text);
        var sonuc = gidervt.Ekle(yeni_gider);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}