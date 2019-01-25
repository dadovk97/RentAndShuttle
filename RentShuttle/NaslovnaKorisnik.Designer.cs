namespace RentShuttle
{
    partial class NaslovnaKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaslovnaKorisnik));
            this.pregledrez = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.odjava = new System.Windows.Forms.Button();
            this.rezervacija = new System.Windows.Forms.Button();
            this.bunifuRating2 = new Bunifu.Framework.UI.BunifuRating();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pregledrez
            // 
            this.pregledrez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pregledrez.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pregledrez.ForeColor = System.Drawing.Color.White;
            this.pregledrez.Location = new System.Drawing.Point(13, 134);
            this.pregledrez.Margin = new System.Windows.Forms.Padding(4);
            this.pregledrez.Name = "pregledrez";
            this.pregledrez.Size = new System.Drawing.Size(359, 53);
            this.pregledrez.TabIndex = 23;
            this.pregledrez.Text = "MOJE REZERVACIJE";
            this.pregledrez.UseVisualStyleBackColor = true;
            this.pregledrez.Click += new System.EventHandler(this.pregledrez_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::RentShuttle.Properties.Resources._2015BMW005c_1280_03;
            this.pictureBox6.Location = new System.Drawing.Point(606, 402);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(323, 193);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // odjava
            // 
            this.odjava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odjava.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.odjava.Location = new System.Drawing.Point(797, 23);
            this.odjava.Margin = new System.Windows.Forms.Padding(4);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(132, 31);
            this.odjava.TabIndex = 21;
            this.odjava.Text = "ODJAVA";
            this.odjava.UseVisualStyleBackColor = false;
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // rezervacija
            // 
            this.rezervacija.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rezervacija.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.rezervacija.Location = new System.Drawing.Point(657, 23);
            this.rezervacija.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacija.Name = "rezervacija";
            this.rezervacija.Size = new System.Drawing.Size(132, 31);
            this.rezervacija.TabIndex = 22;
            this.rezervacija.Text = "REZERVACIJA";
            this.rezervacija.UseVisualStyleBackColor = false;
            this.rezervacija.Click += new System.EventHandler(this.rezervacija_Click);
            // 
            // bunifuRating2
            // 
            this.bunifuRating2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating2.ForeColor = System.Drawing.Color.DarkOrange;
            this.bunifuRating2.Location = new System.Drawing.Point(22, 416);
            this.bunifuRating2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuRating2.Name = "bunifuRating2";
            this.bunifuRating2.Size = new System.Drawing.Size(419, 75);
            this.bunifuRating2.TabIndex = 32;
            this.bunifuRating2.Value = 0;
            this.bunifuRating2.onValueChanged += new System.EventHandler(this.bunifuRating2_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(18, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ocjenite naše usluge:";
            // 
            // NaslovnaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::RentShuttle.Properties.Resources.RS_LOGO2;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.rezervacija);
            this.Controls.Add(this.bunifuRating2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pregledrez);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaslovnaKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent&Shuttle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pregledrez;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.Button rezervacija;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private Bunifu.Framework.UI.BunifuRating bunifuRating2;
        private System.Windows.Forms.Label label1;
    }
}