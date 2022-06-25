using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        //public SqlConnection conection = new SqlConnection("Password=server;User ID=sa;Data Source=CAJA\\SQLEXPRESS; Initial Catalog=No 2 sin 3");
        //Provider=SQLOLEDB.1;Password=server;Persist Security Info=True;User ID=sa;Data Source=CAJA\SQLEXPRESS
        public SqlConnection conection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=No hay 2 sin 3;Data Source=localhost");

        //MARCOS: public SqlConnection conection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NO_HAY_2_SIN_3;Data Source=JACK-PC\\SQLEXPRESS; password=901636814644");

        //public SqlConnection conection = new SqlConnection("Data Source=CAJA\\SQLEXPRESS;Initial Catalog='No hay 2 sin 3'");//Persist Security Info=True;User ID=sa; password=server");
    }
}
