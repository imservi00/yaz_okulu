using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut = new SqlCommand("Select * from TBLDERSLER", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.ID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MİN = int.Parse(dr["DERSMINKONT"].ToString());
                ent.MAX = int.Parse(dr["DERSMAKSKONT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID, DERSID) values (@p1, @p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }

        public static List<EntityBasvuruDetay> BasvuruDetayListesi()
        {
            List<EntityBasvuruDetay> degerler = new List<EntityBasvuruDetay>();
            SqlCommand komut = new SqlCommand("SELECT OgrAd, OgrSoyad, DERSAD FROM TBLBASVURUFORM INNER JOIN TBLOGRENCI ON TBLBASVURUFORM.OGRENCIID = TBLOGRENCI.OgrID INNER JOIN TBLDERSLER ON TBLBASVURUFORM.DERSID = TBLDERSLER.DERSID", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruDetay ent = new EntityBasvuruDetay();
                ent.OgrAd = dr["OgrAd"].ToString();
                ent.OgrSoyad = dr["OgrSoyad"].ToString();
                ent.DersAd = dr["DERSAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }


    }
}
