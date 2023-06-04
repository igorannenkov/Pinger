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
            
            if (hostname_text.Text != "" && location_text.Text != "" && IPAddrVerificator.Verified(IP_text.Text))
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
                if (hostname_text.Text == string.Empty)
                {
                    addHostnameErrProv.SetError(hostname_text, "Укажите наименование узла.");
                }
                else
                {
                    addHostnameErrProv.Clear();
                }
                if (location_text.Text == string.Empty)
                {
                    addLocationErrProv.SetError(location_text, "Укажите комментарий к узлу.");
                }
                else
                {
                    addLocationErrProv.Clear();
                }
                if (!IPAddrVerificator.Verified(IP_text.Text))
                {
                    addIpAddrErrProv.SetError(IP_text, "Введенные данные не являются IP адресом.");
                }
                else
                {
                    addIpAddrErrProv.Clear();
                }
            }
        }    
    }
}
