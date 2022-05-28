
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
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обменПакетамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.историяToolStripMenuItem,
            this.toolStripSeparator1,
            this.очиститьИсториюToolStripMenuItem,
            this.обменПакетамиToolStripMenuItem,
            this.Edit,
            this.Remove});
            this.PeerMenu.Name = "PeerMenu";
            this.PeerMenu.Size = new System.Drawing.Size(179, 120);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.историяToolStripMenuItem.Text = "История...";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // очиститьИсториюToolStripMenuItem
            // 
            this.очиститьИсториюToolStripMenuItem.Name = "очиститьИсториюToolStripMenuItem";
            this.очиститьИсториюToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.очиститьИсториюToolStripMenuItem.Text = "Очистить историю";
            this.очиститьИсториюToolStripMenuItem.Click += new System.EventHandler(this.очиститьИсториюToolStripMenuItem_Click);
            // 
            // обменПакетамиToolStripMenuItem
            // 
            this.обменПакетамиToolStripMenuItem.Name = "обменПакетамиToolStripMenuItem";
            this.обменПакетамиToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.обменПакетамиToolStripMenuItem.Text = "Обмен пакетами...";
            this.обменПакетамиToolStripMenuItem.Click += new System.EventHandler(this.обменПакетамиToolStripMenuItem_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(178, 22);
            this.Edit.Text = "Редактировать";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(178, 22);
            this.Remove.Text = "Удалить";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
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
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem очиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обменПакетамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Remove;
        public System.Windows.Forms.ToolTip ToolTip;
    }
}
