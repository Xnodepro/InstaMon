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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Lines.Length != textBox2.Lines.Length)
            {
                MessageBox.Show("Количество строк не совпадает!");
                return;
            }
            if (textBox2.Lines[0].Count(chr => (chr == ':')) > 2)
            {
                int p = 0;
                foreach (var item in textBox1.Lines)
                {
                    string[] sp = textBox2.Lines[p].Split(':');
                    var user = new Struc.Users
                    {
                        id = Struc.allUsers.Count + 1,
                        login = item.Split(':')[0],
                        pass = item.Split(':')[1],
                        proxyLogin = sp[0],
                        proxyPass = sp[1],
                        proxy = sp[2],
                        proxyPort = sp[3],
                        task = "Нету",
                        statusUser = "Добавлен аккаунт"

                    };
                    Struc.allUsers.Add(user);
                    Commands.CreateDir(user.login);
                    p++;
                }
            }
            else {
                int p = 0;
                foreach (var item in textBox1.Lines)
                {
                    string[] sp = textBox2.Lines[p].Split(':');
                    var user = new Struc.Users
                    {
                        id = Struc.allUsers.Count + 1,
                        login = item.Split(':')[0],
                        pass = item.Split(':')[1],
                        proxy = sp[0],
                        proxyPort = sp[1],
                        task = "Нету",
                        statusUser = "Добавлен аккаунт"

                    };
                    Struc.allUsers.Add(user);
                    Commands.CreateDir(user.login);
                    p++;
                }
            }
            Commands.SetAllDateToFileJson();//Записываем все данные в json файл
        }
    }
}
