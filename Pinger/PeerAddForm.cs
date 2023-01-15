using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (hostname_text.Text.ToString() != "" && location_text.Text.ToString() != "" && IPAddressValidator.ValidateFromString(IP_text.Text))
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
                    if (IP_text.Text == "" || !IPAddressValidator.ValidateFromString(IP_text.Text))
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
