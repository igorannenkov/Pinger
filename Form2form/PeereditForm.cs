using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Pinger
{
    public partial class PeereditForm : Form
    {
        public bool isIP(string s) //проверка является ли строка ip адресом (вместо рег выражения)
        {
            string[] temp = s.Split('.');
            if (temp.Length != 4)
            { return false; }
            else
            {
                int a = 0, b = 0, c = 0, d = 0;
                bool A = int.TryParse(temp[0], out a);
                bool B = int.TryParse(temp[1], out b);
                bool C = int.TryParse(temp[2], out c);
                bool D = int.TryParse(temp[3], out d);
                if (!A || !B || !C || !D)
                {
                    return false;
                }
                else
                {
                    if ((a <= 255 && a >= 0) && (b <= 255 && b >= 0) && (c <= 255 && c >= 0) && (d <= 255 && d >= 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public PeereditForm()
        {
            InitializeComponent();
        }
        private void Edit_IP_button_Click(object sender, EventArgs e)
        {
            //логика редактирования - удалить редактируемый элемент и на его место поместить отредактированные данные
            string toDelete = hostname_text.Text.ToString() + ";" + IP_text.Text.ToString() + ";" + location_text.Text.ToString();
            PeerslistForm frm4 = this.Owner as PeerslistForm;
            if (hostname_text.Text.ToString() != "" && location_text.Text.ToString() != "" && isIP(IP_text.Text))
            {
                frm4.listBox1.Items.RemoveAt(frm4.listBox1.SelectedIndex);
                frm4.listBox1.Items.Add(hostname_text.Text.ToString() + ";" + IP_text.Text.ToString() + ";" + location_text.Text.ToString());
                //считываем отредактированный список в List, удаляем дубликаты и сохраняем в файл
                List<string> hosts = new List<string>();
                for (int i = 0; i < frm4.listBox1.Items.Count; i++)
                {
                    hosts.Add(frm4.listBox1.Items[i].ToString());
                }
                hosts.Sort();
                hosts = hosts.Distinct().ToList();
                StreamWriter Writer = new StreamWriter("peers.txt", append: false);
                for (int i = 0; i < hosts.Count; i++)
                {
                    Writer.WriteLine(hosts[i]);
                }
                Writer.Close();
                this.Close();
                frm4.listBox1.Refresh();
            }
            else
            {
                for (int i = 0; i < 3; i++) //"мигаем" 3 раза, если что-то некорректно заполнено
                {
                    if (hostname_text.Text == "")
                    {
                        hostname_text.BackColor = Color.Red;
                    }
                    if (IP_text.Text == "" || !isIP(IP_text.Text))
                    {
                        IP_text.BackColor = Color.Red;
                    }
                    if (location_text.Text == "")
                    {
                        location_text.BackColor = Color.Red;
                    }
                    this.Refresh();
                    Thread.Sleep(50);
                    hostname_text.BackColor = Color.FromName("Window");
                    IP_text.BackColor = Color.FromName("Window");
                    location_text.BackColor = Color.FromName("Window");
                    this.Refresh();
                    Thread.Sleep(50);
                }
             }
        }
    }
}
