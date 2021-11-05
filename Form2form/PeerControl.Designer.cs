
namespace Pinger
{
    partial class PeerControl
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
            this.PingHeader = new System.Windows.Forms.Label();
            this.PeerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обменПакетамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PingResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PeerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PingHeader
            // 
            this.PingHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PingHeader.ContextMenuStrip = this.PeerMenu;
            this.PingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingHeader.Location = new System.Drawing.Point(0, 0);
            this.PingHeader.Name = "PingHeader";
            this.PingHeader.Size = new System.Drawing.Size(135, 15);
            this.PingHeader.TabIndex = 0;
            this.PingHeader.Text = "Загрузка...";
            this.PingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PingHeader.DoubleClick += new System.EventHandler(this.PingHeader_DoubleClick);
            this.PingHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseDown);
            this.PingHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseMove);
            this.PingHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.peer_name_MouseUp);
            // 
            // PeerMenu
            // 
            this.PeerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяToolStripMenuItem,
            this.toolStripSeparator1,
            this.очиститьИсториюToolStripMenuItem,
            this.обменПакетамиToolStripMenuItem});
            this.PeerMenu.Name = "PeerMenu";
            this.PeerMenu.Size = new System.Drawing.Size(179, 76);
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
            // PingResult
            // 
            this.PingResult.BackColor = System.Drawing.Color.White;
            this.PingResult.ContextMenuStrip = this.PeerMenu;
            this.PingResult.Location = new System.Drawing.Point(0, 15);
            this.PingResult.Name = "PingResult";
            this.PingResult.Size = new System.Drawing.Size(135, 17);
            this.PingResult.TabIndex = 0;
            this.PingResult.Text = "Загрузка...";
            this.PingResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PingResult.DoubleClick += new System.EventHandler(this.PingResult_DoubleClick);
            this.PingResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseDown);
            this.PingResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseMove);
            this.PingResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PingResult_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PeerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PingResult);
            this.Controls.Add(this.PingHeader);
            this.Name = "PeerControl";
            this.Size = new System.Drawing.Size(133, 32);
            this.Load += new System.EventHandler(this.PeerControl_Load);
            this.PeerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label PingHeader;
        public System.Windows.Forms.Label PingResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip PeerMenu;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem очиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обменПакетамиToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
