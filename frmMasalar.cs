using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", " Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void BtnMasa1_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa1.Text.Length;
            CGenel._buttonValue = btnMasa1.Text.Substring(uzunluk-6, 6);
            CGenel._buttonName = btnMasa1.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa2_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa2.Text.Length;
            CGenel._buttonValue = btnMasa2.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa2.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa3_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa3.Text.Length;
            CGenel._buttonValue = btnMasa3.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa3.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa4_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa4.Text.Length;
            CGenel._buttonValue = btnMasa4.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa4.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa5_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa5.Text.Length;
            CGenel._buttonValue = btnMasa5.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa5.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa6_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa6.Text.Length;
            CGenel._buttonValue = btnMasa6.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa6.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa7_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa7.Text.Length;
            CGenel._buttonValue = btnMasa7.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa7.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa8_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa8.Text.Length;
            CGenel._buttonValue = btnMasa8.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa8.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa9_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa9.Text.Length;
            CGenel._buttonValue = btnMasa9.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa9.Name;
            this.Close();
            frm.ShowDialog();
        }

        private void BtnMasa10_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            int uzunluk = btnMasa10.Text.Length;
            CGenel._buttonValue = btnMasa10.Text.Substring(uzunluk - 6, 6);
            CGenel._buttonName = btnMasa10.Name;
            this.Close();
            frm.ShowDialog();
        }
        CGenel gnl = new CGenel();
        private void FrmMasalar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Durum,ID from masalar",con);
            SqlDataReader dr = null;
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                foreach(Control item in this.Controls)
                {
                    if(item is Button)
                    {
                        if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "1")
                        {
                            item.BackgroundImage = Properties.Resources.rBoş;
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "2")
                        {
                            cMasalar ms = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(ms.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(ms.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;

                            item.Text = string.Format("{0} {1} {2}",
                                fark.Days > 0 ? string.Format("{0} Gün", fark.Days) : " ",
                                fark.Hours > 0 ? string.Format("{0} Saat", fark.Hours) : " ",
                                fark.Minutes > 0 ? string.Format("{0} Dakika", fark.Minutes) : " ").Trim() + "\n\n\nMasa" + dr["ID"].ToString();
                                
                            item.BackgroundImage = Properties.Resources.rDolu;
                        }
                        else if(item.Name == "btnMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "3")
                        {
                            item.BackgroundImage =(Properties.Resources.rAcikRezerve);
                        }
                        else if (item.Name == "btnMasa" + dr["ID"].ToString() && dr["Durum"].ToString() == "4")
                        {
                            item.BackgroundImage = (Properties.Resources.rRezerve);
                        }
                    }
                }
            }
        }
    }
}
