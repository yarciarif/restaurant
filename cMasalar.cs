using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _Kapasite;
        private int _ServisTuru;
        private int _Durum;
        private int _Onay;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int Kapasite { get => _Kapasite; set => _Kapasite = value; }
        public int ServisTuru { get => _ServisTuru; set => _ServisTuru = value; }
        public int Durum { get => _Durum; set => _Durum = value; }
        public int Onay { get => _Onay; set => _Onay = value; }
        #endregion
        CGenel gnl = new CGenel();
        
        public string SessionSum(int state)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select Tarih,MasaID from adisyon Right join masalar on adisyon.MasaID=masalar.ID where masalar.Durum=@durum and adisyon.Durum=0", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;

            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt; 
        }
    }
}
