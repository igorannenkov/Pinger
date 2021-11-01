namespace Pinger
{
    partial class PeerstatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PingHeader = new System.Windows.Forms.Label();
            this.PingResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВКонсолиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PingHeader
            // 
            this.PingHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingHeader.Location = new System.Drawing.Point(0, 0);
            this.PingHeader.Name = "PingHeader";
            this.PingHeader.Size = new System.Drawing.Size(135, 13);
            this.PingHeader.TabIndex = 1;
            this.PingHeader.Text = "Загрузка...";
            this.PingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PingHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.PingHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.PingHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // PingResult
            // 
            this.PingResult.AutoEllipsis = true;
            this.PingResult.BackColor = System.Drawing.Color.White;
            this.PingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingResult.Location = new System.Drawing.Point(0, 13);
            this.PingResult.Name = "PingResult";
            this.PingResult.Size = new System.Drawing.Size(135, 15);
            this.PingResult.TabIndex = 2;
            this.PingResult.Text = "Загрузка...";
            this.PingResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PingResult.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяToolStripMenuItem,
            this.очиститьИсториюToolStripMenuItem,
            this.открытьВКонсолиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 70);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.историяToolStripMenuItem.Text = "История...";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // очиститьИсториюToolStripMenuItem
            // 
            this.очиститьИсториюToolStripMenuItem.Name = "очиститьИсториюToolStripMenuItem";
            this.очиститьИсториюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.очиститьИсториюToolStripMenuItem.Text = "Очистить историю";
            this.очиститьИсториюToolStripMenuItem.Click += new System.EventHandler(this.очиститьИсториюToolStripMenuItem_Click);
            // 
            // открытьВКонсолиToolStripMenuItem
            // 
            this.открытьВКонсолиToolStripMenuItem.Name = "открытьВКонсолиToolStripMenuItem";
            this.открытьВКонсолиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.открытьВКонсолиToolStripMenuItem.Text = "Обмен пакетами через консоль";
            this.открытьВКонсолиToolStripMenuItem.Click += new System.EventHandler(this.открытьВКонсолиToolStripMenuItem_Click);
            // 
            // PeerstatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(135, 26);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.PingResult);
            this.Controls.Add(this.PingHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(135, 26);
            this.MinimizeBox = false;
            this.Name = "PeerstatusForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label PingHeader;
        public System.Windows.Forms.Label PingResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВКонсолиToolStripMenuItem;
    }
}