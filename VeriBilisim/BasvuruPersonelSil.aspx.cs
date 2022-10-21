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
    public partial class BasvuruPersonelSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            Response.Write(x);
            EntityPersonelIsBasvurulari ent = new EntityPersonelIsBasvurulari();
            ent.PERSONELID1 = x.ToString();
            BLLPersonelIsBasvuru.BasvuruPersonelSilBLL(x);
            Response.Redirect("BasvuruPersonelListesi.Aspx");

        }
    }
}