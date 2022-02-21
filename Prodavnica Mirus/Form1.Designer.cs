namespace Prodavnica_Mirus
{
    partial class Form1
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
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.prodavnicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnResetfilter = new System.Windows.Forms.Button();
            this.lvRacun = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKategorija
            // 
            this.cbKategorija.Enabled = false;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(134, 218);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(144, 21);
            this.cbKategorija.TabIndex = 1;
            this.cbKategorija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbKategorija_KeyPress);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(284, 300);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 158);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.Location = new System.Drawing.Point(423, 385);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(115, 73);
            this.btnVoid.TabIndex = 4;
            this.btnVoid.Text = "Storniraj racun";
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(423, 300);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(115, 71);
            this.btnOdbaci.TabIndex = 6;
            this.btnOdbaci.Text = "Storniraj odabrani artikal";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            this.btnOdbaci.Click += new System.EventHandler(this.btnOdbaci_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(423, 522);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(115, 52);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Administracija";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(254, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Izadji";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToResizeColumns = false;
            this.dgvProizvodi.AllowUserToResizeRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 12);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(526, 198);
            this.dgvProizvodi.TabIndex = 9;
            this.dgvProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellClick);
            this.dgvProizvodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProizvodi_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(383, 274);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetfilter
            // 
            this.btnResetfilter.Location = new System.Drawing.Point(284, 216);
            this.btnResetfilter.Name = "btnResetfilter";
            this.btnResetfilter.Size = new System.Drawing.Size(254, 23);
            this.btnResetfilter.TabIndex = 11;
            this.btnResetfilter.Text = "Prikazi sve artikle";
            this.btnResetfilter.UseVisualStyleBackColor = true;
            this.btnResetfilter.Click += new System.EventHandler(this.btnResetfilter_Click);
            // 
            // lvRacun
            // 
            this.lvRacun.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvRacun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.naziv,
            this.kolicina});
            this.lvRacun.FullRowSelect = true;
            this.lvRacun.HideSelection = false;
            this.lvRacun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvRacun.Location = new System.Drawing.Point(12, 274);
            this.lvRacun.MultiSelect = false;
            this.lvRacun.Name = "lvRacun";
            this.lvRacun.Size = new System.Drawing.Size(266, 184);
            this.lvRacun.TabIndex = 12;
            this.lvRacun.UseCompatibleStateImageBehavior = false;
            this.lvRacun.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 45;
            // 
            // naziv
            // 
            this.naziv.Text = "naziv";
            this.naziv.Width = 128;
            // 
            // kolicina
            // 
            this.kolicina.Text = "kolicina";
            this.kolicina.Width = 88;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(284, 245);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(254, 23);
            this.btnFiltriraj.TabIndex = 13;
            this.btnFiltriraj.Text = "Filtriraj naziv";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(134, 248);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(144, 20);
            this.txtNaziv.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Filtriraj Kategoriju";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(12, 464);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(266, 52);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sacuvaj Racun";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Naziv proizvoda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kolicina proizvoda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prodavnica Mirus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(550, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.lvRacun);
            this.Controls.Add(this.btnResetfilter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbKategorija);
            this.Name = "Form1";
            this.Text = "Prodavnica Mirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnOdbaci;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.BindingSource prodavnicaDataSetBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnResetfilter;
        private System.Windows.Forms.ListView lvRacun;
        public System.Windows.Forms.ColumnHeader ID;
        public System.Windows.Forms.ColumnHeader naziv;
        public System.Windows.Forms.ColumnHeader kolicina;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

