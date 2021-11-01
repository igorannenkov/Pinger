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
    public partial class MainForm : Form
    {
        public static int[] failurePings;//массив, выделенный для хранения количества "неудачных" попыток пинга
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AddPeers();
        }
        private void AddPeers()
        {
            List<string> hosts = FileHandler.OpenFile("peers.txt");   //считать содержимое файла с узлами  
            List<string> locations = FileHandler.OpenFile("locations.txt");
            if (this.MdiChildren.Count() != 0) //закрыть все дочерние (если есть)
            {
                do
                {
                    MdiChildren[0].Close();
                }
                while (MdiChildren.Count() > 0);
            }
            hosts.Sort();
            for (int i = 0; i < hosts.Count; i++)
            {
                PeerstatusForm form2 = new PeerstatusForm();
                form2.MdiParent = this;
                form2.Text = hosts[i];
                //  form2.Location = new Point(int.Parse(locations[0]), int.Parse(locations[1])); 


                this.MdiChildren[i].Show();
                this.MdiChildren[i].Location = new Point(Convert.ToInt32(locations[i].Split(',')[0]), Convert.ToInt32(locations[i].Split(',')[1]));
                
                this.Refresh();
                failurePings = new int[this.MdiChildren.Length];
            }
        }
        public void sortVertical()
        {
            for (int i = 0; i < MdiChildren.Count(); i++)
            {
                MdiChildren[i].FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            LayoutMdi(MdiLayout.TileVertical);
            for (int i = 0; i < MdiChildren.Count(); i++)
            {
                MdiChildren[i].FormBorderStyle = FormBorderStyle.None;
                MdiChildren[i].Size = new Size(130, 26);
            }
        }
        public void sortHorizontal()
        {
            for (int i = 0; i < MdiChildren.Count(); i++)
            {
                MdiChildren[i].FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            LayoutMdi(MdiLayout.TileHorizontal);
            for (int i = 0; i < MdiChildren.Count(); i++)
            {
                MdiChildren[i].FormBorderStyle = FormBorderStyle.None;
                MdiChildren[i].Size = new Size(130, 26);
            }
        }
        public string offlineInfo()
        {
            int offline = 0;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (((PeerstatusForm)this.MdiChildren[i]).PingResult.BackColor == Color.Red)
                {
                    offline++;
                }
            }
           return "Мониторинг сетевого оборудования. \r\nОффлайн - " + offline + "/" + this.MdiChildren.Length;          
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
            }
            else
            {
                this.Visible = true; this.WindowState = FormWindowState.Maximized;
                this.Text = offlineInfo();
            }
        }
        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.Text = offlineInfo();
        }
        private void загрузитьКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("locations.txt");
            List<Point> locations = new List<Point>();
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                string[] coords = reader.ReadLine().Split(',');
                Point point = new Point(int.Parse(coords[0]), int.Parse(coords[1]));
                this.MdiChildren[i].Location = point;
            }
            reader.Close();
        }
        private void сохранитьРасположениеЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter Writer = new StreamWriter("locations.txt");
            List<Point> locations = new List<Point>();
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                Writer.WriteLine(this.MdiChildren[i].Location.X + "," + this.MdiChildren[i].Location.Y);
            }
            Writer.Close();
        }
        private void перечитатьУзлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPeers();
        }
        private void списокУзловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeerslistForm f4 = new PeerslistForm();
            List<string> hosts = FileHandler.OpenFile("peers.txt");
            hosts.Sort();
            for (int i = 0; i < hosts.Count; i++)
            {
                f4.listBox1.Items.Add(hosts[i]);
            }
            f4.ShowDialog();
        }
        private void выходToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            const string message ="Вы уверены?";
            const string caption = "Выход из программы";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.StartPosition = FormStartPosition.CenterScreen;
            About.ShowDialog();
        }
        private void координатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "locations.txt");
        }
        private void узлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "peers.txt");
        }   
    }
}
