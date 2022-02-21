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
    
    public partial class Form1 : Form
    {

        ProdavnicaDataSet1 ds;
        ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter daProizvod;
        ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter daKategorija;
        ProdavnicaDataSet1TableAdapters.RacunTableAdapter daRacun;
        public Form1()
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet1();
            daProizvod = new ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter();
            daKategorija = new ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter();
            daRacun = new ProdavnicaDataSet1TableAdapters.RacunTableAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daProizvod.Fill(ds.Proizvod);
            var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
            dgvProizvodi.DataSource = Proizvod;
            daKategorija.Fill(ds.Kategorija);
            cbKategorija.DataSource = ds.Kategorija;
            cbKategorija.DisplayMember = "naziv_kategorije";
        }

        private void cbKategorija_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetfilter_Click(object sender, EventArgs e)
        {
            var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
            dgvProizvodi.DataSource = Proizvod;
        }

        private void dgvProizvodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        DataGridViewRow trenutniProizvod;
        bool proizvodOdabran=false;
        private void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trenutniProizvod = dgvProizvodi.CurrentRow;
            if (trenutniProizvod.Cells["dostupna_kolicina"].ToString() != "")
            {
                proizvodOdabran = true;
                numericUpDown1.Maximum = decimal.Parse(trenutniProizvod.Cells["dostupna_kolicina"].Value.ToString());
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (proizvodOdabran)
            {
                ListViewItem x=new ListViewItem();
                x.SubItems[0].Text = trenutniProizvod.Cells["ID"].Value.ToString();
                x.SubItems.Add(trenutniProizvod.Cells["naziv_proizvoda"].Value.ToString());
                x.SubItems.Add(numericUpDown1.Value.ToString());
                bool kopija = false;
                for(int i=0;i<lvRacun.Items.Count;i++)
                    if (x.SubItems[0].Text == lvRacun.Items[i].SubItems[0].Text)
                    {
                        lvRacun.Items[i].SubItems[2].Text = x.SubItems[2].Text;
                        kopija = true;
                    } 
                if (!kopija)
                    lvRacun.Items.Add(x);
                proizvodOdabran = false;
                numericUpDown1.Value = 1;
                var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
                dgvProizvodi.DataSource = Proizvod;
            }
            else
                MessageBox.Show("Nije odabran artikal!");
        }

        void filtriraj()
        {
            int x = ds.Kategorija[cbKategorija.SelectedIndex].ID;
            if (cbKategorija.Enabled && txtNaziv.Text.Length > 2)
            {
                proizvodOdabran = false;
                var komanda = (from p in ds.Proizvod
                               where p.ID_kategorije == x && p.naziv_proizvoda.ToUpper().Contains(txtNaziv.Text.ToUpper())
                               orderby p.naziv_proizvoda
                              select p).ToList();
                dgvProizvodi.DataSource = komanda;
            }
            else if (cbKategorija.Enabled==false && txtNaziv.Text.Length > 2)
            {
                proizvodOdabran = false;
                var komanda = (from p in ds.Proizvod
                               where  p.naziv_proizvoda.ToUpper().Contains(txtNaziv.Text.ToUpper())
                               orderby p.naziv_proizvoda
                               select p).ToList();
                dgvProizvodi.DataSource = komanda;
            }
            else if(cbKategorija.Enabled && txtNaziv.Text.Length < 3)
            {
                proizvodOdabran = false;
                var komanda = (from p in ds.Proizvod
                               where p.ID_kategorije == x
                               orderby p.naziv_proizvoda
                               select p).ToList();
                dgvProizvodi.DataSource = komanda;
            }
            else
            {
                MessageBox.Show("Nije ispravno unesen filter!");
                var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
                dgvProizvodi.DataSource = Proizvod;
                return;
            }
            if (dgvProizvodi.RowCount == 0)
            {
                MessageBox.Show("Nema rezultata!");
                var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
                dgvProizvodi.DataSource = Proizvod;
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            filtriraj();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                cbKategorija.Enabled = true;
            else
                cbKategorija.Enabled = false;
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            if(lvRacun.SelectedItems.Count>0)
                lvRacun.SelectedItems[0].Remove();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            lvRacun.Items.Clear();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string idp = "", kp = "";
            double suma = 0;
            if (lvRacun.Items.Count > 0)
            {
                for(int i = 0; i < lvRacun.Items.Count; i++)
                {
                    idp += lvRacun.Items[i].SubItems[0].Text + ";";
                    kp += lvRacun.Items[i].SubItems[2].Text + ";";
                    int pid = int.Parse(lvRacun.Items[i].SubItems[0].Text);
                    int pko = int.Parse(lvRacun.Items[i].SubItems[2].Text);
                    var pro =
                        (from p in ds.Proizvod
                         where p.ID == pid
                         select p).First();
                    pro.dostupna_kolicina -= pko;
                    suma += pro.cena * pko;
                }
                daRacun.Insert(idp, kp, suma,DateTime.Now);
                MessageBox.Show("Racun je procesiran");
            }
            else
                MessageBox.Show("Racun nije procesiran");
            lvRacun.Items.Clear();
            daProizvod.Update(ds);
            var Proizvod = ds.Proizvod.OrderBy(p => p.ID_kategorije).ThenBy(p => p.naziv_proizvoda).ToList();
            dgvProizvodi.DataSource = Proizvod;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
