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
    public partial class AddGroup : Form
    {
        TreeView TV;
        public AddGroup(TreeView TV)
        {
            InitializeComponent();
            this.TV = TV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Struc.allGroup.Add(new Struc.Group
            {
                id = Struc.allGroup.Count+1,
                name =textBox1.Text
            });
            Commands.ClearTreeView(TV);
            Commands.ViewGroup(TV);
            this.Close();
        }
    }
}
