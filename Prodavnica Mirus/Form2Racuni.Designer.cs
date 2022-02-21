namespace Prodavnica_Mirus
{
    partial class Form2Racuni
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupna = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvRacun = new System.Windows.Forms.ListView();
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtvod = new System.Windows.Forms.DateTimePicker();
            this.dtvdo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.AllowUserToResizeColumns = false;
            this.dgvRacuni.AllowUserToResizeRows = false;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(12, 117);
            this.dgvRacuni.MultiSelect = false;
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowTemplate.ReadOnly = true;
            this.dgvRacuni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.ShowCellErrors = false;
            this.dgvRacuni.ShowCellToolTips = false;
            this.dgvRacuni.ShowEditingIcon = false;
            this.dgvRacuni.ShowRowErrors = false;
            this.dgvRacuni.Size = new System.Drawing.Size(210, 198);
            this.dgvRacuni.TabIndex = 1;
            this.dgvRacuni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacuni_CellClick);
            this.dgvRacuni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvRacuni_KeyPress);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(12, 339);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(446, 23);
            this.btnIzadji.TabIndex = 2;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ukupna cena:";
            // 
            // txtUkupna
            // 
            this.txtUkupna.Location = new System.Drawing.Point(329, 294);
            this.txtUkupna.Name = "txtUkupna";
            this.txtUkupna.Size = new System.Drawing.Size(129, 20);
            this.txtUkupna.TabIndex = 4;
            this.txtUkupna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatum_KeyPress);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(329, 256);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(129, 20);
            this.txtDatum.TabIndex = 5;
            this.txtDatum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum izdanja:";
            // 
            // lvRacun
            // 
            this.lvRacun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.Kolicina,
            this.Cena});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            this.lvRacun.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvRacun.HideSelection = false;
            this.lvRacun.Location = new System.Drawing.Point(248, 13);
            this.lvRacun.MultiSelect = false;
            this.lvRacun.Name = "lvRacun";
            this.lvRacun.Size = new System.Drawing.Size(210, 237);
            this.lvRacun.TabIndex = 7;
            this.lvRacun.UseCompatibleStateImageBehavior = false;
            this.lvRacun.View = System.Windows.Forms.View.Details;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv proizvoda";
            this.Naziv.Width = 90;
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Broj";
            this.Kolicina.Width = 30;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 90;
            // 
            // dtvod
            // 
            this.dtvod.Location = new System.Drawing.Point(12, 22);
            this.dtvod.MaxDate = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            this.dtvod.Name = "dtvod";
            this.dtvod.Size = new System.Drawing.Size(210, 20);
            this.dtvod.TabIndex = 8;
            this.dtvod.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtvdo
            // 
            this.dtvdo.Location = new System.Drawing.Point(12, 63);
            this.dtvdo.Name = "dtvdo";
            this.dtvdo.Size = new System.Drawing.Size(210, 20);
            this.dtvdo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Do";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(12, 89);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(210, 23);
            this.btnPrikazi.TabIndex = 12;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Form2Racuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 374);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvdo);
            this.Controls.Add(this.dtvod);
            this.Controls.Add(this.lvRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtUkupna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvRacuni);
            this.Name = "Form2Racuni";
            this.Text = "Form2Racuni";
            this.Load += new System.EventHandler(this.Form2Racuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupna;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvRacun;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Kolicina;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.DateTimePicker dtvod;
        private System.Windows.Forms.DateTimePicker dtvdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikazi;
    }
}