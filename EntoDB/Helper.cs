
using System.Configuration;


namespace Rapento
{
    class Helper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
