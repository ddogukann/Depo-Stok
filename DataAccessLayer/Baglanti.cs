using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DataAccessLayer
{
     public class Baglanti
    {
       
       public static OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\10.0.1.17\bugsas\Destek Hizmetleri\DESTEK HİZMETLERİ ORTAK\Stok_Programi_Veritabani\stok.mdb; Jet OLEDB:Database Password=Bugsas2389;");
       

           
    }
}
