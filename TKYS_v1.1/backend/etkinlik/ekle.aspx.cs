using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_etkinlik_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities kullaniciCek = new TKYSEntities();

        if (!IsPostBack)
        {
            var kullaniciCekQuery = (from c in kullaniciCek.kullanici
                                     select new { c.id, c.kullanici_adi }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "kullanici_adi";
            DropDownList1.DataSource = kullaniciCekQuery;
            DropDownList1.DataBind();

        }
    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        etkinlik_vt etkinlikvt = new etkinlik_vt();
        etkinlik yeni_etkinlik = new etkinlik();

        yeni_etkinlik.ad        =       txt_ad.Text;
        yeni_etkinlik.detay     =       txt_detay.Text;
        yeni_etkinlik.tarih     =       Calendar1.SelectedDate;
        yeni_etkinlik.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);


        var sonuc = etkinlikvt.Ekle(yeni_etkinlik);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}