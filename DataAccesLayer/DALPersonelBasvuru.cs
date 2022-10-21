using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccesLayer
{
    public class DALPersonelBasvuru
    {
        public static int PersonelBasvuruEkle(EntityPersonelIsBasvurulari parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_PersonelIsBasvurulari(BASVURUTARIHI,ILID,SEYAHATENGELIYOK,ISYERIADI,POZISYON,ACIKLAMA) values (@p2,@p3,@p4,@p5,@p6,@p7)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p2", parametre.BASVURUTARIHI1);
            komut1.Parameters.AddWithValue("@p3", parametre.BASVURILID1);
            komut1.Parameters.AddWithValue("@p4", parametre.SEYAHATENGELIYOK1);
            komut1.Parameters.AddWithValue("@p5", parametre.ISYERIADI1);
            komut1.Parameters.AddWithValue("@p6", parametre.POZISYON1);
            komut1.Parameters.AddWithValue("@p7", parametre.BASVURUACIKLAMA1);
            return komut1.ExecuteNonQuery(); //Eklenilen kayıt sayısını bana döndür.
        }


        public static List<EntityPersonelIsBasvurulari> BasvuruPersonelListesi()
        {

            List<EntityPersonelIsBasvurulari> degerler = new List<EntityPersonelIsBasvurulari>();
            SqlCommand komut2 = new SqlCommand("SELECT * from Tbl_PersonelIsBasvurulari", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {

                EntityPersonelIsBasvurulari ent = new EntityPersonelIsBasvurulari();
                ent.PERSONELID1 = dr["PERSONELID"].ToString();
                ent.BASVURUTARIHI1 = dr["BASVURUTARIHI"].ToString();
                ent.BASVURILID1 = dr["ILID"].ToString();
                ent.SEYAHATENGELIYOK1 = dr["SEYEHATENGELIYOK"].ToString();
                ent.ISYERIADI1 = dr["ISYERIADI"].ToString();
                ent.POZISYON1 = dr["POZISYON"].ToString();
                ent.BASVURUACIKLAMA1 = dr["ACIKLAMA"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool BasvuruPersonelSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_PersonelIsBasvurulari where PERSONELID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", parametre);
            return komut3.ExecuteNonQuery() > 0;


            SqlCommand komut6 = new SqlCommand("Delete From Tbl_Personeller where ID=@P2", Baglanti.bgl);
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            komut6.Parameters.AddWithValue("@P2", parametre);
            return komut6.ExecuteNonQuery() > 0;
        }

        public static List<EntityPersonelIsBasvurulari> BasvuruPersonelDetay(int id)
        {
            List<EntityPersonelIsBasvurulari> degerler = new List<EntityPersonelIsBasvurulari>();
            SqlCommand komut4 = new SqlCommand("Select * from Tbl_PersonelIsBasvurulari Where PERSONELID=@P1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@P1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonelIsBasvurulari ent = new EntityPersonelIsBasvurulari();
                ent.BASVURUTARIHI1 = dr["BASVURUTARIHI"].ToString();
                ent.BASVURILID1 = dr["ILID"].ToString();
                ent.SEYAHATENGELIYOK1 = dr["SEYAHATENGELIYOK"].ToString();
                ent.ISYERIADI1 = dr["ISYERIADI"].ToString();
                ent.POZISYON1 = dr["POZISYON"].ToString();
                ent.BASVURUACIKLAMA1 = dr["ACIKLAMA"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }

        public static bool BasvuruPersonelGuncelle(EntityPersonelIsBasvurulari deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_PersonelIsBasvurulari Set BASVURUTARIHI=@P1,ILID=@P2,SEYAHATENGELIYOK=@P3,ISYERIADI=@P4,POZISYON=@P5,ACIKLAMA=@P6 WHERE PERSONELID=@P9", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.BASVURUTARIHI1);
            komut5.Parameters.AddWithValue("@P2", deger.BASVURILID1);
            komut5.Parameters.AddWithValue("@P3", deger.SEYAHATENGELIYOK1);
            komut5.Parameters.AddWithValue("@P4", deger.ISYERIADI1);
            komut5.Parameters.AddWithValue("@P5", deger.POZISYON1);
            komut5.Parameters.AddWithValue("@P6", deger.BASVURUACIKLAMA1);
            komut5.Parameters.AddWithValue("@P9", deger.PERSONELID1);
            return komut5.ExecuteNonQuery() > 0;
        }


    }
}
