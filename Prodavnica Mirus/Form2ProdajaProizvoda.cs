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
    public partial class Form2ProdajaProizvoda : Form
    {
        ProdavnicaDataSet1 ds;
        ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter daProizvod;
        ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter daKategorija;
        ProdavnicaDataSet1TableAdapters.RacunTableAdapter daRacun;
        public Form2ProdajaProizvoda()
        {
            InitializeComponent();
            ds = new ProdavnicaDataSet1();
            daProizvod = new ProdavnicaDataSet1TableAdapters.ProizvodTableAdapter();
            daKategorija = new ProdavnicaDataSet1TableAdapters.KategorijaTableAdapter();
            daRacun = new ProdavnicaDataSet1TableAdapters.RacunTableAdapter();
        }
        
        private void Form2ProdajaProizvoda_Load(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.Date.ToString("dd.MM.yyyy.");
            daProizvod.Fill(ds.Proizvod);
            daKategorija.Fill(ds.Kategorija);
            daRacun.Fill(ds.Racun);
            dgvProizvodi.DataSource = ds.Proizvod.Select();
            dgvProizvodi.Columns[0].Width = 25;
            string redid = "";
            string redpro = "";
            for(int i = 0; i < ds.Racun.Rows.Count; i++)
            {
                redpro+=ds.Racun.Rows[i][2].ToString();
                redid += ds.Racun.Rows[i][1].ToString();
            }
            nizpro = redpro.Split(';');
            nizid = redid.Split(';');
            for(int i=0;i<nizpro.Length-1;i++)
                sumaprodaja+=int.Parse(nizpro[i]);
            lblGlo.Text = sumaprodaja.ToString();
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //prodajaproizvoda = 0;
            //string idproizvoda =dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            //for(int i = 0; i < nizpro.Length - 1;i++)
            //    if (nizid[i] == idproizvoda)
            //    {
            //        prodajaproizvoda += int.Parse(nizpro[i]);
            //    }
            //lblPro.Text ="Prodato: "+ prodajaproizvoda.ToString();
            //lblNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
            //this.Paint += Boji;
            
            //prodajaproizvoda = 0;
            //maxudanu = 0;
            //DateTime ovaj = dateTimePicker1.Value;
            //int bd = DateTime.DaysInMonth(ovaj.Year, ovaj.Month);
            //int[] nizkoludanu = new int[bd];
            //for (int i = 0; i < bd-1; i++)
            //    nizkoludanu[i] = 0;
            //var racuniumesecu = (from r in ds.Racun
            //                     where r.datum_izdavanja.Month == dateTimePicker1.Value.Month && r.datum_izdavanja.Year == dateTimePicker1.Value.Year
            //                     select r).ToList();
            //string idproizvoda = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            //for (int i = 0; i < racuniumesecu.Count; i++)
            //{
            //    int koludanu = 0;
            //    string[] nizid = racuniumesecu[i].ID_proizvoda.ToString().Split(';');
            //    string[] nizkol = racuniumesecu[i].kolicina_proizvoda.ToString().Split(';');
            //    for(int j = 0; j < nizid.Length - 1; j++)
            //    {
            //        if (nizid[j] == idproizvoda)
            //        {
            //            prodajaproizvoda += int.Parse(nizkol[j]);
            //            koludanu += int.Parse(nizkol[j]);
            //        }
            //    }
            //    nizkoludanu[int.Parse(racuniumesecu[i].datum_izdavanja.Day.ToString())] = koludanu;
            //    if (koludanu > maxudanu)
            //        maxudanu = koludanu;
            //}
            //dani = nizkoludanu;
            //lblPro.Text = "Mesec: " + prodajaproizvoda.ToString()+" Dan: "+maxudanu.ToString();
            //lblNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
            //this.Paint += Form2ProdajaProizvoda_Paint;
        }

        private void Form2ProdajaProizvoda_Paint(object sender, PaintEventArgs e)
        {
            //if (maxudanu > 0)
            //{
            //    string faf = "";
            //    for(int i = 0; i < dani.Length; i++)
            //    {
            //        faf += dani[i].ToString() + ";";
            //    }
            //    MessageBox.Show(faf);
            //    //e.Graphics.Dispose();
            //    Graphics g = e.Graphics;
            //    Brush b = new SolidBrush(Color.Red);
            //    int sirina = 200;
            //    int visina = 100;
            //    DateTime ovaj = dateTimePicker1.Value;
            //    int bd = DateTime.DaysInMonth(ovaj.Year, ovaj.Month);
            //    int x = sirina / bd;
            //    int y = visina / maxudanu;
            //    Rectangle[] crtanje = new Rectangle[bd];
            //    for (int i = 0; i < bd - 1; i++)
            //    {
            //        int l = y * dani[i];
            //        int razmak = 5 * x;
            //        Rectangle r = new Rectangle(razmak + 1, 5, 30, l + 1);
            //        crtanje[i] = r;
            //    }
            //    g.FillRectangles(b, crtanje);
            //    this.Dispose();
            //}
            //int prodajaproizvoda = 0;
            //int maxudanu = 0;
            //DateTime ovaj = dateTimePicker1.Value;
            //int bd = DateTime.DaysInMonth(ovaj.Year, ovaj.Month);
            //int[] nizkoludanu = new int[bd];
            //string idproizvoda = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            //for (int i = 0; i < bd - 1; i++)
            //    nizkoludanu[i] = 0;
            //for(int i = 0; i < bd; i++)
            //{
            //    int kolicina = 0;
            //    var komanda = (from r in ds.Racun
            //                   where r.datum_izdavanja.Month == dateTimePicker1.Value.Month && r.datum_izdavanja.Year == dateTimePicker1.Value.Year && r.datum_izdavanja.Day==i
            //                   select r).ToList();
            //    for (int j = 0; j < komanda.Count; j++)
            //    {
            //        string[] nid = komanda[j].ID_proizvoda.ToString().Split(';');
            //        for(int k = 0; k < nid.Length - 1; k++)
            //            if (nid[k] == idproizvoda)
            //            {
            //                string[] nkol = komanda[j].kolicina_proizvoda.ToString().Split(';');
            //                kolicina += int.Parse(nkol[k]);
            //            }
            //    }
            //    if (kolicina > maxudanu)
            //        maxudanu = kolicina;
            //    nizkoludanu[i] = kolicina;
            //    prodajaproizvoda += kolicina;
            //}
            //lblPro.Text = "Mesec: " + prodajaproizvoda + " Dan: " + maxudanu;
            //if (maxudanu > 0)
            //{
                
            //}
            //this.Refresh();
        }


        int sumaprodaja = 0;
        string[] nizid;
        string[] nizpro;
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            //prodajaproizvoda = 0;
            //maxudanu = 0;
            //DateTime ovaj = dateTimePicker1.Value;
            //int bd = DateTime.DaysInMonth(ovaj.Year, ovaj.Month);
            //int[] nizkoludanu = new int[bd];
            //for (int i = 0; i < bd - 1; i++)
            //    nizkoludanu[i] = 0;
            //var racuniumesecu = (from r in ds.Racun
            //                     where r.datum_izdavanja.Month == dateTimePicker1.Value.Month && r.datum_izdavanja.Year == dateTimePicker1.Value.Year
            //                     select r).ToList();
            //string idproizvoda = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            //for (int i = 0; i < racuniumesecu.Count; i++)
            //{
            //    int koludanu = 0;
            //    string[] nizid = racuniumesecu[i].ID_proizvoda.ToString().Split(';');
            //    string[] nizkol = racuniumesecu[i].kolicina_proizvoda.ToString().Split(';');
            //    for (int j = 0; j < nizid.Length - 1; j++)
            //    {
            //        if (nizid[j] == idproizvoda)
            //        {
            //            prodajaproizvoda += int.Parse(nizkol[j]);
            //            koludanu += int.Parse(nizkol[j]);
            //        }
            //    }
            //    nizkoludanu[int.Parse(racuniumesecu[i].datum_izdavanja.Day.ToString())] = koludanu;
            //    if (koludanu > maxudanu)
            //        maxudanu = koludanu;
            //}
            //dani = nizkoludanu;
            //lblPro.Text = "Mesec: " + prodajaproizvoda.ToString() + " Dan: " + maxudanu.ToString();
            //lblNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
            int prodajaproizvoda = 0;
            int maxudanu = 0;
            DateTime ovaj = dateTimePicker1.Value;
            int bd = DateTime.DaysInMonth(ovaj.Year, ovaj.Month);
            int[] nizkoludanu = new int[bd];
            string idproizvoda = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
            for (int i = 0; i < bd; i++)
                nizkoludanu[i] = 0;
            for (int i = 0; i < bd; i++)
            {
                int kolicina = 0;
                var komanda = (from r in ds.Racun
                               where r.datum_izdavanja.Month == dateTimePicker1.Value.Month && r.datum_izdavanja.Year == dateTimePicker1.Value.Year && r.datum_izdavanja.Day == i+1
                               select r).ToList();
                for (int j = 0; j < komanda.Count; j++)
                {
                    string[] nid = komanda[j].ID_proizvoda.ToString().Split(';');
                    for (int k = 0; k < nid.Length - 1; k++)
                        if (nid[k] == idproizvoda)
                        {
                            string[] nkol = komanda[j].kolicina_proizvoda.ToString().Split(';');
                            kolicina += int.Parse(nkol[k]);
                        }
                }
                if (kolicina > maxudanu)
                    maxudanu = kolicina;
                nizkoludanu[i] = kolicina;
                prodajaproizvoda += kolicina;
            }
            if (maxudanu > 0)
            {
                pravougaonici.Clear();
                for (int i = 0; i < bd; i++)
                {
                    float x = (500 / bd) * i + 25;
                    float visina = (250 / maxudanu) * nizkoludanu[i] + 1;
                    RectangleF r = new RectangleF(x, 50, 6, visina);
                    pravougaonici.Add(r);
                }
                lblPro.Text = "Mesec: " + prodajaproizvoda + " Dan: " + maxudanu;
                lblNaziv.Text= dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
                this.Paint += Prikazi;
                this.Refresh();
            }
            else
                MessageBox.Show("Ovaj proizvod se nije prodao ovog meseca!");
                

        }
        List<RectangleF> pravougaonici = new List<RectangleF>();
        private void Prikazi(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangles(new SolidBrush(Color.Red),pravougaonici.ToArray());
            
        }
    }
}
