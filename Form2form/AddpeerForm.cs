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
using System.Threading;
using System.Text.RegularExpressions;

namespace Pinger
{
    public partial class AddPeerForm : Form
    {
        public AddPeerForm()
        {
            InitializeComponent();
        }
        public bool isIP(string s) //проверка является ли строка ip адресом 
        {
            string[] temp = s.Split('.');
            if (temp.Length != 4)
            { return false; }
            else
            {
                bool A = int.TryParse(temp[0], out int a);
                bool B = int.TryParse(temp[1], out int b);
                bool C = int.TryParse(temp[2], out int c);
                bool D = int.TryParse(temp[3], out int d);
                if (!A || !B || !C || !D)
                {
                    return false;
                }
                else
                {
                    if ((a <= 255 && a>= 0) && (b <= 255 && b >= 0) && (c <= 255 && c >= 0) && (d <= 255 && d >= 0))
                    {
                        return true;
                    }
                }                 
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PeerslistForm f4 = this.Owner as PeerslistForm;
           
            List<string> hosts = FileHandler.OpenFile("peers.txt");

            if (hostname_text.Text.ToString() != "" && location_text.Text.ToString() != "" && isIP(IP_text.Text))
            {
                // добавляем в наш список элемент
                hosts.Add(hostname_text.Text.ToString() + ";" + IP_text.Text.ToString() + ";" + location_text.Text.ToString());
                //сортируем список для удобства восприятия и удаляем дубликаты. затем перезаписываем в файл и выводим на форму в листбокс
                hosts.Sort();
                hosts = hosts.Distinct().ToList();
                f4.listBox1.Items.Clear();
                FileHandler.SaveFile(hosts, "peers.txt", append: false);
                for (int i = 0; i < hosts.Count; i++)
                {
                    f4.listBox1.Items.Add(hosts[i]);
                }
                this.Close();
                f4.listBox1.Refresh();
                //при наличии файла с координатами помещаем новый элемент в правый нижний угол
                if (File.Exists("locations.txt"))
                {
                    StreamWriter Writer = new StreamWriter("locations.txt", true);
                    Writer.WriteLine("1700,900");
                    Writer.Close();
                }
            }
            else
            {          
                for (int i = 0; i < 3; i++) // подсвечиваем некорректно заполненные поля, "моргаем" 3 раза
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
