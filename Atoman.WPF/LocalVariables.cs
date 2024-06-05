using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF
{
    public static class LocalVariables
    {
        public static string CurrentUserJwtToken {  get; set; }

        public const string AppName = "AtomanDesktop";

        public static string AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public static string UserName = "";
    }

}
