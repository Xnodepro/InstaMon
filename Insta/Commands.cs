using System;
using System.Collections.Generic;
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
        public static void ClearTreeView(TreeView TV)
        {
            TV.Nodes.Clear();
        }
    }
}
