using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_rezervasyon_guncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities kullaniciCek = new TKYSEntities();
        TKYSEntities sosyaltesisCek = new TKYSEntities();
        if (!IsPostBack)
        {
            Bul();
            var kullaniciCekQuery = (from c in kullaniciCek.kullanici
                                     select new { c.id, c.kullanici_adi }).ToList();
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "kullanici_adi";
            DropDownList1.DataSource = kullaniciCekQuery;
            DropDownList1.DataBind();
            DropDownList1.SelectedValue = Request.QueryString["user"];// seçili olan id'yi gösteriyor.
            
            var sosyaltesisQuery = (from s in sosyaltesisCek.sosyal_tesis
                                    select new { s.id, s.ad }).ToList();
            DropDownList2.DataValueField = "id";
            DropDownList2.DataTextField = "ad";
            DropDownList2.DataSource = sosyaltesisQuery;
            DropDownList2.DataBind();
            DropDownList2.SelectedValue = Request.QueryString["tesis"];// seçili olan id'yi gösteriyor.

        }

    }
    protected void btn_guncelle_Click(object sender, EventArgs e)
    {
        rezervasyon_vt rezervastonvt = new rezervasyon_vt();
        rezervasyon yeni = new rezervasyon();
        //textbox'dan çek sınıftan ürettiğin nesneye ata
        yeni.id = Convert.ToInt32(Request.QueryString["id"]);
        yeni.ad = txt_ad.Text;
        yeni.detay = txt_detay.Text;
        yeni.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);
        yeni.sosyal_tesis_id = Convert.ToInt32(DropDownList2.SelectedValue);

        var sonuc = rezervastonvt.Guncelle(yeni);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
    }

    public void Bul()
    {
        rezervasyon_vt rezervasyonvt = new rezervasyon_vt();
        var kayit = rezervasyonvt.Bul(Convert.ToInt32(Request.QueryString["id"]));
        txt_ad.Text = kayit.veri.ad;
        txt_detay.Text = kayit.veri.detay;
        //dropdownlist ile kullanici id yukarda getirdik.
    }
}