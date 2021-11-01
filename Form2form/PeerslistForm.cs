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

namespace Pinger
{
    public partial class PeerslistForm : Form
    {
        public PeerslistForm()
        {
            InitializeComponent();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != -1)
            {
                PeereditForm f3 = new PeereditForm();
                f3.Text = "Редактирование узла";
                f3.IP_text.Text = listBox1.Items[index].ToString().Split(';')[1];
                f3.hostname_text.Text = listBox1.Items[index].ToString().Split(';')[0];
                f3.location_text.Text = listBox1.Items[index].ToString().Split(';')[2];
                f3.ShowDialog(this);
            }   
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                listBox1.Refresh();
                this.Refresh();
            }
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<string> hosts = FileHandler.OpenFile("peers.txt");
                listBox1.Items.Clear();
                for (int i = 0; i < hosts.Count; i++)
                {
                    listBox1.Items.Add(hosts[i]);
                }
                listBox1.Refresh();
            }
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> hosts = FileHandler.OpenFile("peers.txt");
            listBox1.Items.Clear();
            for (int i = 0; i < hosts.Count; i++)
            {
                listBox1.Items.Add(hosts[i]);
            }
            listBox1.Refresh();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            if (listBox1.SelectedIndex != -1)//Если список не пустой
            {
                List<string> hosts = FileHandler.OpenFile("peers.txt");
                hosts.RemoveAt(listBox1.SelectedIndex);
                //сортируем и удаляем дубликаты, записываем в файл
                hosts.Sort();
                hosts = hosts.Distinct().ToList();
                FileHandler.SaveFile(hosts, "peers.txt", append: false);

                hosts = FileHandler.OpenFile("peers.txt");
                listBox1.Items.Clear();
                for (int i = 0; i < hosts.Count; i++)
                {
                    listBox1.Items.Add(hosts[i]);
                }
                listBox1.Refresh();
            }
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPeerForm f6 = new AddPeerForm();
            f6.ShowDialog(this);
        }
    }
}
