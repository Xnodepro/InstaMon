using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta
{
   public static  class Struc
    {
        public  struct Users
        {
            int id { get; set; }
            string login { get; set; }
            string pass { get; set; }
            string proxy { get; set; }
            string proxyPort { get; set; }
            int countPublication { get; set; }
            int countSubscribers { get; set; }
            int countFolowing { get; set; }
            string task { get; set; }
            string StatusUser { get; set; }

        }
    }
}
