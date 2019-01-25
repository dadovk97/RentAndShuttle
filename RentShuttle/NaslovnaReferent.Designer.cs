namespace RentShuttle
{
    partial class NaslovnaReferent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaslovnaReferent));
            this.statistika = new System.Windows.Forms.Button();
            this.odjava = new System.Windows.Forms.Button();
            this.danasnjerezervacije = new System.Windows.Forms.Button();
            this.statistickipodaci = new System.Windows.Forms.Button();
            this.rezervacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statistika
            // 
            this.statistika.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statistika.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.statistika.Location = new System.Drawing.Point(721, 25);
            this.statistika.Name = "statistika";
            this.statistika.Size = new System.Drawing.Size(104, 25);
            this.statistika.TabIndex = 29;
            this.statistika.Text = "STATISTIKA";
            this.statistika.UseVisualStyleBackColor = false;
            this.statistika.Click += new System.EventHandler(this.statistika_Click);
            // 
            // odjava
            // 
            this.odjava.BackColor = System.Drawing.SystemColors.ControlLight;
            this.odjava.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.odjava.Location = new System.Drawing.Point(831, 25);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(99, 25);
            this.odjava.TabIndex = 28;
            this.odjava.Text = "ODJAVA";
            this.odjava.UseVisualStyleBackColor = false;
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            // 
            // danasnjerezervacije
            // 
            this.danasnjerezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.danasnjerezervacije.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.danasnjerezervacije.ForeColor = System.Drawing.Color.White;
            this.danasnjerezervacije.Location = new System.Drawing.Point(12, 166);
            this.danasnjerezervacije.Name = "danasnjerezervacije";
            this.danasnjerezervacije.Size = new System.Drawing.Size(616, 50);
            this.danasnjerezervacije.TabIndex = 30;
            this.danasnjerezervacije.Text = "PREGLED DANAŠNJIH REZERVACIJA";
            this.danasnjerezervacije.UseVisualStyleBackColor = true;
            this.danasnjerezervacije.Click += new System.EventHandler(this.danasnjerezervacije_Click);
            // 
            // statistickipodaci
            // 
            this.statistickipodaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statistickipodaci.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statistickipodaci.ForeColor = System.Drawing.Color.White;
            this.statistickipodaci.Location = new System.Drawing.Point(12, 263);
            this.statistickipodaci.Name = "statistickipodaci";
            this.statistickipodaci.Size = new System.Drawing.Size(616, 50);
            this.statistickipodaci.TabIndex = 31;
            this.statistickipodaci.Text = "PREGLED STATISTIČKIH PODATAKA";
            this.statistickipodaci.UseVisualStyleBackColor = true;
            this.statistickipodaci.Click += new System.EventHandler(this.statistickipodaci_Click);
            // 
            // rezervacije
            // 
            this.rezervacije.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rezervacije.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rezervacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.rezervacije.Location = new System.Drawing.Point(598, 25);
            this.rezervacije.Name = "rezervacije";
            this.rezervacije.Size = new System.Drawing.Size(117, 25);
            this.rezervacije.TabIndex = 33;
            this.rezervacije.Text = "REZERVACIJA";
            this.rezervacije.UseVisualStyleBackColor = false;
            this.rezervacije.Click += new System.EventHandler(this.rezervacije_Click);
            // 
            // NaslovnaReferent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::RentShuttle.Properties.Resources.RS_LOGO2;
            this.ClientSize = new System.Drawing.Size(942, 608);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.statistika);
            this.Controls.Add(this.rezervacije);
            this.Controls.Add(this.statistickipodaci);
            this.Controls.Add(this.danasnjerezervacije);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NaslovnaReferent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent&Shuttle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button statistika;
        private System.Windows.Forms.Button odjava;
        private System.Windows.Forms.Button danasnjerezervacije;
        private System.Windows.Forms.Button statistickipodaci;
        private System.Windows.Forms.Button rezervacije;
    }
}