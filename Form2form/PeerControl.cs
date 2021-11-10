using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Pinger
{
    public partial class PeerControl : UserControl
    {
        public PeerControl()
        {
            InitializeComponent();
        }
        int CAPACITY = 50;// глубина логгирования состояния узла
        int ATTEMPTS = 4;// максимальное число попыток пинга, после которых узел считается недоступным
        public List<string> Results = new List<string>(20);
        public bool wasOffline = false;
        public DateTime Alarmtime = DateTime.Now;
        TimeSpan Alarmed = new TimeSpan();
        Ping PingSender = new Ping();
        Point prevMousePosition;      
        private void PeerControl_Load(object sender, EventArgs e)
        {
            string[] data = this.Tag.ToString().Split(';');
            string hostname = data[0];
            string ip = data[1];
            pingerAsync(hostname, ip);
            this.toolTip.SetToolTip(this.PingHeader, this.Tag.ToString().Split(';')[2]);
            this.toolTip.SetToolTip(this.PingResult, this.Tag.ToString().Split(';')[2]);
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] data = this.Tag.ToString().Split(';');
            string hostname = data[0];
            string ip = data[1];
            pingerAsync(hostname, ip);
        }
        private void pingerAsync(string hostname, string ip)
        {
            PingHeader.Text = hostname;
            if (Results.Count > 0)
            {
                PingHeader.Text = "[" + Results.Count + "] " + hostname;
                PingHeader.BackColor = Color.Pink;
            }
            if (ip == "Не задан")
            {
                PingResult.BackColor = Color.Gray;
            }
            else
            {
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
        }
        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            string[] data = this.Tag.ToString().Split(';');
            if (data.Length > 1) // данные временно храним в заголовке формы
            {
                switch (e.Reply.Status)
                {
                    case IPStatus.Success:
                        {


                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;

                            //[ActiveForm.Controls.IndexOf(, this)] = 0;

                            PingResult.Text = e.Reply.Address.ToString() + " - " + e.Reply.RoundtripTime.ToString() + " мс";
                            PingResult.BackColor = Color.White;
                            if (e.Reply.RoundtripTime > 500) //Если пинг более 500мс - следует обратить внимание (подкрасим оранжевым)
                            {
                                PingResult.BackColor = Color.Orange;
                            }
                            if (wasOffline)
                            {
                                Alarmed = DateTime.Now - Alarmtime;
                                wasOffline = false;
                                if (Results.Count == CAPACITY)
                                {
                                    Results.RemoveAt(0);
                                }
                                Results.Add($"{data[0]} \t {e.Reply.Address} \t {e.Reply.Status} \t\t {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()} ( {Alarmed.Days} д. {Alarmed.Hours} ч. {Alarmed.Minutes} м. {Alarmed.Seconds} с.)");
                                if (Alarmed.Days == 0 && Alarmed.Hours == 0 && Alarmed.Minutes == 0 && Alarmed.Seconds == 0)
                                {
                                    Results.RemoveAt(Results.Count - 1); //удаляем элементы после "ложной тревоги"
                                    Results.RemoveAt(Results.Count - 1);

                                    if (Results.Count == 0)
                                    {
                                        PingHeader.BackColor = Color.FromArgb(192, 255, 255);
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    case IPStatus.DestinationHostUnreachable:
                        {
                            PingResult.Text = data[1] + " - DestHostUnreachable";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            /*
                             * Array.IndexOf(this.ParentForm.MdiChildren, this) 
                             * Это индекс дочерней формы в массиве дочерних форм.
                             */
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.DestinationNetworkUnreachable:
                        {
                            PingResult.Text = data[1] + " - DestinationNetworkUnreachable";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.HardwareError:
                        {
                            PingResult.Text = data[1] + " - HardwareError";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.TimedOut:
                        {
                            PingResult.Text = data[1] + " - TimedOut";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.TtlExpired:
                        {
                            PingResult.Text = data[1] + " - TtlExpired";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.BadDestination:
                        {
                            PingResult.Text = data[1] + " - BadDestination";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
                                    wasOffline = true;
                                }
                                MainForm.failures[this.ParentForm.Controls.IndexOf(this)] = 0;
                            }
                            break;
                        }
                    case IPStatus.Unknown:
                        {
                            PingResult.Text = data[1] + " - Unknown";
                            PingResult.BackColor = Color.Red;
                            MainForm.failures[this.ParentForm.Controls.IndexOf(this)]++;
                            if (MainForm.failures[this.ParentForm.Controls.IndexOf(this)] == ATTEMPTS)
                            {
                                if (!wasOffline)
                                {
                                    if (Results.Count == CAPACITY)
                                    {
                                        Results.RemoveAt(0);
                                    }
                                    Alarmtime = DateTime.Now;
                                    Results.Add($"{data[0]} \t {data[1]} \t {e.Reply.Status} \t {Alarmtime}");
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
            PeerhistoryForm HistoryForm = new PeerhistoryForm();
            HistoryForm.Text = this.PingHeader.Text + " - история";
            for (int i = 0; i < Results.Count; i++)
            {
                // HistoryForm.Owner = this;
                HistoryForm.richTextBox1.Text += Results.ToArray()[i] + "\r\n";
            }
            HistoryForm.StartPosition = FormStartPosition.CenterParent;
            HistoryForm.ShowDialog();
        }
        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }
        private void очиститьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Results.Count > 0)
            {
                Results.Clear();
                string temp = PingHeader.Text;
                temp = temp.Substring(temp.IndexOf(" "));
                PingHeader.Text = temp;
                PingHeader.BackColor = Color.FromArgb(192, 255, 255);
            }
        }
        private void обменПакетамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe", "/C ping " + PingResult.Text.Substring(0, PingResult.Text.IndexOf(" ")) + " -t");
            }
            catch (ArgumentOutOfRangeException)
            {
                //пока игнорируем, ждем ответа от хоста
            }
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

    }
}
