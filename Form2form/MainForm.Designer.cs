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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.загрузитьКоординатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРасположениеЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перечитатьУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокУзловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.координатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mainmenu.SuspendLayout();
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
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseMove);
            // 
            // Mainmenu
            // 
            this.Mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКоординатыToolStripMenuItem,
            this.сохранитьРасположениеЭлементовToolStripMenuItem,
            this.перечитатьУзлыToolStripMenuItem,
            this.списокУзловToolStripMenuItem,
            this.координатыToolStripMenuItem,
            this.узлыToolStripMenuItem,
            this.справкаToolStripMenuItem1,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem2});
            this.Mainmenu.Name = "Mainmenu";
            this.Mainmenu.Size = new System.Drawing.Size(281, 186);
            // 
            // загрузитьКоординатыToolStripMenuItem
            // 
            this.загрузитьКоординатыToolStripMenuItem.Name = "загрузитьКоординатыToolStripMenuItem";
            this.загрузитьКоординатыToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.загрузитьКоординатыToolStripMenuItem.Text = "Загрузить расположение элементов";
            this.загрузитьКоординатыToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКоординатыToolStripMenuItem_Click);
            // 
            // сохранитьРасположениеЭлементовToolStripMenuItem
            // 
            this.сохранитьРасположениеЭлементовToolStripMenuItem.Name = "сохранитьРасположениеЭлементовToolStripMenuItem";
            this.сохранитьРасположениеЭлементовToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.сохранитьРасположениеЭлементовToolStripMenuItem.Text = "Сохранить расположение элементов";
            this.сохранитьРасположениеЭлементовToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРасположениеЭлементовToolStripMenuItem_Click);
            // 
            // перечитатьУзлыToolStripMenuItem
            // 
            this.перечитатьУзлыToolStripMenuItem.Name = "перечитатьУзлыToolStripMenuItem";
            this.перечитатьУзлыToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.перечитатьУзлыToolStripMenuItem.Text = "Перечитать из файла";
            this.перечитатьУзлыToolStripMenuItem.Click += new System.EventHandler(this.перечитатьУзлыToolStripMenuItem_Click);
            // 
            // списокУзловToolStripMenuItem
            // 
            this.списокУзловToolStripMenuItem.Name = "списокУзловToolStripMenuItem";
            this.списокУзловToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.списокУзловToolStripMenuItem.Text = "Список узлов";
            this.списокУзловToolStripMenuItem.Click += new System.EventHandler(this.списокУзловToolStripMenuItem_Click);
            // 
            // координатыToolStripMenuItem
            // 
            this.координатыToolStripMenuItem.Name = "координатыToolStripMenuItem";
            this.координатыToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.координатыToolStripMenuItem.Text = "Открыть файл с координатами";
            this.координатыToolStripMenuItem.Click += new System.EventHandler(this.координатыToolStripMenuItem_Click);
            // 
            // узлыToolStripMenuItem
            // 
            this.узлыToolStripMenuItem.Name = "узлыToolStripMenuItem";
            this.узлыToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.узлыToolStripMenuItem.Text = "Открыть файл с узлами";
            this.узлыToolStripMenuItem.Click += new System.EventHandler(this.узлыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(280, 22);
            this.справкаToolStripMenuItem1.Text = "О программе...";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // выходToolStripMenuItem2
            // 
            this.выходToolStripMenuItem2.Name = "выходToolStripMenuItem2";
            this.выходToolStripMenuItem2.Size = new System.Drawing.Size(280, 22);
            this.выходToolStripMenuItem2.Text = "Выход";
            this.выходToolStripMenuItem2.Click += new System.EventHandler(this.выходToolStripMenuItem2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.ContextMenuStrip = this.Mainmenu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мониторинг сетевого оборудования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Mainmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem добавитьАТМToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аТМToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Mainmenu;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКоординатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРасположениеЭлементовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокУзловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem перечитатьУзлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem координатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem узлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

