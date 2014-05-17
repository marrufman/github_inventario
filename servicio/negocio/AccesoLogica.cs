using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace negocio
{
    public class AccesoLogica
    {
        public static DataTable ObtenerUsuario(string Usr,string Pass)
        {
            return AccesoDatos.ObtenerUsuario(Usr, Pass);
        }
        public static DataTable RecuperarPassword(string email)
        {
            return AccesoDatos.RecuperarPassword(email);
        }
        public static DataTable ObtieneRutas(String id_usuario)
        {
            return AccesoDatos.ObtieneRutas(id_usuario);
        }
        public static DataTable ObtienePuntosVenta(String id_ruta)
        {
            return AccesoDatos.ObtienePuntosVenta(id_ruta);
        }
        public static DataTable ObtieneProductosPV(String id_punto_venta)
        {
            return AccesoDatos.ObtieneProductosPV(id_punto_venta);
        }
        public static DataTable ObtieneDetalleProducto(String id_producto)
        {
            return AccesoDatos.ObtieneDetalleProducto(id_producto);
        }
        public static DataTable ObtieneAtribDisponibles(String id_producto)
        {
            return AccesoDatos.ObtieneAtribDisponibles(id_producto);
        }
        public static DataTable ObtieneProductosDisponibles(String id_punto_venta)
        {
            return AccesoDatos.ObtieneProductosDisponibles(id_punto_venta);
        }
        public static DataTable ObtieneProductos()
        {
            return AccesoDatos.ObtieneProductos();
        }
        public static DataTable ObtieneUsuarios()
        {
            return AccesoDatos.ObtieneUsuarios();
        }
        public static DataTable ObtieneTodosPuntosVenta()
        {
            return AccesoDatos.ObtieneTodosPuntosVenta();
        }
        public static DataTable ObtienePerfiles()
        {
            return AccesoDatos.ObtienePerfiles();
        }
        public static DataTable ObtieneTodasRutas()
        {
            return AccesoDatos.ObtieneTodasRutas();
        }
        public static DataTable ObtieneTodosPromotores()
        {
            return AccesoDatos.ObtieneTodosPromotores();
        }
        public static DataTable ObtieneTodosAtributos()
        {
            return AccesoDatos.ObtieneTodosAtributos();
        }
        public static DataTable ObtienePuntosVentaDisponibles(String id_ruta)
        {
            return AccesoDatos.ObtienePuntosVentaDisponibles(id_ruta);
        }
        public static DataTable ObtieneIdUsuarioPorNombre(String nombre_usuario)
        {
            return AccesoDatos.ObtieneIdUsuarioPorNombre(nombre_usuario);
        }
        public static DataTable ObtieneIdPerfilPorNombre(String perfil)
        {
            return AccesoDatos.ObtieneIdPerfilPorNombre(perfil);
        } 
        public static void CapturarProducto(String id_producto, String id_atributo, String Detalle)
        {
            AccesoDatos.CapturarProducto(id_producto, id_atributo, Detalle);
        }
        public static void AltaUsuario(String login, String password, String email, String id_perfil, String nombre, String Apellidos)
        {
            AccesoDatos.AltaUsuario(login, password, email, id_perfil, nombre, Apellidos);
        }
        public static void AddRuta(String nombre_ruta, String fecha, String id_promotor)
        {
            AccesoDatos.AddRuta(nombre_ruta, fecha, id_promotor);
        }
        public static void AddRutaPuntoVenta(String id_ruta, String id_punto_venta)
        {
            AccesoDatos.AddRutaPuntoVenta(id_ruta,id_punto_venta);
        }
        public static void AddAtribProducto(String nombre)
        {
            AccesoDatos.AddAtribProducto(nombre);
        }
        public static void EditaUsuario(String id_usuario,String login, String password, String email, String status, String id_perfil, String nombre, String Apellidos)
        {
            AccesoDatos.EditaUsuario(id_usuario,login, password, email, status, id_perfil, nombre, Apellidos);
        }
        public static void EditaRuta(String id_ruta,String nombre_ruta, String fecha, String estatus, String id_promotor)
        {
            AccesoDatos.EditaRuta(id_ruta,nombre_ruta,fecha,estatus,id_promotor);
        }
        public static void EditAtribProducto(String id_atributo, String nombre)
        {
            AccesoDatos.EditAtribProducto(id_atributo, nombre);
        }
        public static void BajaUsuario(String id_usuario)
        {
            AccesoDatos.BajaUsuario(id_usuario);
        }
        public static void BorraRuta(String id_ruta)
        {
            AccesoDatos.BorraRuta(id_ruta);
        }
        public static void BorraRutaPuntoVenta(String id_ruta, String id_punto_venta)
        {
            AccesoDatos.BorraRutaPuntoVenta(id_ruta, id_punto_venta);
        }
        public static void AgregarProducto(String nombre_producto)
        {
            AccesoDatos.AgregarProducto(nombre_producto);
        }
        public static void AltaPuntoVenta(String nombre_pv, String direccion_pv, String descripcion)
        {
            AccesoDatos.AltaPuntoVenta(nombre_pv, direccion_pv, descripcion);
        }
        public static void EditarProducto(String nombre_producto, String id_cat_producto)
        {
            AccesoDatos.EditarProducto(nombre_producto, id_cat_producto);
        }
        public static void EditaPuntoVenta(String id_punto_venta, String nombre_pv, String direccion_pv, String descripcion)
        {
            AccesoDatos.EditaPuntoVenta(id_punto_venta, nombre_pv, direccion_pv, descripcion);
        }
        public static void BorrarProducto( String id_cat_producto)
        {
            AccesoDatos.BorrarProducto(id_cat_producto);
        }
        public static void BorrarPuntoVenta(String id_punto_venta)
        {
            AccesoDatos.BorrarPuntoVenta(id_punto_venta);
        }
        public static void AsignaProductoPV(String id_cat_producto, String id_punto_venta)
        {
            AccesoDatos.AsignaProductoPV(id_cat_producto, id_punto_venta);
        }
        public static DataTable ObtieneCatlogin()
        {
            return AccesoDatos.ObtieneCatlogin();
        }
        public static void CargaLote(String id_usuario, String nombre_ruta, String nombre_pv, String direccion_pv, String descripcion, String nombre_producto, String atributo, String valor)
        {
            AccesoDatos.CargaLote(id_usuario, nombre_ruta, nombre_pv, direccion_pv, descripcion, nombre_producto, atributo, valor);
        }
        public static DataTable ObtieneLoteOffline(String id_usuario)
        {
            return AccesoDatos.ObtieneLoteOffline(id_usuario);
        }
    }
}
