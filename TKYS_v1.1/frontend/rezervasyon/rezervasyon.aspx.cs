using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frontend_rezervasyon_rezervasyon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RezervasyonListele();
    }

    public void RezervasyonListele() {
        sosyal_tesis_vt sosyal_tesis = new sosyal_tesis_vt();
       var sonuc = sosyal_tesis.Listele();
        if (sonuc.basarili_mi)
        {
            rpt_Rezervasyon.DataSource = sonuc.veri;
            rpt_Rezervasyon.DataBind();
        }
        else
        {
           
        }
    }
}