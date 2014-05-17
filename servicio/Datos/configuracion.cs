using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class configuracion
    {
        static string cadenaConexion = @"Data Source=localhost;Initial Catalog=inventario;User ID=sa;Password=Vn36175";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
