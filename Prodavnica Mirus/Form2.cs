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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Form2NoviProizvod fnp = new Form2NoviProizvod();
            fnp.ShowDialog();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            Form2Racuni fr = new Form2Racuni();
            fr.ShowDialog();
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            Form2ProdajaProizvoda fpp = new Form2ProdajaProizvoda();
            fpp.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
