using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VeriBilisim
{
    public partial class BasvuruPersonelListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Getir();

        }

        public void Getir()
        {

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            string connectionString = baglansatir();
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("SELECT K.ID,KY.BASVURUTARIHI,Y.ADI,KY.SEYAHATENGELIYOK,KY.ISYERIADI,KY.POZISYON,KY.ACIKLAMA FROM Tbl_Personeller K INNER JOIN Tbl_PersonelIsBasvurulari KY ON K.ID= KY.PERSONELID INNER JOIN Tbl_Iller Y ON KY.ILID=Y.ID", conn);
            try
            {

                conn.Open();
                reader = comm.ExecuteReader();

                rp1.DataSource = reader;
                rp1.DataBind();

                reader.Close();
            }
            catch
            {

                Response.Write("Veri okuma işleminde hata meydana geldi!");
            }
            finally
            {

                conn.Close();
            }
        }
        public string baglansatir()
        {
            return "Data Source=.;Initial Catalog=DbVeriBilisim;Integrated Security=True";
        }
    }
}