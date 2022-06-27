using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace workshop01.Helper
{
    public static class ConfigHelper
    {
        static readonly string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(new String[] { @"bin\" }, StringSplitOptions.None)[0];
        static readonly IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(projectPath)
            .AddJsonFile("appsettings.json")
            .Build();
        //public static string LdapGSB { get { return configuration.GetSection("LdapGSB").Get<string>(); ; } }
        public static string ConnectionString { get { return (string)configuration.GetConnectionString("AppDatabaseConnectionString"); } }

        //public static string LisDatabaseConnectionString { get { return (string)configuration.GetConnectionString("LisDatabaseConnectionString"); } }
        //public static string WhileListEndpoint { get { return configuration.GetSection("WhileListEndpoint").Get<string>(); ; } }
        //public static string CBSApiEndpoint { get { return configuration.GetSection("CBSApiEndpoint").Get<string>(); ; } }
        //public static string CBSApiChannel { get { return configuration.GetSection("CBSApiChannel").Get<string>(); ; } }
        //public static string WarningListApi { get { return configuration.GetSection("WarningListApi").Get<string>(); ; } }
        //public static string WarningListUser { get { return configuration.GetSection("WarningListUser").Get<string>(); ; } }
        //public static string fileServer { get { return configuration.GetSection("fileServer").Get<string>(); ; } }
    }
}
