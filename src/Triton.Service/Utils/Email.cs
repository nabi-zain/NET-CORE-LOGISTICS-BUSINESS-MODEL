using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Triton.Service.Utils
{
    public class Email
    {
        private readonly string _smtp;
        private readonly string _port;

        public Email(string smtp, string port)
        {
            _smtp = smtp;
            _port = port;
        }

        public Task SendEmail(string email, string subject, string htmlMessage)
        {
            const string from = "admin@tritonexpress.co.za";

            var message = new MailMessage();
            message.To.Add(email);
            message.Subject = subject;
            message.From = new MailAddress(from);
            message.Body = htmlMessage;
            message.IsBodyHtml = true;
            var smtp = new SmtpClient(_smtp)
            {
                Port = int.Parse(_port)
            };
            try
            {
                return Task.Run(() => smtp.SendAsync(message, null));
            }
            catch (Exception e)
            {
                var error = e;
                throw error;
            }
        }

        public static bool IsValidEmail(string email)
        {
            //regular expression pattern for valid email
            //addresses, allows for the following domains:
            //com,edu,info,gov,int,mil,net,org,biz,name,museum,coop,aero,pro,tv
            var pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
            (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|za|co|co.za|tv|[a-zA-Z]{2})$";

            //Regular expression object
            var check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            //boolean variable to return to calling method

            //make sure an email address was provided
            var valid = !string.IsNullOrEmpty(email) && check.IsMatch(email);
            //return the value to the calling method
            return valid;
        }

        public static Task SendBCCEmail(List<String> bcc, string from, string body, string subject, string smtpServer)
        {
            try
            {
                // create mail message object
                MailMessage message = new MailMessage();
                foreach (string address in bcc)
                {
                    if (IsValidEmail(address))
                        message.Bcc.Add(address);
                }

                //message.Priority = MailPriority.High;
                message.From = new MailAddress(from);
                message.Body = body;
                message.IsBodyHtml = true;
                message.Subject = subject;

                SmtpClient smtpClient = new SmtpClient();

                if (smtpServer != "" || smtpServer != null)
                    smtpClient = new SmtpClient(smtpServer);

                return Task.Run(() => smtpClient.SendAsync(message, null));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static Task SendBCCEmailAttachment(List<String> bcc, string from, string body, string subject, string smtpServer, List<Attachment> attachments)
        {
            try
            {
                // create mail message object
                MailMessage message = new MailMessage();
                foreach (String address in bcc)
                {
                    if (IsValidEmail(address))
                        message.Bcc.Add(address);
                }

                //message.Priority = MailPriority.High;
                message.From = new MailAddress(from);
                message.Body = body;
                message.IsBodyHtml = true;
                message.Subject = subject;

                if (attachments != null)
                {
                    foreach (Attachment attachment in attachments)
                        message.Attachments.Add(attachment);
                }

                SmtpClient smtpClient = new SmtpClient();

                if (smtpServer != "" || smtpServer != null)
                    smtpClient = new SmtpClient(smtpServer);

                if (smtpServer != "" || smtpServer != null)
                    smtpClient = new SmtpClient(smtpServer);

                return Task.Run(() => smtpClient.SendAsync(message, null));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool SendEmail(string[] to, string[] cc, string[] bcc, string from, string body, string subject, string smtpServer, List<Attachment> attachments, string system)
        {
            bool temp = true;

            //for each address
            foreach (string toAddress in to)
            {
                try
                {
                    // create mail message object
                    foreach (string bccAddress in bcc)
                    {
                        try
                        {
                            MailMessage message = new MailMessage();

                            message.To.Add(toAddress);
                            message.Bcc.Add(bccAddress);
                            message.From = new MailAddress(from);
                            message.Body = body;
                            message.IsBodyHtml = true;
                            message.Subject = subject;
                            message.Priority = MailPriority.High;   // Set PO mail priority to high

                            if (attachments != null)
                            {
                                foreach (Attachment attachment in attachments)
                                    message.Attachments.Add(attachment);
                            }

                            SmtpClient smtpClient = new SmtpClient();

                            if (smtpServer != "" || smtpServer != null)
                                smtpClient = new SmtpClient(smtpServer);

                            smtpClient.Send(message);
                        }
                        catch
                        {
                            try
                            {
                                //System.Diagnostics.EventLog.WriteEntry("email", system + " failed sending email to " + toAddress);
                            }
                            catch { }

                            temp = false;
                        }
                    }
                }
                catch
                {
                    try
                    {
                        // System.Diagnostics.EventLog.WriteEntry("email", system + " failed sending email to " + toAddress);
                    }
                    catch { }

                    temp = false;
                }
            }

            return temp;
        }



        public static Task SendIntraSystemEmail(string[] to, string[] cc, string from, string body, string subject, List<Attachment> attachments)
        {
            try
            {
                // create mail message object
                var message = new MailMessage();
                message.From = new MailAddress(from);
                message.Body = body;
                message.IsBodyHtml = true;
                message.Subject = subject;

                //for each address
                foreach (var toAddress in to)
                {
                    message.To.Add(toAddress);
                }
                if (cc != null && cc[0].Length > 0)
                {
                    foreach (string ccAddress in cc)
                    {
                        message.CC.Add(ccAddress);
                    }
                }

                if (attachments != null)
                {
                    foreach (Attachment attachment in attachments)
                        message.Attachments.Add(attachment);
                }

                var smtpClient = new SmtpClient("texdcmailmbx01");
                return Task.Run(() => smtpClient.SendAsync(message, null));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Task SendIntraSystemEmail(List<string> to, List<string> cc, string from, string body, string subject, List<Attachment> attachments)
        {
            try
            {
                // create mail message object
                var message = new MailMessage();
                message.From = new MailAddress(from);
                message.Body = body;
                message.IsBodyHtml = true;
                message.Subject = subject;

                //for each address
                foreach (var toAddress in to)
                {
                    message.To.Add(toAddress.Replace("\n", "").Replace("\r", ""));

                }
                if (cc != null)
                {
                    foreach (string ccAddress in cc)
                    {
                        message.CC.Add(ccAddress);
                    }
                }

                if (attachments != null)
                {
                    foreach (Attachment attachment in attachments)
                        message.Attachments.Add(attachment);
                }
                message.Headers.Add("Disposition-Notification-To", from);
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

                var smtpClient = new SmtpClient("texdcmailmbx01");
                return Task.Run(() => smtpClient.SendAsync(message, null));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SendEmail(string[] v1, string v2, string v3, string v4, string v5, List<Attachment> attachments)
        {
            throw new NotImplementedException();
        }
    }
}
