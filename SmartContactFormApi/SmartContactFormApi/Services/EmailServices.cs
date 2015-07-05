using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using log4net;

namespace SmartContactFormApi.Services
{
    public class EmailService 
    {
        private readonly string _environment;
        private readonly ILog _logger = LogManager.GetLogger(typeof(EmailService));
        private readonly MailSettingsSectionGroup _mailSettings;

        public EmailService()
        {
            _mailSettings = GetSectionGroupInstance<MailSettingsSectionGroup>("system.net/mailSettings");
            string envionmentValue = string.Empty;
        }

        public string Environment
        {
            get { return _environment; }
        }

        public void SendEmail(string title, string body, bool isBodyHtml = false, params string[] recipients)
        {
            try
            {
                using (var message = new MailMessage())
                {
                    foreach (string recipient in recipients)
                    {
                        message.To.Add(new MailAddress(recipient));
                    }

                    message.Subject = string.IsNullOrEmpty(Environment)
                        ? title
                        : string.Format("[{0}] - {1}", Environment, title);
                    message.Body = body;
                    message.IsBodyHtml = isBodyHtml;

                    using (var client = new SmtpClient())
                    {
                        client.Credentials = new NetworkCredential(_mailSettings.Smtp.Network.UserName,
                            _mailSettings.Smtp.Network.Password);
                        client.Send(message);
                    }
                }
            }
            catch (Exception e)
            {
                _logger.Fatal("Error occurred while sending an email", e);
            }
        }

        private static T GetSectionGroupInstance<T>(string sectionGroupName) where T : ConfigurationSectionGroup
        {
            if (string.IsNullOrEmpty(sectionGroupName)) return Activator.CreateInstance<T>();

            System.Configuration.Configuration appConfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConfigurationSectionGroup instance = appConfig.GetSectionGroup(sectionGroupName);

            return (instance == null || !typeof(T).IsAssignableFrom(instance.GetType()))
                ? Activator.CreateInstance<T>()
                : instance as T;
        }
    }
}