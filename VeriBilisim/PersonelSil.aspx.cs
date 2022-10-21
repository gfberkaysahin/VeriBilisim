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
    public partial class PersonelSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            Response.Write(x);
            EntityPersoneller ent = new EntityPersoneller();
            ent.ID1 = x.ToString();
            BLLPersonel.PersonelSilBLL(x);
            Response.Redirect("PersonelListele.Aspx");

        }
    }
}