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
            this.перечитатьУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокУзловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьПоСеткеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.NotifyIcon.Text = "Мониторинг сетевого оборудования";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // перечитатьУзлыToolStripMenuItem
            // 
            this.перечитатьУзлыToolStripMenuItem.Name = "перечитатьУзлыToolStripMenuItem";
            this.перечитатьУзлыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.перечитатьУзлыToolStripMenuItem.Text = "Перезагрузить приложение";
            this.перечитатьУзлыToolStripMenuItem.Click += new System.EventHandler(this.перечитатьУзлыToolStripMenuItem_Click);
            // 
            // списокУзловToolStripMenuItem
            // 
            this.списокУзловToolStripMenuItem.Name = "списокУзловToolStripMenuItem";
            this.списокУзловToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.списокУзловToolStripMenuItem.Text = "Список узлов";
            // 
            // узлыToolStripMenuItem
            // 
            this.узлыToolStripMenuItem.Name = "узлыToolStripMenuItem";
            this.узлыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.узлыToolStripMenuItem.Text = "Открыть файл данных";
            this.узлыToolStripMenuItem.Click += new System.EventHandler(this.узлыToolStripMenuItem_Click);
            // 
            // выровнятьПоСеткеToolStripMenuItem
            // 
            this.выровнятьПоСеткеToolStripMenuItem.Name = "выровнятьПоСеткеToolStripMenuItem";
            this.выровнятьПоСеткеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.выровнятьПоСеткеToolStripMenuItem.Text = "Выровнять автоматически";
            this.выровнятьПоСеткеToolStripMenuItem.Click += new System.EventHandler(this.выровнятьПоСеткеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.справкаToolStripMenuItem1.Text = "О программе...";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // выходToolStripMenuItem2
            // 
            this.выходToolStripMenuItem2.Name = "выходToolStripMenuItem2";
            this.выходToolStripMenuItem2.Size = new System.Drawing.Size(231, 22);
            this.выходToolStripMenuItem2.Text = "Выход";
            this.выходToolStripMenuItem2.Click += new System.EventHandler(this.выходToolStripMenuItem2_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭлементToolStripMenuItem,
            this.SaveConfig,
            this.LoadConfig,
            this.выровнятьПоСеткеToolStripMenuItem,
            this.узлыToolStripMenuItem,
            this.списокУзловToolStripMenuItem,
            this.справкаToolStripMenuItem1,
            this.toolStripSeparator1,
            this.перечитатьУзлыToolStripMenuItem,
            this.выходToolStripMenuItem2});
            this.MainMenu.Name = "Mainmenu";
            this.MainMenu.Size = new System.Drawing.Size(228, 230);
            // 
            // SaveConfig
            // 
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.Size = new System.Drawing.Size(227, 22);
            this.SaveConfig.Text = "Сохранить расположение";
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // LoadConfig
            // 
            this.LoadConfig.Name = "LoadConfig";
            this.LoadConfig.Size = new System.Drawing.Size(227, 22);
            this.LoadConfig.Text = "Загрузить расположение";
            this.LoadConfig.Click += new System.EventHandler(this.LoadConfig_Click);
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            this.добавитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементToolStripMenuItem_Click);
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
            this.Text = "Мониторинг сетевого оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem добавитьАТМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аТМToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem перечитатьУзлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокУзловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem узлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьПоСеткеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveConfig;
        private System.Windows.Forms.ToolStripMenuItem LoadConfig;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
    }
}

