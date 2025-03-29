using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkulu
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> EntDers = BLLDers.BLLListele();
                DropDownList1.DataSource = BLLDers.BLLListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

                List<EntityOgrenci> EntOgrenci = BLLOgrenci.BLLListele();
                DropDownList2.DataSource = BLLOgrenci.BLLListele();
                DropDownList2.DataTextField = "ID";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataBind();

                List<EntityBasvuruDetay> basvuruDetayListesi = BLLDers.BLLBasvuruDetayListele();
                GridView1.DataSource = basvuruDetayListesi;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASOGRID = int.Parse(DropDownList2.SelectedValue);
            ent.BASDERSID = DropDownList1.SelectedValue;
            BLLDers.TalepEkleBLL(ent);
        }
    }
}