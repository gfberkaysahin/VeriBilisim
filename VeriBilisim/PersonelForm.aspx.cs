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
    public partial class PersonelForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersoneller ent = new EntityPersoneller();
            ent.ADISOYADI1 = TxtAdıSoyadı.Text;
            ent.ILID1 = TxtIlId.Text;
            ent.ILCEID1 = TxtIlceId.Text;
            ent.CINSIYET1 = TxtCinsiyet.Text;
            ent.DOGUMTARIHI1 = TxtDogumTarihi.Text;
            ent.ACIKLAMA1 = TxtAcıklama.Text;
            BLLPersonel.PersonelEkleBLL(ent);
            Response.Redirect("PersonelIsBasvurusu.Aspx");

        }
    }
}