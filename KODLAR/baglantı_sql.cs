using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Otomasyon
{
    class baglantı_sql
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanıyor = new SqlConnection(@"Data Source=sizin bilgileriniz;Initial Catalog=admın_otomasyon;Integrated Security=True");
            baglanıyor.Open();
            return baglanıyor;
        }
    }
  
}
