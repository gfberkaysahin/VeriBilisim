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
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityPersoneller> PersonelList = BLLPersonel.BllDetay(x);
                TxtAdıSoyadı.Text = PersonelList[0].ADISOYADI1.ToString();
                TxtIlId.Text = PersonelList[0].ILID1.ToString();
                TxtIlceId.Text = PersonelList[0].ILCEID1.ToString();
                TxtCinsiyet.Text = PersonelList[0].CINSIYET1.ToString();
                TxtDogumTarihi.Text = PersonelList[0].DOGUMTARIHI1.ToString();
                TxtAcıklama.Text = PersonelList[0].ACIKLAMA1.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersoneller ent = new EntityPersoneller();
            ent.ID1 = TxtId.Text;
            ent.ADISOYADI1 = TxtAdıSoyadı.Text;
            ent.ILID1 = TxtIlId.Text;
            ent.ILCEID1 = TxtIlceId.Text;
            ent.CINSIYET1 = TxtCinsiyet.Text;
            ent.DOGUMTARIHI1 = TxtDogumTarihi.Text;
            ent.ACIKLAMA1 = TxtAcıklama.Text;
            BLLPersonel.PersonelGuncelleBLL(ent);
            Response.Redirect("PersonelListele.aspx");

        }
    }
}