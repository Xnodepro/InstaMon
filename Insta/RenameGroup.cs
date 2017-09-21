using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta
{
    public partial class RenameGroup : Form
    {
        TreeView TV;
        public RenameGroup(TreeView TV)
        {
            InitializeComponent();
            this.TV = TV;
            textBox1.Text = TV.SelectedNode.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Struc.allGroup.FindIndex(N => N.name == TV.SelectedNode.Text);
            var group = Struc.allGroup[index];
            group.name = textBox1.Text;
            Struc.allGroup[index] = group;
            Commands.ClearTreeView(TV);
            Commands.ViewGroup(TV);
            this.Close();
            Commands.SetAllDateToFileJson();//Записываем все данные в json файл
        }
    }
}
