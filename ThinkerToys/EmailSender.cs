using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ThinkerToys
{
    public class EmailSender 
    {
        public static void SendOTPEmail(string toEmail, string otp)
        {
            string fromEmail = "ThinkerToys.App@gmail.com";
            string password = "ThinkerToys2024!@";

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = "Your ThinkerToys Account Confirmation OTP",
                Body = $"Your OTP is : {otp}\nThis OTP will expire in 10 minutes.",
                IsBodyHtml = false,
            };


            mailMessage.To.Add(toEmail);

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP :" + ex.Message);
            }

        }// end of function SendOTPEmail

    } // end of class EmailSender

} // end of namespace ThinkerToys
