using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta
{
    public static class Commands
    {
        public static  void ViewGroup (TreeView TV)
        {
            try
            {
                TreeNode tovarNode = new TreeNode("Все");
                // Добавляем новый дочерний узел к tovarNode
                //tovarNode.Nodes.Add(new TreeNode("Смартфоны"));
                // Добавляем tovarNode вместе с дочерними узлами в TreeView
                TV.Nodes.Add(tovarNode);
                tovarNode = new TreeNode("Группы");
                foreach (var item in Struc.allGroup)
                    tovarNode.Nodes.Add(new TreeNode(item.name));
                TV.Nodes.Add(tovarNode);
            }
            catch (Exception)
            {

               
            }
           
        }
        public static void ClearTreeView(TreeView TV)
        {
            TV.Nodes.Clear();
        }
        public static void SetAllDateToFileJson()
        {
            string jsonU = JsonConvert.SerializeObject(Struc.allUsers);
            if(jsonU !="")
              File.WriteAllText("./data/dataU", jsonU);

            string jsonG = JsonConvert.SerializeObject(Struc.allGroup);
            if (jsonU != "")
                File.WriteAllText("./data/dataG", jsonG);
        }
        public static void GetAllDateToFileJson()
        {
            string jG = File.ReadAllText("./data/dataG");
            if (jG != "")
                Struc.allGroup = JsonConvert.DeserializeObject<List<Struc.Group>>(jG);

            string jU = File.ReadAllText("./data/dataU");
            if (jU != "")
                Struc.allUsers = JsonConvert.DeserializeObject<List<Struc.Users>>(jU);
        }
        public static void CreateDir(string name)
        {
            string path = Environment.CurrentDirectory;
            DirectoryInfo dirInfo = new DirectoryInfo(path+"\\Accounts\\"+name);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
                File.WriteAllText("./Accounts/"+name+"/FolowList", "");
                File.WriteAllText("./Accounts/" + name + "/Log.txt", "");
            }
        }
    }
}
