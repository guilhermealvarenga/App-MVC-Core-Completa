using KissLog;
using KissLog.Apis.v1.Listeners;
using Microsoft.Extensions.Configuration;

namespace DevIO.App.Configurations
{
    public class LogConfig
    {
        public static void RegisterKissLogListener(IConfiguration configuration)
        {
            KissLogConfiguration.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                    configuration["KissLog.OrganizationId"],
                    configuration["KissLog.ApplicationId"]
                )));
        }
    }
}