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
            Commands.GetAllDateToFileJson();// получаем json всех данных
            //Вывод групп в treeview
            Commands.ViewGroup(treeView1);
            timer1.Start();
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Все")
            {
                dataGridView1.Rows.Clear();
                foreach (var item in Struc.allUsers)
                {
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!

                    DataGridViewRow row = dataGridView1.Rows[rowId];
                    row.Cells["id"].Value = item.id;
                    row.Cells["Login"].Value = item.login;
                    row.Cells["Pass"].Value = item.pass;
                    row.Cells["Proxy"].Value = item.proxy + ":" + item.proxyPort;
                    row.Cells["CountPublication"].Value = item.countPublication;
                    row.Cells["Subscribers"].Value = item.countSubscribers;
                    row.Cells["CountFolow"].Value = item.countFolowing;
                    row.Cells["Task"].Value = item.task;
                    row.Cells["State"].Value = item.stateUser;
                    row.Cells["WorkState"].Value = item.statusWork;
                    row.Cells["UserStatus"].Value = item.statusUser;
                    row.Cells["Comments"].Value = item.comment;
                    //  dataGridView1.Rows.Add(row);
                }
            }
            else {
                ////////Ставим невидимыми все ровс
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows[i].Visible = false;
                ///Выводим только тех юзеров которые состоят в этой группе
                foreach (var item in Struc.allGroup)
                {
                    if(item.name == treeView1.SelectedNode.Text)
                    {

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            foreach (var id in item.UsersId)
                            {
                                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id.ToString())
                                {
                                    dataGridView1.Rows[i].Visible = true;

                                }

                            }

                        }
                    }
                }

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }
        void disp(object sender, EventArgs e)
        {
            string NameGroupSender = (sender as ToolStripMenuItem).Text;

            var selectedRows = dataGridView1.SelectedRows
           .OfType<DataGridViewRow>()
           .Where(row => !row.IsNewRow)
           .ToArray();
            foreach (var item in selectedRows)
            {
                int id = Convert.ToInt32(item.Cells["id"].Value);
                var aa = Struc.allGroup.FindIndex(N => N.name == NameGroupSender);
                Struc.allGroup[aa].UsersId.Add(id);
            }
            
            

          //  MessageBox.Show(a);
        }

        private void добавитьВГруппуToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            добавитьВГруппуToolStripMenuItem.DropDownItems.Clear();
            foreach (var item in Struc.allGroup)
            {
                EventArgs e1 = new EventArgs();
                добавитьВГруппуToolStripMenuItem.DropDownItems.Add(item.name, null, disp);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Commands.SetAllDateToFileJson();//Записываем все данные в json файл
        }

        private void импортЭкспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Struc.tmp =  dataGridView1.SelectedRows
           .OfType<DataGridViewRow>()
           .Where(row => !row.IsNewRow)
           .ToArray();
            IEAccount IEA = new IEAccount();
            IEA.Show();
        }

        private void сГруппыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
           .OfType<DataGridViewRow>()
           .Where(row => !row.IsNewRow)
           .ToArray();
            foreach (var item in selectedRows)
            {
                int id = Convert.ToInt32(item.Cells["id"].Value);
                var aa = Struc.allGroup.FindIndex(N => N.name == treeView1.SelectedNode.Text);
                Struc.allGroup[aa].UsersId.Remove(id);
            }
        }

        private void безвозвратноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
          .OfType<DataGridViewRow>()
          .Where(row => !row.IsNewRow)
          .ToArray();
            foreach (var item in selectedRows)
            {
                int id = Convert.ToInt32(item.Cells["id"].Value);
                int pp = 0;
                foreach (var group in Struc.allGroup)
                {
                    Struc.allGroup[pp].UsersId.Remove(id);
                    pp++;
                }
                Struc.allUsers.RemoveAll(M => M.id == id);
                
            }
        }

        private void проверитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows
          .OfType<DataGridViewRow>()
          .Where(row => !row.IsNewRow)
          .ToArray();

            foreach (var item in selectedRows)
            {
                int id = Convert.ToInt32(item.Cells["id"].Value);
                ChekAcc CA = new ChekAcc(id);
                 new System.Threading.Thread(delegate () { CA.Init(); }).Start();
               // CA.Init();
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.Mess.Count > 0)
            {
                for (int i = 0; i < Program.Mess.Count; i++)
                {
                    textBox1.Text = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "]" + Program.Mess.Dequeue() + textBox1.Text + Environment.NewLine;
                }
            }
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameGroup RG = new RenameGroup(treeView1);
            RG.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
   
}
