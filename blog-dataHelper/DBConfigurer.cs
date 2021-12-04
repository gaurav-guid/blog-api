using System;

namespace blog_dataHelper
{
    public static class DBConfigurer
    {
        private static readonly DBConfiguration _configuration = new DBConfiguration();

        public static bool ConfigureDB(Action<DBConfiguration> configure)
        {
            try
            {
                configure.Invoke(_configuration);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ConnectionString
        {
            get
            {
                return _configuration.ConnectionString;
            }
        }
    }
}
