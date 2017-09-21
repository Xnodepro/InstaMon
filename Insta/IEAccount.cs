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
    public partial class IEAccount : Form
    {
        public IEAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                string temp = string.Empty;
                int count = textBox1.Text.Count(chr => chr == ':');
                foreach (var item in Struc.tmp)
                {
                    var aa = Struc.allUsers.Find(N => N.id == Convert.ToInt32(item.Cells["id"].Value));
                    if (count == 1)
                    {
                        temp += aa.login + ":" + aa.pass + Environment.NewLine;
                    }
                    if (count == 3)
                    {
                        temp += aa.login + ":" + aa.pass + ":" + aa.proxy + ":" + aa.proxyPort + Environment.NewLine;
                    }
                    if (count == 5)
                    {
                        temp += aa.login + ":" + aa.pass + ":" + aa.proxyLogin + ":" + aa.proxyPass + ":" + aa.proxy + ":" + aa.proxyPort + Environment.NewLine;
                    }
                }
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, temp);
                //MessageBox.Show("Файл сохранен");
            }
            else {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string[] fileText = System.IO.File.ReadAllLines(filename);
                foreach (var item in fileText)
                {
                    int count = item.Count(chr => chr == ':');
                    if (count == 1)
                    {
                        var user = new Struc.Users
                        {
                            id = Struc.allUsers.Count + 1,
                            login = item.Split(':')[0],
                            pass = item.Split(':')[1],
                            task = "Нету",
                            statusUser = "Добавлен аккаунт"

                        };
                        Struc.allUsers.Add(user);
                    }
                    if (count == 3)
                    {
                        var user = new Struc.Users
                        {
                            id = Struc.allUsers.Count + 1,
                            login = item.Split(':')[0],
                            pass = item.Split(':')[1],
                            proxy = item.Split(':')[2],
                            proxyPort = item.Split(':')[3],
                            task = "Нету",
                            statusUser = "Добавлен аккаунт"

                        };
                        Struc.allUsers.Add(user);
                    }
                    if (count == 5)
                    {
                        var user = new Struc.Users
                        {
                            id = Struc.allUsers.Count + 1,
                            login = item.Split(':')[0],
                            pass = item.Split(':')[1],
                            proxyLogin = item.Split(':')[2],
                            proxyPass = item.Split(':')[3],
                            proxy = item.Split(':')[4],
                            proxyPort = item.Split(':')[5],
                            task = "Нету",
                            statusUser = "Добавлен аккаунт"

                        };
                        Struc.allUsers.Add(user);
                    }
                }
               
                
              //  textBox1.Text = fileText;
                //MessageBox.Show("Файл открыт");
            }
        }
    }
}
