﻿namespace RentShuttle
{
    partial class RegistracijaUspjesna
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
            this.BtnUredu = new System.Windows.Forms.Button();
            this.Poruka = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUredu
            // 
            this.BtnUredu.FlatAppearance.BorderSize = 0;
            this.BtnUredu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUredu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUredu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUredu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUredu.ForeColor = System.Drawing.Color.LightGray;
            this.BtnUredu.Location = new System.Drawing.Point(148, 184);
            this.BtnUredu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUredu.Name = "BtnUredu";
            this.BtnUredu.Size = new System.Drawing.Size(84, 37);
            this.BtnUredu.TabIndex = 12;
            this.BtnUredu.Text = "U redu";
            this.BtnUredu.UseVisualStyleBackColor = true;
            this.BtnUredu.Click += new System.EventHandler(this.BtnUredu_Click);
            // 
            // Poruka
            // 
            this.Poruka.AutoSize = true;
            this.Poruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poruka.Location = new System.Drawing.Point(128, 101);
            this.Poruka.Name = "Poruka";
            this.Poruka.Size = new System.Drawing.Size(215, 20);
            this.Poruka.TabIndex = 11;
            this.Poruka.Text = "Uspješno ste se registrirali!";
            // 
            // Icon
            // 
            this.Icon.Image = global::RentShuttle.Properties.Resources.success;
            this.Icon.Location = new System.Drawing.Point(60, 82);
            this.Icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(62, 56);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 10;
            this.Icon.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(308, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(52, 34);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(0, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 51);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 40);
            this.label1.TabIndex = 7;
            // 
            // RegistracijaUspjesna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(368, 229);
            this.Controls.Add(this.BtnUredu);
            this.Controls.Add(this.Poruka);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistracijaUspjesna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUredu;
        private Bunifu.Framework.UI.BunifuCustomLabel Poruka;
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}