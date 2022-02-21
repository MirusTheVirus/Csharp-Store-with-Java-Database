using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodavnica_Mirus
{
    public partial class Form2NoviProizvod : Form
    {
        ProdavnicaDataSet1 ds;
        ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter daProizvod;
        ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter daKategorija;
        public Form2NoviProizvod()
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet1();
            daProizvod = new ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter();
            daKategorija = new ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNaziv.Text.Trim() != "")
                {
                    daProizvod.Insert(txtNaziv.Text, double.Parse(txtCena.Text), int.Parse(txtKol.Text), ds.Kategorija[cbKategorija.SelectedIndex].ID);
                    MessageBox.Show("Proizvod je dodat!");
                }
                else
                {
                    MessageBox.Show("Nije unesesn naziv");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nisu uspesno uneseni podaci");
            }
        }

        private void Form2NoviProizvod_Load(object sender, EventArgs e)
        {
            daProizvod.Fill(ds.Proizvod);
            daKategorija.Fill(ds.Kategorija);
            cbKategorija.DataSource = ds.Kategorija;
            cbKategorija.DisplayMember = "naziv_kategorije";
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
