﻿namespace Pinger
{
    partial class AddPeerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.hostname_text = new System.Windows.Forms.TextBox();
            this.location_text = new System.Windows.Forms.TextBox();
            this.IP_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addHostnameErrProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.addIpAddrErrProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.addLocationErrProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addHostnameErrProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIpAddrErrProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLocationErrProv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hostname_text
            // 
            this.hostname_text.Location = new System.Drawing.Point(12, 25);
            this.hostname_text.Name = "hostname_text";
            this.hostname_text.Size = new System.Drawing.Size(135, 20);
            this.hostname_text.TabIndex = 1;
            // 
            // location_text
            // 
            this.location_text.Location = new System.Drawing.Point(12, 75);
            this.location_text.Multiline = true;
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(266, 50);
            this.location_text.TabIndex = 3;
            // 
            // IP_text
            // 
            this.IP_text.Location = new System.Drawing.Point(168, 25);
            this.IP_text.Name = "IP_text";
            this.IP_text.Size = new System.Drawing.Size(110, 20);
            this.IP_text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя узла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Расположение (комментарий)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP адрес";
            // 
            // addHostnameErrProv
            // 
            this.addHostnameErrProv.BlinkRate = 50;
            this.addHostnameErrProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addHostnameErrProv.ContainerControl = this;
            // 
            // addIpAddrErrProv
            // 
            this.addIpAddrErrProv.BlinkRate = 50;
            this.addIpAddrErrProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addIpAddrErrProv.ContainerControl = this;
            // 
            // addLocationErrProv
            // 
            this.addLocationErrProv.BlinkRate = 50;
            this.addLocationErrProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addLocationErrProv.ContainerControl = this;
            // 
            // AddPeerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_text);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.hostname_text);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPeerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление элемента";
            ((System.ComponentModel.ISupportInitialize)(this.addHostnameErrProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIpAddrErrProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLocationErrProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hostname_text;
        private System.Windows.Forms.TextBox location_text;
        private System.Windows.Forms.TextBox IP_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider addHostnameErrProv;
        private System.Windows.Forms.ErrorProvider addIpAddrErrProv;
        private System.Windows.Forms.ErrorProvider addLocationErrProv;
    }
}