using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class frontend_genel_iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_gonder_Click(object sender, EventArgs e)
    {
        MailMessage ePosta = new MailMessage();
        ePosta.From = new MailAddress("asikibrahim93@gmail.com");
        ePosta.To.Add("flysoft@omernaci.com");
        ePosta.Subject = "İletişim Formu";
        ePosta.IsBodyHtml = true;
        ePosta.Body = "Ad :" + txt_ad.Text + "</br>"+
                      "E posta :" + txt_posta.Text +"</br>"+
                      "Mesaj : " + txt_mesaj.Text;

        SmtpClient smtp = new SmtpClient();
        smtp.Credentials = new System.Net.NetworkCredential("asikibrahim93@gmail.com", "529843asik");
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        try
        {
            smtp.Send(ePosta);
            lbl_hata.Text = "Mail gönderildi";
        }
        catch(Exception hata)
        {
            lbl_hata.Text = hata.Message;
        }
            
    }
}