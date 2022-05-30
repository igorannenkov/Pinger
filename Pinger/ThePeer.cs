using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Pinger
{
    public partial class ThePeer : UserControl, IComparable
    {
        public ThePeer()
        {
            InitializeComponent();
        }
        // глубина логгирования состояния узла
        static int capacity = 20;
        // максимальное число попыток пинга, после которых узел считается недоступным
        int ATTEMPTS = 4;
        public List<string> Results = new List<string>(capacity);
        public bool wasOffline = false;
        public DateTime Alarmtime = DateTime.Now;
        TimeSpan Alarmed = new TimeSpan();
        Ping PingSender = new Ping();
        Point prevMousePosition;

        public string peerHostName;
        public string peerHostStatus;
        public string peerIpAddress;
        public string peerComment;

        public int CompareTo(object o)
        {
            if (o is ThePeer peer)
            {
                return peerHostName.CompareTo(peer.peerHostName);
            }
            else throw new ArgumentException("Некорректное значение параметра.");
        }

        private void PeerControl_Load(object sender, EventArgs e)
        {
            pingerAsync(peerHostName, peerIpAddress);
            this.ToolTip.SetToolTip(this.PeerHeader, peerComment);
            this.ToolTip.SetToolTip(this.PeerStatus, peerComment);
            MainTimer.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pingerAsync(peerHostName, peerIpAddress);
        }
        private void pingerAsync(string hostname, string ip)
        {
            PeerHeader.Text = hostname;
            if (Results.Count > 0)
            {
                PeerHeader.Text = "[" + Results.Count + "] " + hostname;
            }

            try
            {
                PingSender.SendAsync(ip, hostname);
            }
            catch (InvalidOperationException)
            {
                //  MessageBox.Show("Упс...");
            }
            catch (NullReferenceException)
            {
                //  MessageBox.Show("Упс...");
            }
            PingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
        }
        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            if(this.ParentForm !=null)
            {
                switch (e.Reply.Status)
                {
                    case IPStatus.Success:
                    {
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        PeerHeader.BackColor = Color.PaleGreen;
                        PeerStatus.Text = e.Reply.Address.ToString() + " - " + e.Reply.RoundtripTime.ToString() + " мс";
                        PeerStatus.BackColor = Color.White;                       
                        if (e.Reply.RoundtripTime > 500) //Если пинг более 500мс - следует обратить внимание (подкрасим оранжевым)
                        {
                            PeerStatus.BackColor = Color.Orange;
                        }
                        if (wasOffline)
                        {
                            Alarmed = DateTime.Now - Alarmtime;
                            wasOffline = false;
                            if (Results.Count == capacity)
                            {
                                Results.RemoveAt(0);
                            }
                            Results.Add($"{peerHostName} \t {e.Reply.Address} \t {e.Reply.Status} \t {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ( {Alarmed.Days} д. {Alarmed.Hours} ч. {Alarmed.Minutes} м. {Alarmed.Seconds} с.)");
                            if (Alarmed.Days == 0 && Alarmed.Hours == 0 && Alarmed.Minutes == 0 && Alarmed.Seconds == 0)
                            {
                                Results.RemoveAt(Results.Count - 1); //удаляем элементы после "ложной тревоги" (фиксацию онлайн и оффлайн)
                                Results.RemoveAt(Results.Count - 1);

                                if (Results.Count == 0)
                                {
                                        PeerHeader.BackColor = Color.PaleGreen;
                                }
                                break;
                            }
                        }
                        break;
                    }
                    case IPStatus.DestinationHostUnreachable:
                    {
                        PeerStatus.Text = peerIpAddress + " - DestHostUnreachable";
                        PeerHeader.BackColor = Color.Salmon;
                        PeerStatus.BackColor = Color.Pink;        
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        /*
                            this.ParentForm.Controls.IndexOf(this)
                            Это индекс контрола в массиве контролов формы.
                        */
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.DestinationNetworkUnreachable:
                    {
                        PeerStatus.Text = peerIpAddress + " - DestinationNetworkUnreachable";
                        PeerHeader.BackColor = Color.Salmon;
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.HardwareError:
                    {
                        PeerStatus.Text = peerIpAddress + " - HardwareError";
                        PeerHeader.BackColor = Color.Salmon;
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.TimedOut:
                    {
                        PeerStatus.Text = peerIpAddress + " - TimedOut";
                        PeerHeader.BackColor = Color.Salmon;
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.TtlExpired:
                    {
                        PeerStatus.Text = peerIpAddress + " - TtlExpired";
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.BadDestination:
                    {
                        PeerStatus.Text = peerIpAddress + " - BadDestination";
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    case IPStatus.Unknown:
                    {
                        PeerStatus.Text = peerIpAddress + " - Unknown";
                        PeerStatus.BackColor = Color.Pink;
                        MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                        if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                        {
                            if (!wasOffline)
                            {
                                if (Results.Count == capacity)
                                {
                                    Results.RemoveAt(0);
                                }
                                Alarmtime = DateTime.Now;
                                Results.Add($"{peerHostName} \t {peerIpAddress} \t {e.Reply.Status} \t {Alarmtime}");
                                wasOffline = true;
                            }
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                        }
                        break;
                    }
                    default:
                    break;
                }
            }
        }
        private void ShowHistory()
        {
            PeerLogForm HistoryForm = new PeerLogForm();
            HistoryForm.Text = this.PeerHeader.Text + " - история";
            for (int i = 0; i < Results.Count; i++)
            {
                HistoryForm.richTextBox1.Text += Results.ToArray()[i] + "\r\n";
            }
            HistoryForm.StartPosition = FormStartPosition.CenterParent;
            HistoryForm.ShowDialog();
        }
       
        private void PingHeader_DoubleClick(object sender, EventArgs e)
        {
            ShowHistory();
        }
        private void PingResult_DoubleClick(object sender, EventArgs e)
        {
            ShowHistory();
        }
        private void PingResult_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                prevMousePosition = Control.MousePosition;
                this.Cursor = Cursors.SizeAll;
                this.BringToFront();               
            }
        }
        private void PingResult_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point p = Control.MousePosition;
                this.Left += p.X - prevMousePosition.X;
                this.Top += p.Y - prevMousePosition.Y;
                prevMousePosition = p;
            }
        }
        private void PingResult_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cursor = Cursors.Default;
        }
        private void peer_name_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                prevMousePosition = Control.MousePosition;
                this.Cursor = Cursors.SizeAll;
                this.BringToFront();
            }  
        }
        private void peer_name_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Cursor = Cursors.Default;
        }
        private void peer_name_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point p = Control.MousePosition;
                this.Left += p.X - prevMousePosition.X;
                this.Top += p.Y - prevMousePosition.Y;
                prevMousePosition = p;
            }
        }

        private void ShowElementHistory_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }
        private void ClearLog_Click(object sender, EventArgs e)
        {
            if (Results.Count > 0)
            {
                Results.Clear();
                string temp = PeerHeader.Text;
                temp = temp.Substring(temp.IndexOf(" "));
                PeerHeader.Text = temp;
                PeerHeader.BackColor = Color.PaleGreen;
            }
        }

        private void ConsolePing_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe", "/C ping " + PeerStatus.Text.Substring(0, PeerStatus.Text.IndexOf(" ")) + " -t");
            }
            catch (ArgumentOutOfRangeException)
            {
                //пока игнорируем, ждем ответа от хоста
            }
        }

        private void EditElement_Click(object sender, EventArgs e)
        {
            PeerEditForm pef = new PeerEditForm();
            pef.Text = "Редактирование узла";
            pef.hostname_text.Text = this.peerHostName;
            pef.IP_text.Text = this.peerIpAddress;
            pef.location_text.Text = this.peerComment;
            pef.StartPosition = FormStartPosition.CenterParent;
            pef.ShowDialog(this);
        }

        private void RemoveElement_Click(object sender, EventArgs e)
        {
            string message = $"Вы действительно хотите удалить элемент {this.peerHostName}? Восстановление будет невозможно.";
            const string caption = "Удаление элемента";
            const string filename = "Peers.txt";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainForm mf = (Pinger.MainForm)this.ParentForm;
                List<PeerInfo> peers = PeerFileHandler.ReadPeers(filename);
                peers.Remove(peers.Find(p => p.Name == (this.peerHostName)));
                PeerFileHandler.SavePeers(peers, filename);
                this.Parent.Controls.Remove(this);
                MainForm.ArrangeElements(mf);
            }
        }
    }
}