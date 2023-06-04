using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Pinger
{
    public partial class PeerEditForm : Form
    {
        public PeerEditForm()
        {
            InitializeComponent();
        }
        private void Edit_IP_button_Click(object sender, EventArgs e)
        {
            if (hostname_text.Text != "" && location_text.Text != "" && IPAddrVerificator.Verified(IP_text.Text))
            {
                ThePeer peer = this.Owner.ActiveControl as ThePeer;
                List<PeerInfo> peersToSave = new List<PeerInfo>();
                //если меняется IP - очищаем лог.
                if (peer.peerIpAddress != this.IP_text.Text)
                {
                    peer.Results.Clear();
                    peer.wasOffline = false;
                }

                peer.peerHostName = this.hostname_text.Text;
                peer.peerComment = this.location_text.Text;
                peer.peerIpAddress = this.IP_text.Text;
                peer.ToolTip.SetToolTip(peer.PeerHeader, peer.peerComment);
                peer.ToolTip.SetToolTip(peer.PeerStatus, peer.peerComment);

                for (int i = 0; i < this.Owner.Controls.Count; i++)
                {
                    if (this.Owner.Controls[i] is ThePeer)
                    {
                        peersToSave.Add(new PeerInfo((this.Owner.Controls[i] as ThePeer).peerHostName,
                                                        (this.Owner.Controls[i] as ThePeer).peerIpAddress,
                                                        (this.Owner.Controls[i] as ThePeer).peerComment,
                                                        (this.Owner.Controls[i].Location)));
                    }
                }

                peersToSave.Sort();
                PeerFileHandler.SavePeers(peersToSave, "Peers.txt");
                MainForm.ArrangeElements((Pinger.MainForm)this.Owner);
                this.Close();
            }
            else
            {
                if (hostname_text.Text == string.Empty)
                {
                    EditHostnameErrProv.SetError(hostname_text, "Укажите наименование узла.");
                }
                else
                {
                    EditHostnameErrProv.Clear();
                }
                if (location_text.Text == string.Empty)
                {
                   EditLocationErrProv.SetError(location_text, "Укажите комментарий к узлу.");
                }
                else
                {
                   EditLocationErrProv.Clear();
                }
                if (!IPAddrVerificator.Verified(IP_text.Text))
                {
                    EditIpAddrErrProv.SetError(IP_text, "Введенные данные не являются IP адресом.");
                }
                else
                {
                    EditIpAddrErrProv.Clear();
                }
            }
        }
    }
}
