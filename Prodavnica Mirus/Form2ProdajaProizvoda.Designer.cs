namespace Prodavnica_Mirus
{
    partial class Form2ProdajaProizvoda
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.lblGlo = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AllowUserToResizeColumns = false;
            this.dgvProizvodi.AllowUserToResizeRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProizvodi.Location = new System.Drawing.Point(529, 12);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProizvodi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(156, 362);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellClick);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(13, 317);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(0, 13);
            this.lblNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukupna prodaja";
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(13, 338);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(0, 13);
            this.lblPro.TabIndex = 3;
            // 
            // lblGlo
            // 
            this.lblGlo.AutoSize = true;
            this.lblGlo.Location = new System.Drawing.Point(140, 338);
            this.lblGlo.Name = "lblGlo";
            this.lblGlo.Size = new System.Drawing.Size(35, 13);
            this.lblGlo.TabIndex = 4;
            this.lblGlo.Text = "label4";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 9);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(35, 13);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "label5";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(269, 351);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(254, 23);
            this.btnIzadji.TabIndex = 6;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 354);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(269, 322);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(254, 23);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form2ProdajaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 386);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblGlo);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "Form2ProdajaProizvoda";
            this.Text = "Form2ProdajaProizvoda";
            this.Load += new System.EventHandler(this.Form2ProdajaProizvoda_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2ProdajaProizvoda_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label lblGlo;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrikazi;
    }
}