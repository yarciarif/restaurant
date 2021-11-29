using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace restaurant
{
    class CPersoneller
    {
        CGenel gnl = new CGenel();
        #region Fields
        private int _PersonelID;
        private int _PersonelGorevID;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelID
        {
            get => _PersonelID;
            set => _PersonelID = value;
        }
        public int PersonelGorevID
        {
            get => _PersonelGorevID;
            set => _PersonelGorevID = value;
        }
        public string PersonelAd
        {
            get => _PersonelAd;
            set => _PersonelAd = value;
        }
        public string PersonelSoyad
        {
            get => _PersonelSoyad;
            set => _PersonelSoyad = value;
        }


        public string PersonelParola
        {
            get => _PersonelParola;
            set => _PersonelParola = value;
        }
        public string PersonelKullaniciAdi
        {
            get => _PersonelKullaniciAdi;
            set => _PersonelKullaniciAdi = value;
        }
        public bool PersonelDurum
        {
            get => _PersonelDurum;
            set => _PersonelDurum = value;
        }


        #endregion

        public bool PersonelEntryControl(string password, int userId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personeller where ID=@Id and Parola=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = userId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }


            return result;
        }
        public void PersonelGetByInformation(ComboBox cb)
        {
            cb.Items.Clear();

            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Personeller", con);


            if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                CPersoneller P = new CPersoneller();
                P.PersonelID = Convert.ToInt32(dr["ID"]);
                P.PersonelAd = Convert.ToString(dr["Ad"]);
                P.PersonelSoyad = Convert.ToString(dr["Soyad"]);
                P.PersonelParola = Convert.ToString(dr["Parola"]);
                P.PersonelKullaniciAdi = Convert.ToString(dr["KullaniciAdi"]);
                P.PersonelDurum = Convert.ToBoolean(dr["Durum"]);

                cb.Items.Add(P);
            }
            dr.Close();
            con.Close();

            }

        public override string ToString()
        { 
            return PersonelAd + " " + PersonelSoyad;
        }
            
        }
    }