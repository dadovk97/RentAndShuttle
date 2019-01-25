namespace RentShuttle
{
    partial class StatistickiPodaci
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatistickiPodaci));
            this.rezervacije = new System.Windows.Forms.Button();
            this.statistika = new System.Windows.Forms.Button();
            this.odjava = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prosjecnaOcjena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zbrojOcjena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // rezervacije
            // 
            this.rezervacije.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rezervacije.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacije.ForeColor = System.Drawing.Color.Black;
            this.rezervacije.Location = new System.Drawing.Point(518, 24);
            this.rezervacije.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rezervacije.Name = "rezervacije";
            this.rezervacije.Size = new System.Drawing.Size(130, 30);
            this.rezervacije.TabIndex = 41;
            this.rezervacije.Text = "REZERVACIJA";
            this.rezervacije.UseVisualStyleBackColor = false;
            this.rezervacije.Click += new System.EventHandler(this.rezervacije_Click);
            // 
            // statistika
            // 
            this.statistika.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statistika.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistika.ForeColor = System.Drawing.Color.Black;
            this.statistika.Location = new System.Drawing.Point(658, 24);
            this.statistika.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(130, 30);
            this.statistika.TabIndex = 40;
            this.statistika.Text = "STATISTIKA";
            this.statistika.UseVisualStyleBackColor = false;
            this.statistika.Click += new System.EventHandler(this.statistika_Click);
            // 
            // odjava
            // 
            this.odjava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odjava.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.Color.Black;
            this.odjava.Location = new System.Drawing.Point(798, 24);
            this.odjava.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(130, 30);
            this.odjava.TabIndex = 39;
            this.odjava.Text = "ODJAVA";
            this.odjava.UseVisualStyleBackColor = false;
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(138, 288);
            this.dataGridView1.TabIndex = 42;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(278, 144);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(663, 463);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // prosjecnaOcjena
            // 
            this.prosjecnaOcjena.AutoSize = true;
            this.prosjecnaOcjena.BackColor = System.Drawing.Color.Transparent;
            this.prosjecnaOcjena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prosjecnaOcjena.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prosjecnaOcjena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.prosjecnaOcjena.Location = new System.Drawing.Point(211, 472);
            this.prosjecnaOcjena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prosjecnaOcjena.Name = "prosjecnaOcjena";
            this.prosjecnaOcjena.Size = new System.Drawing.Size(20, 21);
            this.prosjecnaOcjena.TabIndex = 46;
            this.prosjecnaOcjena.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(13, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Prosječna ocjena usluge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(13, 429);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Zbroj ocjena:";
            // 
            // zbrojOcjena
            // 
            this.zbrojOcjena.AutoSize = true;
            this.zbrojOcjena.BackColor = System.Drawing.Color.Transparent;
            this.zbrojOcjena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zbrojOcjena.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zbrojOcjena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.zbrojOcjena.Location = new System.Drawing.Point(124, 429);
            this.zbrojOcjena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zbrojOcjena.Name = "zbrojOcjena";
            this.zbrojOcjena.Size = new System.Drawing.Size(20, 21);
            this.zbrojOcjena.TabIndex = 45;
            this.zbrojOcjena.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(274, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Grafički prikaz ocjenjenih usluga:";
            // 
            // StatistickiPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::RentShuttle.Properties.Resources.RS_LOGO2;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prosjecnaOcjena);
            this.Controls.Add(this.zbrojOcjena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rezervacije);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.odjava);
            this.Font = new System.Drawing.Font("Georgia", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatistickiPodaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rezervacije;
        private System.Windows.Forms.Button statistika;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label prosjecnaOcjena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label zbrojOcjena;
        private System.Windows.Forms.Label label1;
    }
}