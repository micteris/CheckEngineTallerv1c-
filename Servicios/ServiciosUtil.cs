using CheckEngineTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngineTaller.Servicios
{    public static class ServiciosUtil
    {
        private const string EMAILSENDER = "checkengine.noreply@gmail.com";
        private const string PASSWORDSENDER = "poi16poi16";

        public static bool RecoveryPassword(string identificacion)
        {
            var service = new ServiciosCliente();
            var cliente = service.GetClienteByIdentificacion(identificacion);
            if (cliente == null) return false;



            MailMessage mailMessage = new MailMessage(
                from: EMAILSENDER,
                to: "fredinfu@gmail.com", //cliente.CI_Email,
                subject: "Ha solicitado restablecer su password en Check Engine",
                body: $"Por favor inicie sesion con este password temporal: {service.GenerateToken(identificacion)}"
                );

            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential credential = new NetworkCredential(EMAILSENDER, PASSWORDSENDER);
            smtpClient.Credentials = credential;
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

            return true;
        }
        
    }
}
