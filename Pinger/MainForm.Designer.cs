namespace Pinger
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.добавитьАТМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аТМToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.RestartApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSourceFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganizeElements = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddElement = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveElements = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadElements = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // добавитьАТМToolStripMenuItem
            // 
            this.добавитьАТМToolStripMenuItem.Name = "добавитьАТМToolStripMenuItem";
            this.добавитьАТМToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // аТМToolStripMenuItem
            // 
            this.аТМToolStripMenuItem.Name = "аТМToolStripMenuItem";
            this.аТМToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.аТМToolStripMenuItem.Text = "АТМ";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Мониторинг доступности сетевого оборудования";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // RestartApplication
            // 
            this.RestartApplication.Name = "RestartApplication";
            this.RestartApplication.Size = new System.Drawing.Size(227, 22);
            this.RestartApplication.Text = "Перезагрузить приложение";
            this.RestartApplication.Click += new System.EventHandler(this.RestartApplication_Click);
            // 
            // OpenSourceFile
            // 
            this.OpenSourceFile.Name = "OpenSourceFile";
            this.OpenSourceFile.Size = new System.Drawing.Size(227, 22);
            this.OpenSourceFile.Text = "Открыть файл данных";
            this.OpenSourceFile.Click += new System.EventHandler(this.OpenSourceFile_Click);
            // 
            // OrganizeElements
            // 
            this.OrganizeElements.Name = "OrganizeElements";
            this.OrganizeElements.Size = new System.Drawing.Size(227, 22);
            this.OrganizeElements.Text = "Упорядочить элементы";
            this.OrganizeElements.Click += new System.EventHandler(this.OrganizeElements_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(227, 22);
            this.About.Text = "О программе...";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(227, 22);
            this.ExitApplication.Text = "Выход";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElement,
            this.SaveElements,
            this.LoadElements,
            this.OrganizeElements,
            this.OpenSourceFile,
            this.About,
            this.toolStripSeparator1,
            this.RestartApplication,
            this.ExitApplication});
            this.MainMenu.Name = "Mainmenu";
            this.MainMenu.Size = new System.Drawing.Size(228, 186);
            // 
            // AddElement
            // 
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(227, 22);
            this.AddElement.Text = "Добавить элемент";
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // SaveElements
            // 
            this.SaveElements.Name = "SaveElements";
            this.SaveElements.Size = new System.Drawing.Size(227, 22);
            this.SaveElements.Text = "Сохранить расположение";
            this.SaveElements.Click += new System.EventHandler(this.SaveElements_Click);
            // 
            // LoadElements
            // 
            this.LoadElements.Name = "LoadElements";
            this.LoadElements.Size = new System.Drawing.Size(227, 22);
            this.LoadElements.Text = "Загрузить расположение";
            this.LoadElements.Click += new System.EventHandler(this.LoadElements_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.ContextMenuStrip = this.MainMenu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг доступности сетевого оборудования 1.2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem добавитьАТМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аТМToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem RestartApplication;
        private System.Windows.Forms.ToolStripMenuItem OpenSourceFile;
        private System.Windows.Forms.ToolStripMenuItem OrganizeElements;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveElements;
        private System.Windows.Forms.ToolStripMenuItem LoadElements;
        private System.Windows.Forms.ToolStripMenuItem AddElement;
    }
}

