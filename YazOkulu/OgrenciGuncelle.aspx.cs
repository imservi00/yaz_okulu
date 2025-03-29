using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TextID.Text = x.ToString();
            TextID.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BLLDetay(x);
                TxtAd.Text = OgrList[0].AD.ToString();
                TextSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].NUMARA.ToString();
                TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
                TxtSifre.Text = OgrList[0].SİFRE.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.ID = Convert.ToInt32(TextID.Text);
            ent.AD = TxtAd.Text;
            ent.SOYAD = TextSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            ent.SİFRE = TxtSifre.Text;
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}