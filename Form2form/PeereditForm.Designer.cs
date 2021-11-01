namespace Pinger
{
    partial class PeereditForm
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_text = new System.Windows.Forms.TextBox();
            this.hostname_text = new System.Windows.Forms.TextBox();
            this.Edit_IP_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.location_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя узла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP адрес";
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(155, 25);
            this.IP_text.MaxLength = 15;
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(110, 20);
            this.IP_text.TabIndex = 2;
            // 
            // hostname_text
            // 
            this.hostname_text.Location = new System.Drawing.Point(15, 25);
            this.hostname_text.MaxLength = 64;
            this.hostname_text.Name = "hostname_text";
            this.hostname_text.Size = new System.Drawing.Size(135, 20);
            this.hostname_text.TabIndex = 1;
            // 
            // Edit_IP_button
            // 
            this.Edit_IP_button.Location = new System.Drawing.Point(155, 130);
            this.Edit_IP_button.Name = "Edit_IP_button";
            this.Edit_IP_button.Size = new System.Drawing.Size(110, 25);
            this.Edit_IP_button.TabIndex = 4;
            this.Edit_IP_button.Text = "Редактировать";
            this.Edit_IP_button.UseVisualStyleBackColor = true;
            this.Edit_IP_button.Click += new System.EventHandler(this.Edit_IP_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Расположение (комментарий)";
            // 
            // location_text
            // 
            this.location_text.Location = new System.Drawing.Point(15, 75);
            this.location_text.Multiline = true;
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(250, 50);
            this.location_text.TabIndex = 3;
            // 
            // PeereditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Edit_IP_button);
            this.Controls.Add(this.hostname_text);
            this.Controls.Add(this.IP_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeereditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование узла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IP_text;
        public System.Windows.Forms.TextBox hostname_text;
        public System.Windows.Forms.Button Edit_IP_button;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox location_text;
    }
}