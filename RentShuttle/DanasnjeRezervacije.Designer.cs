namespace RentShuttle
{
    partial class DanasnjeRezervacije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanasnjeRezervacije));
            this.rezervacije = new System.Windows.Forms.Button();
            this.statistika = new System.Windows.Forms.Button();
            this.odjava = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NajamClick = new System.Windows.Forms.RadioButton();
            this.UslugaClick = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacije
            // 
            this.rezervacije.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rezervacije.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rezervacije.Location = new System.Drawing.Point(517, 23);
            this.rezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacije.Name = "rezervacije";
            this.rezervacije.Size = new System.Drawing.Size(132, 31);
            this.rezervacije.TabIndex = 37;
            this.rezervacije.Text = "REZERVACIJA";
            this.rezervacije.UseVisualStyleBackColor = false;
            this.rezervacije.Click += new System.EventHandler(this.rezervacije_Click);
            // 
            // statistika
            // 
            this.statistika.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statistika.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.statistika.Location = new System.Drawing.Point(657, 23);
            this.statistika.Margin = new System.Windows.Forms.Padding(4);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(132, 31);
            this.statistika.TabIndex = 36;
            this.statistika.Text = "STATISTIKA";
            this.statistika.UseVisualStyleBackColor = false;
            this.statistika.Click += new System.EventHandler(this.statistika_Click);
            // 
            // odjava
            // 
            this.odjava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odjava.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.odjava.Location = new System.Drawing.Point(797, 23);
            this.odjava.Margin = new System.Windows.Forms.Padding(4);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(132, 31);
            this.odjava.TabIndex = 35;
            this.odjava.Text = "ODJAVA";
            this.odjava.UseVisualStyleBackColor = false;
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 24);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 184);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 433);
            this.dataGridView1.TabIndex = 42;
            // 
            // NajamClick
            // 
            this.NajamClick.AutoSize = true;
            this.NajamClick.BackColor = System.Drawing.Color.Transparent;
            this.NajamClick.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NajamClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NajamClick.Location = new System.Drawing.Point(99, 153);
            this.NajamClick.Name = "NajamClick";
            this.NajamClick.Size = new System.Drawing.Size(315, 25);
            this.NajamClick.TabIndex = 45;
            this.NajamClick.TabStop = true;
            this.NajamClick.Text = "Prikaz rezervacije po najmu automobila";
            this.NajamClick.UseVisualStyleBackColor = false;
            this.NajamClick.CheckedChanged += new System.EventHandler(this.NajamClick_CheckedChanged);
            // 
            // UslugaClick
            // 
            this.UslugaClick.AutoSize = true;
            this.UslugaClick.BackColor = System.Drawing.Color.Transparent;
            this.UslugaClick.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UslugaClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UslugaClick.Location = new System.Drawing.Point(477, 153);
            this.UslugaClick.Name = "UslugaClick";
            this.UslugaClick.Size = new System.Drawing.Size(295, 25);
            this.UslugaClick.TabIndex = 46;
            this.UslugaClick.TabStop = true;
            this.UslugaClick.Text = "Prikaz rezervacije po usluzi prijevoza";
            this.UslugaClick.UseVisualStyleBackColor = false;
            this.UslugaClick.CheckedChanged += new System.EventHandler(this.UslugaClick_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Današnje rezervacije:";
            // 
            // DanasnjeRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::RentShuttle.Properties.Resources.RS_LOGO2;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UslugaClick);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.rezervacije);
            this.Controls.Add(this.NajamClick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanasnjeRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanasnjeRezervacije";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezervacije;
        private System.Windows.Forms.Button statistika;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton NajamClick;
        private System.Windows.Forms.RadioButton UslugaClick;
        private System.Windows.Forms.Label label1;
    }
}