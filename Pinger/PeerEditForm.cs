﻿using System;
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
            if (hostname_text.Text.ToString() != "" && location_text.Text.ToString() != "" && IPAddressValidator.ValidateFromString(IP_text.Text))
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
                //"мигаем" 3 раза, если что-то некорректно заполнено
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
