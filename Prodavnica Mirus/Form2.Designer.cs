namespace Prodavnica_Mirus
{
    partial class Form2
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(316, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj Proizvod";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(12, 241);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(316, 23);
            this.btnIzadji.TabIndex = 1;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.Location = new System.Drawing.Point(12, 42);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(316, 23);
            this.btnRacuni.TabIndex = 2;
            this.btnRacuni.Text = "Pogledaj Racune";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.btnRacuni_Click);
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(12, 71);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(316, 23);
            this.btnProdaja.TabIndex = 3;
            this.btnProdaja.Text = "Prodaja Proizvoda";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(340, 276);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnRacuni;
        private System.Windows.Forms.Button btnProdaja;
    }
}