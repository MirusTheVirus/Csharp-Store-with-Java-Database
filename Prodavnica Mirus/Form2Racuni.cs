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
    public partial class Form2Racuni : Form
    {
        ProdavnicaDataSet1 ds;
        ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter daProizvod;
        ProdavnicaDataSet1TableAdapters.RacunTableAdapter daRacun;
        public Form2Racuni()
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet1();
            daProizvod = new ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter();
            daRacun = new ProdavnicaDataSet1TableAdapters.RacunTableAdapter();
        }

        private void Form2Racuni_Load(object sender, EventArgs e)
        {
            daRacun.Fill(ds.Racun);
            dgvRacuni.DataSource = ds.Racun.Select();
            daProizvod.Fill(ds.Proizvod);
            dgvRacuni.Columns[1].Visible = false;
            dgvRacuni.Columns[2].Visible = false;
            dgvRacuni.Columns[3].Visible = false;
            dgvRacuni.Columns[0].Width = 40;
            dgvRacuni.Columns[4].Width = 120;
            dtvod.MaxDate = DateTime.Now;
            dtvdo.MaxDate = DateTime.Now;
            dtvod.Value = DateTime.Now;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRacuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        DataGridViewRow trenutniRacun;
        private void dgvRacuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lvRacun.Items.Clear();
            trenutniRacun = dgvRacuni.CurrentRow;
            string[] idp = trenutniRacun.Cells[1].Value.ToString().Split(';');
            string[] kolp = trenutniRacun.Cells[2].Value.ToString().Split(';');
            for(int i = 0; i < idp.Length-1; i++)
            {
                ListViewItem x = new ListViewItem();
                var pro = (from p in ds.Proizvod
                           where p.ID==int.Parse(idp[i].ToString())
                           select p.naziv_proizvoda).First();
                x.SubItems[0].Text =pro;
                x.SubItems.Add(kolp[i]);
                var cen = (from p in ds.Proizvod
                           where p.ID == int.Parse(idp[i].ToString())
                           select p.cena*double.Parse(kolp[i].ToString())).First();
                x.SubItems.Add(cen.ToString());
                lvRacun.Items.Add(x);
            }
            txtDatum.Text = trenutniRacun.Cells[4].Value.ToString();
            txtUkupna.Text = trenutniRacun.Cells[3].Value.ToString();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            //if (dtvdo.Value.Year > dtvod.Value.Year)
            //{
            //var kom = (from r in ds.Racun
            //           where r.datum_izdavanja.Date>=dtvod.Value.Date && r.datum_izdavanja<=dtvdo.Value.Date
            //           select r).ToList();
            //dgvRacuni.DataSource = kom;
            //}
            //else if (dtvdo.Value.Year == dtvod.Value.Year)
            //{
            //    if (dtvdo.Value.Month > dtvod.Value.Month)
            //    {
            //        var kom = (from r in ds.Racun
            //                   where r.datum_izdavanja.Month >= dtvod.Value.Month && r.datum_izdavanja.Month <= dtvdo.Value.Month 
            //                   && r.datum_izdavanja.Year == dtvdo.Value.Year
            //                   select r).ToList();
            //        dgvRacuni.DataSource = kom;
            //    }
            //    else if (dtvdo.Value.Month == dtvod.Value.Month)
            //    {
            //        if (dtvdo.Value.Day >= dtvod.Value.Day)
            //        {
            //            var kom = (from r in ds.Racun
            //                       where r.datum_izdavanja.Day >= dtvod.Value.Day && r.datum_izdavanja.Day <= dtvdo.Value.Day && r.datum_izdavanja.Year == dtvdo.Value.Year && r.datum_izdavanja.Month == dtvdo.Value.Month
            //                       select r).ToList();
            //            dgvRacuni.DataSource = kom;
            //        }
            //    }
            //}
            if (dtvod.Value.Date<=dtvdo.Value.Date)
            {
                var kom = (from r in ds.Racun
                           where r.datum_izdavanja.Date >= dtvod.Value.Date && r.datum_izdavanja.Date <= dtvdo.Value.Date
                           select r).ToList();
                dgvRacuni.DataSource = kom;
            }
            else
                MessageBox.Show("Nisu ispravno uneseni datumi");
            
        }
    }
}
