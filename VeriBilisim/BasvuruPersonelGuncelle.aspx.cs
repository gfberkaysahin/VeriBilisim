using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;

namespace VeriBilisim
{
    public partial class BasvuruPersonelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            TxtPersonelId.Text = x.ToString();
            TxtPersonelId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityPersonelIsBasvurulari> BasvuruPersonelList = BLLPersonelIsBasvuru.BllBasvuruDetay(x);
                TxtBasvuruTarihi.Text = BasvuruPersonelList[0].BASVURUTARIHI1.ToString();
                TxtIlID.Text = BasvuruPersonelList[0].BASVURILID1.ToString();
                TxtSeyahatEngeliYok.Text = BasvuruPersonelList[0].SEYAHATENGELIYOK1.ToString();
                TxtIsYeriAdi.Text = BasvuruPersonelList[0].ISYERIADI1.ToString();
                TxtPozisyon.Text = BasvuruPersonelList[0].POZISYON1.ToString();
                TxtAciklama.Text = BasvuruPersonelList[0].BASVURUACIKLAMA1.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonelIsBasvurulari ent = new EntityPersonelIsBasvurulari();
            ent.PERSONELID1 = TxtPersonelId.Text;
            ent.BASVURUTARIHI1 = TxtBasvuruTarihi.Text;
            ent.BASVURILID1 = TxtIlID.Text;
            ent.SEYAHATENGELIYOK1 = TxtSeyahatEngeliYok.Text;
            ent.ISYERIADI1 = TxtIsYeriAdi.Text;
            ent.POZISYON1 = TxtPozisyon.Text;
            ent.BASVURUACIKLAMA1 = TxtAciklama.Text;
            BLLPersonelIsBasvuru.BasvuruPersonelGuncelleBLL(ent);
            Response.Redirect("BasvuruPersonelListesi.aspx");

        }
    }
}