using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Pinger
{
    public partial class AddPeerForm : Form
    {
        public AddPeerForm()
        {
            InitializeComponent();
        }
        public bool IsIP(string s)
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
            
            if (hostname_text.Text.ToString() != "" && location_text.Text.ToString() != "" && IsIP(IP_text.Text))
            {
                List<PeerInfo> peers = PeerFileHandler.ReadPeers("Peers.txt");

                if (PeerInfo.HasDuplicate(peers, hostname_text.Text))
                {
                    MessageBox.Show("Элемент с таким именем существует. Введите другое имя.", "Ошибка");
                    return;
                }

                ThePeer peer = new ThePeer();   
                peer.peerHostName = hostname_text.Text;
                peer.peerIpAddress = IP_text.Text;
                peer.peerComment = location_text.Text;
                this.Owner.Controls.Add(peer);
                MainForm.failures.Add(0);
                MainForm.ArrangeElements((Pinger.MainForm)this.Owner);
                peers.Add(new PeerInfo(hostname_text.Text, IP_text.Text, location_text.Text, new Point()));
                peers = (peers.GroupBy(x => x.Name).Select(y => y.First())).ToList(); 
                peers.Sort();
                PeerFileHandler.SavePeers(peers, "Peers.txt");
                this.Close();
            }
            else
            {
                // подсвечиваем некорректно заполненные поля, "моргаем" 3 раза
                for (int i = 0; i < 3; i++) 
                {
                    if (hostname_text.Text == "")
                    {
                        hostname_text.BackColor = Color.Red;
                    }
                    if (IP_text.Text == "" || !IsIP(IP_text.Text))
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
