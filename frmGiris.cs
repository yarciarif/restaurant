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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        
        private void FrmGiris_Load_1(object sender, EventArgs e)
        {
            CPersoneller P = new CPersoneller();
            P.PersonelGetByInformation(cbKullanici);
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            CGenel gnl = new CGenel();
            CPersoneller P = new CPersoneller();
            bool result = P.PersonelEntryControl(txtSifre.Text,CGenel._personelId);

            if (result)
            {
                //Burda Personel Hareketlerini denetlemek için ch değişkeninde yeni girişler sağlıyoruz !!!
                CPersonelHareketleri ch = new CPersonelHareketleri();
                ch.PersonelID = CGenel._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış !", "Uyarı !!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPersoneller P = (CPersoneller)cbKullanici.SelectedItem;
            CGenel._personelId= P.PersonelID;
            CGenel._gorevId = P.PersonelGorevID;
        }

        private void LblKadi_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?"," Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
