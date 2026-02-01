using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kitaplikprojesi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=MELISA;Initial Catalog=ogrencinotkayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
    internal class Class1
    {
    }
}

