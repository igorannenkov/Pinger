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

namespace Pinger
{
    public partial class MainForm : Form
    {
        public static int[] failurePings;//массив, выделенный для хранения количества "неудачных" попыток пинга
        public static List<int> failures = new List<int>();
        public static List<int> z_order = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddPeers()
        {
            if (!File.Exists("peers.txt") || !File.Exists("locations.txt"))
            {
                MessageBox.Show("В каталоге с программой отсутствуют необходимые для работы файлы peers.txt или locations.txt. Приложение будет закрыто.", "Ошибка - отсутствуют файлы...");
                Application.Exit();
            }
            this.WindowState = FormWindowState.Maximized;
            List<string> hosts = FileHandler.OpenFile("peers.txt");   //считать содержимое файла с узлами  
            List<string> locations = FileHandler.OpenFile("locations.txt");
            hosts.Sort();        
            for (int i = 0; i < hosts.Count; i++)
            {
                PeerControl pc = new PeerControl();
                pc.Location = new Point(Convert.ToInt32(locations[i].Split(',')[0]), Convert.ToInt32(locations[i].Split(',')[1]));
                pc.Tag = hosts[i];
                pc.Name = pc.Tag.ToString();
                this.Controls.Add(pc);
                z_order.Add(Controls.GetChildIndex(pc));
            }
            for (int i = 0; i < this.Controls.Count; i++)
            {
                failures.Add(0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddPeers();
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
                this.Visible = true; 
                this.WindowState = FormWindowState.Maximized;
            }
        }     
        private void загрузитьКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> labels = new List<string>(Controls.Count);

            for (int i = 0; i < Controls.Count; i++)
            {
                labels.Add(Controls[i].Tag.ToString());
            }
            labels.Sort();
            Control[] myControls = new Control[Controls.Count];
            for (int i = 0; i < Controls.Count; i++)
            {
                myControls[i] = this.Controls.Find(labels[i], true).Single(); 
            }
            List<string> locations = FileHandler.OpenFile("locations.txt");
            Controls.Clear();
            for (int i = 0; i < myControls.Length; i++)
            {   
                string[] coords = locations[i].Split(',');
                Point point = new Point(int.Parse(coords[0]), int.Parse(coords[1]));
                myControls[i].Location = point;
                this.Controls.Add(myControls[i]);
            }    
        }
        private void сохранитьРасположениеЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> labels = new List<string>(Controls.Count);

            for (int i = 0; i < Controls.Count; i++)
            {
                labels.Add(Controls[i].Tag.ToString());
            }
            labels.Sort();
            Control[] myControls = new Control[Controls.Count];
            for (int i = 0; i < Controls.Count; i++)
            {
                myControls[i] = this.Controls.Find(labels[i],true).Single(); 
            }
            StreamWriter Writer = new StreamWriter("locations.txt");
            for (int i = 0; i < myControls.Length; i++)
            {
                Writer.WriteLine(myControls[i].Location.X + "," + myControls[i].Location.Y);
            }
            Writer.Close();
        }
        private void перечитатьУзлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
            About about = new About();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.ShowDialog();
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
