using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Pinger
{
    public partial class MainForm : Form
    {
        public static int[] failurePings;//массив, выделенный для хранения количества "неудачных" попыток пинга
        public static List<int> failures = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddPeers()
        {
            if (!File.Exists("Peers.csv"))
            {
                MessageBox.Show("В каталоге с программой отсутствует необходимый для работы файл Peers.csv. Приложение будет закрыто.", "Ошибка");
                Application.Exit();
            }
            this.WindowState = FormWindowState.Maximized;
            List<PeerInfo> peers = PeerFileHandler.ReadPeers("Peers.csv");
            for (int i = 0; i < peers.Count; i++)
            {
                ThePeer pc = new ThePeer();
                pc.Location = peers[i].Location;
                pc.Name = peers[i].Name;
                pc.peerHostName = peers[i].Name;
                pc.peerIpAddress = peers[i].IP;
                pc.peerComment = peers[i].Comment;
                this.Controls.Add(pc);
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
       
        private void перечитатьУзлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
            AboutBox about = new AboutBox();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.ShowDialog();
        }

        private void выровнятьПоСеткеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.fitPeers(this);
        }

        private void SaveConfig_Click(object sender, EventArgs e)
        {
            List<PeerInfo> peersToSave = new List<PeerInfo>();
            List<string> hostNames = new List<string>(Controls.Count);
            Control[] myControls = new Control[Controls.Count];

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is ThePeer)
                {
                    hostNames.Add((Controls[i] as ThePeer).peerHostName);
                }
            }

            hostNames.Sort();
            
            for (int i = 0; i < Controls.Count; i++)
            {
                myControls[i] = this.Controls.Find(hostNames[i], true).Single();
            }
            
            for (int i = 0; i < myControls.Length; i++)
            {
                if(myControls[i] is ThePeer)
                {
                    peersToSave.Add(new PeerInfo((myControls[i] as ThePeer).peerHostName,
                                                 (myControls[i] as ThePeer).peerIpAddress,
                                                 (myControls[i] as ThePeer).peerComment,
                                                 (myControls[i].Location)));
                }
            }

            PeerFileHandler.SavePeers(peersToSave, "Peers.csv");
        }
        private void LoadConfig_Click(object sender, EventArgs e)
        {
            List<string> hostNames = new List<string>(Controls.Count);

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is ThePeer)
                {
                    hostNames.Add((Controls[i] as ThePeer).peerHostName);
                }
            }

            hostNames.Sort();

            Control[] myControls = new Control[Controls.Count];

            for (int i = 0; i < Controls.Count; i++)
            {
                myControls[i] = this.Controls.Find(hostNames[i], true).Single();
            }

            List<PeerInfo> peers = PeerFileHandler.ReadPeers("Peers.csv");

            Controls.Clear();

            for (int i = 0; i < myControls.Length; i++)
            {
                myControls[i].Location = peers[i].Location;
                this.Controls.Add(myControls[i]);
            }
        }
        private void узлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "Peers.csv");
        }

        private void добавитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO добавить элемент, выполнить сортировку, сохранить в файл, отобразить в окне и выровнять по сетке автоматически
            //при добавлении окрасить цветом для обозначения местоположения

            AddPeerForm apf = new AddPeerForm();
            apf.Text = "Добавление элемента";
            apf.StartPosition = FormStartPosition.CenterParent;
            apf.ShowDialog(this);
        }
        public static void fitPeers(MainForm form)
        {

            int height = form.Height - 125;

            List<ThePeer> peers = new List<ThePeer>();

            for (int i = 0; i < form.Controls.Count; i++)
            {
                if (form.Controls[i] is ThePeer)
                {
                    peers.Add((ThePeer)form.Controls[i]);
                }
            }

            peers.Sort();

            form.Controls.Clear();

            for (int i = 0, x = 5, y = 5, prevX = x; i <= peers.Count - 1; i++)
            {
                bool firstline = false;

                if (i == 0)
                {
                    peers[i].Location = new Point(x, y);
                    form.Controls.Add(peers[i]);
                    continue;
                }

                if (i == peers.Count - 1)
                {
                    if ((peers[i]).peerHostName.Contains(((peers[i - 1]).peerHostName)))
                    {
                        x += 145;
                        peers[i].Location = new Point(x, y);
                        form.Controls.Add(peers[i]);
                        x = prevX;
                    }
                    else
                    {
                        y += 40;
                        peers[i].Location = new Point(x, y);
                        form.Controls.Add(peers[i]);
                    }
                    continue;
                }

                if ((y > height) && !((peers[i]).peerHostName.Contains(((peers[i - 1]).peerHostName))))
                {
                    x += 300;
                    prevX = x;
                    y = 5;
                    firstline = true;
                }

                try
                {
                    if (((peers[i]).peerHostName.Contains(((peers[i - 1]).peerHostName))))
                    {
                        x += 145;
                        peers[i].Location = new Point(x, y);
                        form.Controls.Add(peers[i]);
                        x = prevX;
                    }
                    else
                    {
                        if (firstline)
                        {
                            peers[i].Location = new Point(x, y);
                            form.Controls.Add(peers[i]);
                        }
                        else
                        {
                            y += 40;
                            peers[i].Location = new Point(x, y);
                            form.Controls.Add(peers[i]);
                        }
                    }
                }
                catch (IndexOutOfRangeException exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

    }
}
