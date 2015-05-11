using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_daire_ekle : System.Web.UI.Page
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
        daire_vt dairevt = new daire_vt();
        daire yeni_daire = new daire();
        yeni_daire.kat = Convert.ToInt32(txt_kat.Text);
        yeni_daire.daire_no = Convert.ToInt32(txt_daire_no.Text);
        yeni_daire.daire_genisligi = Convert.ToInt32(txt_daire_genisligi.Text);
        yeni_daire.blok = txt_blok.Text;
        yeni_daire.kullanici_id = Convert.ToInt32(DropDownList1.SelectedValue);
        var sonuc = dairevt.Ekle(yeni_daire);
        if (sonuc.basarili_mi)
            Response.Redirect("listele.aspx");
        else
            Response.Redirect("hata_sayfasi");


    }
}