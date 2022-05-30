
namespace Pinger
{
    partial class ThePeer
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PeerHeader = new System.Windows.Forms.Label();
            this.PeerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowElementHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsolePing = new System.Windows.Forms.ToolStripMenuItem();
            this.EditElement = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveElement = new System.Windows.Forms.ToolStripMenuItem();
            this.PeerStatus = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PeerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeerHeader
            // 
            this.PeerHeader.BackColor = System.Drawing.Color.PaleGreen;
            this.PeerHeader.ContextMenuStrip = this.PeerMenu;
            this.PeerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeerHeader.Location = new System.Drawing.Point(0, 0);
            this.PeerHeader.Name = "PeerHeader";
            this.PeerHeader.Size = new System.Drawing.Size(140, 18);
            this.PeerHeader.TabIndex = 0;
            this.PeerHeader.Text = "Загрузка...";
            this.PeerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PeerHeader.DoubleClick += new System.EventHandler(this.PingHeader_DoubleClick);
            this.PeerHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseDown);
            this.PeerHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseMove);
            this.PeerHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseUp);
            // 
            // PeerMenu
            // 
            this.PeerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowElementHistory,
            this.toolStripSeparator1,
            this.ClearLog,
            this.ConsolePing,
            this.EditElement,
            this.RemoveElement});
            this.PeerMenu.Name = "PeerMenu";
            this.PeerMenu.Size = new System.Drawing.Size(177, 120);
            // 
            // ShowElementHistory
            // 
            this.ShowElementHistory.Name = "ShowElementHistory";
            this.ShowElementHistory.Size = new System.Drawing.Size(176, 22);
            this.ShowElementHistory.Text = "История...";
            this.ShowElementHistory.Click += new System.EventHandler(this.ShowElementHistory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // ClearLog
            // 
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(176, 22);
            this.ClearLog.Text = "Очистить лог";
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // ConsolePing
            // 
            this.ConsolePing.Name = "ConsolePing";
            this.ConsolePing.Size = new System.Drawing.Size(176, 22);
            this.ConsolePing.Text = "Обмен пакетами...";
            this.ConsolePing.Click += new System.EventHandler(this.ConsolePing_Click);
            // 
            // EditElement
            // 
            this.EditElement.Name = "EditElement";
            this.EditElement.Size = new System.Drawing.Size(176, 22);
            this.EditElement.Text = "Редактировать";
            this.EditElement.Click += new System.EventHandler(this.EditElement_Click);
            // 
            // RemoveElement
            // 
            this.RemoveElement.Name = "RemoveElement";
            this.RemoveElement.Size = new System.Drawing.Size(176, 22);
            this.RemoveElement.Text = "Удалить";
            this.RemoveElement.Click += new System.EventHandler(this.RemoveElement_Click);
            // 
            // PeerStatus
            // 
            this.PeerStatus.AutoEllipsis = true;
            this.PeerStatus.BackColor = System.Drawing.Color.White;
            this.PeerStatus.ContextMenuStrip = this.PeerMenu;
            this.PeerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeerStatus.Location = new System.Drawing.Point(0, 18);
            this.PeerStatus.Name = "PeerStatus";
            this.PeerStatus.Size = new System.Drawing.Size(140, 18);
            this.PeerStatus.TabIndex = 0;
            this.PeerStatus.Text = "Загрузка...";
            this.PeerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PeerStatus.DoubleClick += new System.EventHandler(this.PingResult_DoubleClick);
            this.PeerStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseDown);
            this.PeerStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseMove);
            this.PeerStatus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseUp);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 5000;
            this.MainTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ThePeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PeerStatus);
            this.Controls.Add(this.PeerHeader);
            this.Name = "ThePeer";
            this.Size = new System.Drawing.Size(140, 38);
            this.Load += new System.EventHandler(this.PeerControl_Load);
            this.PeerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label PeerHeader;
        public System.Windows.Forms.Label PeerStatus;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ContextMenuStrip PeerMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowElementHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ClearLog;
        private System.Windows.Forms.ToolStripMenuItem ConsolePing;
        private System.Windows.Forms.ToolStripMenuItem EditElement;
        private System.Windows.Forms.ToolStripMenuItem RemoveElement;
        public System.Windows.Forms.ToolTip ToolTip;
    }
}
