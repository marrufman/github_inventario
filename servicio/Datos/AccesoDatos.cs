using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        public static DataTable ObtenerUsuario(string Usr,string Pass)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_LoginUsuario '" + Usr + "','" + Pass + "'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable RecuperarPassword(string email)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_RecuperaPassword '" + email + "'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneRutas(String id_usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneRutas " + id_usuario;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtienePuntosVenta(String id_ruta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtienePuntosVenta " + id_ruta;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneProductosPV(String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneProductosPV " + id_punto_venta;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneDetalleProducto(String id_producto)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_detalleProcutos " + id_producto;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneAtribDisponibles(String id_producto)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneAtribDisponibles " + id_producto;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneProductosDisponibles(String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneProductosDisponibles " + id_punto_venta;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneProductos()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneProductos";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneUsuarios()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneUsuarios";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneTodosPuntosVenta()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneTodosPuntosVenta";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtienePerfiles()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtienePerfiles";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneTodasRutas()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneTodasRutas";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneTodosPromotores()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneTodosPromotores";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneTodosAtributos()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneTodosAtributos";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtienePuntosVentaDisponibles(String id_ruta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtienePuntosVentaDisponibles "+id_ruta;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneIdUsuarioPorNombre(String nombre_usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneIdUsuarioPorNombre '" + nombre_usuario + "'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable ObtieneIdPerfilPorNombre(String perfil)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneIdPerfilPorNombre '" + perfil + "'";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static void CapturarProducto(String id_producto,String id_atributo, String Detalle)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_CapturarProducto " + id_producto+","+id_atributo+",'"+Detalle+"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AddRuta(String nombre_ruta, String fecha, String id_promotor)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AddRuta '" + nombre_ruta + "','" + fecha + "'," + id_promotor;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AddRutaPuntoVenta(String id_ruta, String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AddRutaPuntoVenta " + id_ruta + "," + id_punto_venta;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AltaUsuario(String login, String password, String email, String id_perfil, String nombre, String Apellidos)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AltaUsuario '" + login + "','" + password + "','" + email + "',1,"+id_perfil+",'"+nombre+"','"+Apellidos+"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AddAtribProducto(String nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AddAtribProducto '" + nombre +"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void EditaUsuario(String id_usuario,String login, String password, String email, String status, String id_perfil, String nombre, String Apellidos)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_EditaUsuario "+id_usuario+",'" + login + "','" + password + "','" + email + "',"+status+"," + id_perfil + ",'" + nombre + "','" + Apellidos + "'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void EditaRuta(String id_ruta, String nombre_ruta, String fecha, String estatus, String id_promotor)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_EditaRuta " + id_ruta + ",'" + nombre_ruta + "','" + fecha + "'," + estatus +","+id_promotor;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void EditAtribProducto(String id_atributo, String nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_EditAtribProducto " + id_atributo + ",'" + nombre + "'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void BajaUsuario(String id_usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_BajaUsuario " + id_usuario ;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void BorraRuta(String id_ruta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_BorraRuta " + id_ruta;
            MetodosDatos.EjecutarComandoInsert(_comando);
        } 
        public static void AgregarProducto(String nombre_producto)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AgregarProducto '" + nombre_producto + "'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AltaPuntoVenta(String nombre_pv, String direccion_pv, String descripcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AltaPuntoVenta '" + nombre_pv + "','" + direccion_pv + "','"+descripcion+"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void AsignaProductoPV(String id_cat_producto, String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_AddProdPtoVta " + id_cat_producto + "," + id_punto_venta;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void EditarProducto(String nombre_producto, String id_cat_producto)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_editarCatProducto " + id_cat_producto + ",'" + nombre_producto+"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void EditaPuntoVenta(String id_punto_venta, String nombre_pv, String direccion_pv, String descripcion)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_EditaPuntoVenta " + id_punto_venta + ",'" + nombre_pv + "','" + direccion_pv + "','" + descripcion + "'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void BorrarProducto(String id_cat_producto)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_borrarCatProducto " + id_cat_producto ;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void BorrarPuntoVenta(String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_BorrarPuntoVenta " + id_punto_venta;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static void BorraRutaPuntoVenta(String id_ruta,String id_punto_venta)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_BorraRutaPuntoVenta " +id_ruta+","+id_punto_venta;
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static DataTable ObtieneCatlogin()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select * from login";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
        public static void CargaLote(String id_usuario, String nombre_ruta, String nombre_pv, String direccion_pv,String descripcion, String nombre_producto, String atributo, String valor)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_CargaLote " + id_usuario + ",'" + nombre_ruta+"','"+nombre_pv+"','"+direccion_pv+"','"+
                descripcion+"','"+nombre_producto+"','"+atributo+"','"+valor+"'";
            MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static DataTable ObtieneLoteOffline(String id_usuario)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "sp_ObtieneLoteOffline " + id_usuario;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
    }
}
