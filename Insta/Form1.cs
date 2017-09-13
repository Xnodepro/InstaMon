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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Вывод групп в treeview
            Commands.ViewGroup(treeView1);
        //    dataGridView1.Rows.Clear();
        
        }


        private void добавитьUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsers AddUser = new AddUsers();
            AddUser.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup(treeView1);
            add.Show();
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Struc.allGroup.RemoveAll(N => N.name == treeView1.SelectedNode.Text);
            treeView1.SelectedNode.Remove();
        }
    }
}
