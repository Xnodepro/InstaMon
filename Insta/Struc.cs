using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta
{
   public static  class Struc
    {
        public static List<Users> allUsers = new List<Users>();
        public static List<Group> allGroup = new List<Group>();
        public static DataGridViewRow[] tmp = null;
        public  struct Users
        {
            public int id { get; set; }
            public string login { get; set; }
            public string pass { get; set; }
            public string proxy { get; set; }
            public string proxyPort { get; set; }
            public string proxyLogin { get; set; }
            public string proxyPass { get; set; }
            public int countPublication { get; set; }
            public int countSubscribers { get; set; }
            public int countFolowing { get; set; }
            public string task { get; set; }
            public string stateUser { get; set; }
            public string statusWork { get; set; }
            public string statusUser { get; set; }
            public string comment { get; set; }
        }

        public struct Group
        {
            public int id { get; set; }
            public string name { get; set; }
            public List<int> UsersId { get; set; }
            public Group(int ID,string Name, List<int> UI)
            {
                id = ID;
                name = Name;
                UsersId = UI;
            }

        }
    }
}
