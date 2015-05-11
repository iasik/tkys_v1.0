using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_is_turu_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        is_turu_vt islervt = new is_turu_vt();
        is_turu yeni_isturu = new is_turu();
        yeni_isturu.ad = txt_ad.Text;

        var sonuc = islervt.Ekle(yeni_isturu);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}