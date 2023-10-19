 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Soytur1
{
    class SqlBaglantisi
    {
        // Sınıflar içerisinde tek tek bağlantı oluşturmak yerine bir tane bağlantı sınıfı oluşturuldu.

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=CANER\\SQLEXPRESS;Initial Catalog=Soytur;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
