using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

public partial class backend_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TKYSEntities entity = new TKYSEntities();
        var kayitlar =(from u in entity.kullanici select u).ToList();
        GridView1.DataSource = kayitlar;
        GridView1.DataBind();

    }

}