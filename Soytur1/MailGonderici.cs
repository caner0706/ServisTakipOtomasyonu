using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Soytur.Models;

namespace Soytur1
{
    public class MailGonderici
    {
        SoyturEntitiesConnectionDb db = new SoyturEntitiesConnectionDb();

        public void Microsoft( string GondericiMail,string GondericiPass, string AliciMail)
        {
            Models.GirisTablosu p = db.GirisTablosu.FirstOrDefault(x => x.MailAdres == GondericiMail);
            Random rnd = new Random();
            p.Sifre = rnd.Next(100000, 10000000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new System.Net.NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "Caner Giden");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Sıfırlama Talebinde Bulunduz";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString() } Tarihinde Şifre Sıfırlama Talebinde Bulunduz. Yeni Şifreniz : {p.Sifre } ";

            //sc.Timeout = 120;

            sc.Send(mail);

        }

        internal void Microsoft(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
