using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Server=DESKTOP-TVLOELV;Database=DbYazOkulu;Trusted_Connection=True;");
    }
}
