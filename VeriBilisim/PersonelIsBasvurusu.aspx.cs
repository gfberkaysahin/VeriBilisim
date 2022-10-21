using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

namespace VeriBilisim
{
    public partial class PersonelIsBasvurusu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonelIsBasvurulari entbasvuru = new EntityPersonelIsBasvurulari();
            entbasvuru.BASVURUTARIHI1 = TxtBasvuruTarihi.Text;
            entbasvuru.BASVURILID1 = TxtIlID.Text;
            entbasvuru.SEYAHATENGELIYOK1 = TxtSeyahatEngeliYok.Text;
            entbasvuru.ISYERIADI1 = TxtIsYeriAdi.Text;
            entbasvuru.POZISYON1 = TxtPozisyon.Text;
            entbasvuru.BASVURUACIKLAMA1 = TxtAciklama.Text;
            BLLPersonelIsBasvuru.PersonelBasvuruEkleBLL(entbasvuru);
            Response.Redirect("PersonelListele.aspx");

        }
    }
}