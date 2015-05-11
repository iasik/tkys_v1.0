using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_sosyal_tesis_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        sosyal_tesis_vt sosyaltesisvt = new sosyal_tesis_vt();
        sosyal_tesis yeni_sosyal_tesis = new sosyal_tesis();
        yeni_sosyal_tesis.ad = txt_ad.Text;
        yeni_sosyal_tesis.kapasite = Convert.ToInt32(txt_kapasite.Text);

        var sonuc = sosyaltesisvt.Ekle(yeni_sosyal_tesis);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}