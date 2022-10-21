using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccesLayer
{
    public class DALPersonel
    {
        public static int PersonelEkle(EntityPersoneller parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_Personeller(ADISOYADI,ILID,ILCEID,CINSIYET,DOGUMTARIHI,ACIKLAMA) values (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.ADISOYADI1);
            komut1.Parameters.AddWithValue("@p2", parametre.ILID1);
            komut1.Parameters.AddWithValue("@p3", parametre.ILCEID1);
            komut1.Parameters.AddWithValue("@p4", parametre.CINSIYET1);
            komut1.Parameters.AddWithValue("@p5", parametre.DOGUMTARIHI1);
            komut1.Parameters.AddWithValue("@p6", parametre.ACIKLAMA1);
            return komut1.ExecuteNonQuery(); //Eklenilen kayıt sayısını bana döndür.
        }

        public static List<EntityPersoneller> PersonelListesi()
        {

            List<EntityPersoneller> degerler = new List<EntityPersoneller>();
            SqlCommand komut2 = new SqlCommand("SELECT * from Tbl_Personeller", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {

                EntityPersoneller ent = new EntityPersoneller();
                ent.ID1 = dr["ID"].ToString();
                ent.ADISOYADI1 = dr["ADISOYADI"].ToString();
                ent.ILID1 = dr["ILID"].ToString();
                ent.ILCEID1 = dr["ILCEID"].ToString();
                ent.CINSIYET1 = dr["CINSIYET"].ToString();
                ent.DOGUMTARIHI1 = dr["DOGUMTARIHI"].ToString();
                ent.ACIKLAMA1 = dr["ACIKLAMA"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool PersonelSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_Personeller where ID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", parametre);
            return komut3.ExecuteNonQuery() > 0;

            SqlCommand komut6 = new SqlCommand("Delete From Tbl_PersonelIsBasvurulari where PERSONELID=@P2", Baglanti.bgl);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            komut6.Parameters.AddWithValue("@P2", parametre);
            return komut6.ExecuteNonQuery() > 0;

        }

        public static List<EntityPersoneller> PersonelDetay(int id)
        {
            List<EntityPersoneller> degerler = new List<EntityPersoneller>();
            SqlCommand komut4 = new SqlCommand("Select * from Tbl_Personeller Where ID=@P1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@P1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityPersoneller ent = new EntityPersoneller();
                ent.ADISOYADI1 = dr["ADISOYADI"].ToString();
                ent.ILID1 = dr["ILID"].ToString();
                ent.ILCEID1 = dr["ILCEID"].ToString();
                ent.CINSIYET1 = dr["CINSIYET"].ToString();
                ent.DOGUMTARIHI1 = dr["DOGUMTARIHI"].ToString();
                ent.ACIKLAMA1 = dr["ACIKLAMA"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool PersonelGuncelle(EntityPersoneller deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Personeller Set ADISOYADI=@P1,ILID=@P2,ILCEID=@P3,CINSIYET=@P4,DOGUMTARIHI=@P5,ACIKLAMA=@P6 WHERE ID=@P9", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.ADISOYADI1);
            komut5.Parameters.AddWithValue("@P2", deger.ILID1);
            komut5.Parameters.AddWithValue("@P3", deger.ILCEID1);
            komut5.Parameters.AddWithValue("@P4", deger.CINSIYET1);
            komut5.Parameters.AddWithValue("@P5", deger.DOGUMTARIHI1);
            komut5.Parameters.AddWithValue("@P6", deger.ACIKLAMA1);
            komut5.Parameters.AddWithValue("@P9", deger.ID1);
            return komut5.ExecuteNonQuery() > 0;
        }


    }
}
