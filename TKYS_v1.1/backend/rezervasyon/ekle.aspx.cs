using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
public partial class backend_rezervasyon_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities kullaniciCek = new TKYSEntities();
        TKYSEntities sosyaltesisCek = new TKYSEntities();
        if (!IsPostBack)
        {
            var kullaniciCekQuery = (from c in kullaniciCek.kullanici
                                     select new { c.id, c.kullanici_adi }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "kullanici_adi";
            DropDownList1.DataSource = kullaniciCekQuery;
            DropDownList1.DataBind();

            var sosyaltesisQuery = (from s in sosyaltesisCek.sosyal_tesis
                                     select new { s.id, s.ad }).ToList();
            DropDownList2.DataValueField = "id";
            DropDownList2.DataTextField = "ad";
            DropDownList2.DataSource = sosyaltesisQuery;
            DropDownList2.DataBind();

        }
    }
    protected void btn_ekle_Click(object sender, EventArgs e)
    {
        rezervasyon_vt rezervasyonvt = new rezervasyon_vt();
        rezervasyon yeni_rezervasyon = new rezervasyon();

        yeni_rezervasyon.ad = txt_ad.Text;
        yeni_rezervasyon.detay = txt_detay.Text;
        yeni_rezervasyon.sosyal_tesis_id = Convert.ToInt32(DropDownList2.SelectedValue);
        yeni_rezervasyon.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);


        var sonuc = rezervasyonvt.Ekle(yeni_rezervasyon);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}