using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}