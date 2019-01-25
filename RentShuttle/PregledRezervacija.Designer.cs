namespace RentShuttle
{
    partial class PregledRezervacija
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledRezervacija));
            this.rezervacija = new System.Windows.Forms.Button();
            this.odjava = new System.Windows.Forms.Button();
            this.kreiranjerez = new System.Windows.Forms.Label();
            this.otkazivanjerez = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UslugaClick = new System.Windows.Forms.RadioButton();
            this.NajamClick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NaslovnaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacija
            // 
            this.rezervacija.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rezervacija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rezervacija.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.rezervacija.Location = new System.Drawing.Point(657, 24);
            this.rezervacija.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacija.Name = "rezervacija";
            this.rezervacija.Size = new System.Drawing.Size(132, 31);
            this.rezervacija.TabIndex = 24;
            this.rezervacija.Text = "REZERVACIJA";
            this.rezervacija.UseVisualStyleBackColor = false;
            this.rezervacija.Click += new System.EventHandler(this.rezervacija_Click);
            // 
            // odjava
            // 
            this.odjava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odjava.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.odjava.Location = new System.Drawing.Point(797, 24);
            this.odjava.Margin = new System.Windows.Forms.Padding(4);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(132, 31);
            this.odjava.TabIndex = 23;
            this.odjava.Text = "ODJAVA";
            this.odjava.UseVisualStyleBackColor = false;
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // kreiranjerez
            // 
            this.kreiranjerez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kreiranjerez.BackColor = System.Drawing.Color.Transparent;
            this.kreiranjerez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kreiranjerez.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kreiranjerez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.kreiranjerez.Location = new System.Drawing.Point(731, 90);
            this.kreiranjerez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kreiranjerez.Name = "kreiranjerez";
            this.kreiranjerez.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kreiranjerez.Size = new System.Drawing.Size(170, 66);
            this.kreiranjerez.TabIndex = 27;
            this.kreiranjerez.Text = "Kreiranje rezervacije";
            this.kreiranjerez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kreiranjerez.Click += new System.EventHandler(this.kreiranjerez_Click);
            // 
            // otkazivanjerez
            // 
            this.otkazivanjerez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otkazivanjerez.BackColor = System.Drawing.Color.Transparent;
            this.otkazivanjerez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otkazivanjerez.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otkazivanjerez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.otkazivanjerez.Location = new System.Drawing.Point(721, 133);
            this.otkazivanjerez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otkazivanjerez.Name = "otkazivanjerez";
            this.otkazivanjerez.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otkazivanjerez.Size = new System.Drawing.Size(193, 51);
            this.otkazivanjerez.TabIndex = 30;
            this.otkazivanjerez.Text = "Otkazivanje rezervacije";
            this.otkazivanjerez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otkazivanjerez.Click += new System.EventHandler(this.otkazivanjerez_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(708, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 1);
            this.panel2.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(708, 171);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 1);
            this.panel4.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(939, 381);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // UslugaClick
            // 
            this.UslugaClick.AutoSize = true;
            this.UslugaClick.BackColor = System.Drawing.Color.Transparent;
            this.UslugaClick.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UslugaClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.UslugaClick.Location = new System.Drawing.Point(420, 160);
            this.UslugaClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UslugaClick.Name = "UslugaClick";
            this.UslugaClick.Size = new System.Drawing.Size(267, 24);
            this.UslugaClick.TabIndex = 48;
            this.UslugaClick.TabStop = true;
            this.UslugaClick.Text = "Prikaz rezervacije po usluzi prijevoza";
            this.UslugaClick.UseVisualStyleBackColor = false;
            this.UslugaClick.CheckedChanged += new System.EventHandler(this.UslugaClick_CheckedChanged);
            // 
            // NajamClick
            // 
            this.NajamClick.AutoSize = true;
            this.NajamClick.BackColor = System.Drawing.Color.Transparent;
            this.NajamClick.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NajamClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.NajamClick.Location = new System.Drawing.Point(129, 160);
            this.NajamClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NajamClick.Name = "NajamClick";
            this.NajamClick.Size = new System.Drawing.Size(285, 24);
            this.NajamClick.TabIndex = 47;
            this.NajamClick.TabStop = true;
            this.NajamClick.Text = "Prikaz rezervacije po najmu automobila";
            this.NajamClick.UseVisualStyleBackColor = false;
            this.NajamClick.CheckedChanged += new System.EventHandler(this.NajamClick_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Moje rezervacije:";
            // 
            // NaslovnaBtn
            // 
            this.NaslovnaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NaslovnaBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovnaBtn.ForeColor = System.Drawing.Color.White;
            this.NaslovnaBtn.Location = new System.Drawing.Point(0, 576);
            this.NaslovnaBtn.Name = "NaslovnaBtn";
            this.NaslovnaBtn.Size = new System.Drawing.Size(143, 29);
            this.NaslovnaBtn.TabIndex = 50;
            this.NaslovnaBtn.Text = "Naslovna";
            this.NaslovnaBtn.UseVisualStyleBackColor = true;
            this.NaslovnaBtn.Click += new System.EventHandler(this.NaslovnaBtn_Click);
            // 
            // PregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::RentShuttle.Properties.Resources.RS_LOGO2;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.NaslovnaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.rezervacija);
            this.Controls.Add(this.UslugaClick);
            this.Controls.Add(this.NajamClick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.otkazivanjerez);
            this.Controls.Add(this.kreiranjerez);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledRezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rezervacija;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.Label kreiranjerez;
        private System.Windows.Forms.Label otkazivanjerez;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton UslugaClick;
        private System.Windows.Forms.RadioButton NajamClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NaslovnaBtn;
    }
}