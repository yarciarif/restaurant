using System;
using System.Data.SqlClient;
using System.Data;

namespace restaurant
{
    class CPersonelHareketleri
    {
        CGenel gnl = new CGenel();
        #region Fields
        private int _ID;
        private int _PersonelID;
        private string _Islem;
        private DateTime _Tarih;
        private bool _Durum;
        #endregion
        #region Properties

        public int ID { get => _ID; set => _ID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public bool Durum { get => _Durum; set => _Durum = value; } 
        #endregion
        public bool PersonelActionSave(CPersonelHareketleri ph)
        {
            bool result = false;


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert into personelHareketleri(PersonelID,Islem,Tarih)Values(@personelID,@islem,@tarih)", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personelID", SqlDbType.Int).Value = ph._PersonelID;
                cmd.Parameters.Add("@islem", SqlDbType.VarChar).Value = ph._Islem;
                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = ph._Tarih;

                // artık bu yukardaki verileri işleyebiliriz bool veritipine çevirerek
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
    }
}
