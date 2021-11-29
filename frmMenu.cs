using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnMasaSiparis_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyonlar frm = new frmRezervasyonlar();
            this.Close();
            frm.Show();
        }

        private void BtnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            this.Close();
            frm.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void BtnKasaIslemleri_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            this.Close();
            frm.Show();
        }

        private void BtnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void BtnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void BtnKilit_Click(object sender, EventArgs e)
        {
            frmKilit frm = new frmKilit();
            this.Close();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", " Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
