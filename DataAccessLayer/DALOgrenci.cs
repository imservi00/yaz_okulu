using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSıfre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.AD);
            komut.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut.Parameters.AddWithValue("@p5", parametre.SİFRE);
            return komut.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSıfre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRENCI where OgrID=@p1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * from TBLOGRENCI WHERE OGRID=@P1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@P1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["OgrAd"].ToString();
                ent.SOYAD = dr["OgrSoyad"].ToString();
                ent.NUMARA = dr["OgrNumara"].ToString();
                ent.FOTOGRAF = dr["OgrFoto"].ToString();
                ent.SİFRE = dr["OgrSıfre"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCI set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSıfre=@p5 where OgrID=@p6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.AD);
            komut5.Parameters.AddWithValue("@p2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@p3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@p4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@p5", deger.SİFRE);
            komut5.Parameters.AddWithValue("@p6", deger.ID);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}