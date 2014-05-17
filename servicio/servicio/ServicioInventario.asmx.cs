using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Datos;
using negocio;
namespace servicio
{
    /// <summary>
    /// Descripción breve de ServicioInventario
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)] 
    [System.Web.Script.Services.ScriptService]
    public class ServicioInventario : System.Web.Services.WebService
    {
       [WebMethod]
       public DataSet AccesoPortal(String Usuario, String Password)
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtenerUsuario(Usuario, Password);
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
       [WebMethod]
       public DataSet ObtieneRutas(String id_usuario)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneRutas(id_usuario);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
       [WebMethod]
       public DataSet ObtienePuntosVenta(String id_ruta)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtienePuntosVenta(id_ruta);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
       [WebMethod]
       public DataSet ObtieneProductosPV(String id_punto_venta)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneProductosPV(id_punto_venta);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
       [WebMethod]
       public DataSet ObtieneDetalleProducto(String id_producto)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneDetalleProducto(id_producto);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
       [WebMethod]
       public DataSet ObtieneAtribDisponibles(String id_producto)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneAtribDisponibles(id_producto);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
        [WebMethod]
       public DataSet ObtieneProductosDisponibles(String id_punto_venta)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneProductosDisponibles(id_punto_venta);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
        [WebMethod]
        public DataSet ObtieneProductos()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneProductos();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneUsuarios()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneUsuarios();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        } 
        [WebMethod]
        public DataSet ObtieneTodosPuntosVenta()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneTodosPuntosVenta();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtienePerfiles()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtienePerfiles();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneTodasRutas()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneTodasRutas();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneTodosPromotores()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneTodosPromotores();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtienePuntosVentaDisponibles(String id_ruta)
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtienePuntosVentaDisponibles(id_ruta);
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneIdUsuarioPorNombre(String nombre_usuario)
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneIdUsuarioPorNombre(nombre_usuario);
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneIdPerfilPorNombre(String perfil)
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneIdPerfilPorNombre(perfil);
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
        [WebMethod]
        public DataSet ObtieneTodosAtributos()
        {
            DataTable tabla = new DataTable();
            DataSet ds = new DataSet();
            tabla = AccesoLogica.ObtieneTodosAtributos();
            if (tabla.Rows.Count > 0)
            {
                ds.Tables.Add(tabla);
                return ds;
            }
            else
                return null;
        }
       [WebMethod]
       public DataSet ObtienePassword(String email)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.RecuperarPassword(email);
           ds.Tables.Add(tabla);
           return ds;
       } 
       [WebMethod]
       public void CapturarProducto(String id_producto,String id_atributo,String detalle)
       {
           AccesoLogica.CapturarProducto(id_producto, id_atributo, detalle);
       }
       [WebMethod]
       public void AltaUsuario(String login,String password,String email, String id_perfil, String nombre, String Apellidos)
       {
           AccesoLogica.AltaUsuario(login, password, email,id_perfil,nombre,Apellidos);
       }
       [WebMethod]
       public void AddRuta(String nombre_ruta, String fecha, String id_promotor)
       {
           AccesoLogica.AddRuta(nombre_ruta, fecha, id_promotor);
       }
       [WebMethod]
       public void AddRutaPuntoVenta(String id_ruta, String id_punto_venta)
       {
           AccesoLogica.AddRutaPuntoVenta(id_ruta, id_punto_venta);
       }
       [WebMethod]
       public void AddAtribProducto(String nombre)
       {
           AccesoLogica.AddAtribProducto(nombre);
       }
       [WebMethod]
       public void EditaUsuario(String id_usuario, String login, String password, String email, String status, String id_perfil, String nombre, String Apellidos)
       {
           AccesoLogica.EditaUsuario(id_usuario,login, password, email, status, id_perfil, nombre, Apellidos);
       }
       [WebMethod]
       public void EditaRuta(String id_ruta,String nombre_ruta, String fecha, String estatus, String id_promotor)
       {
           AccesoLogica.EditaRuta(id_ruta,nombre_ruta,fecha,estatus,id_promotor);
       }
       [WebMethod]
       public void EditAtribProducto(String id_atributo, String nombre)
       {
           AccesoLogica.EditAtribProducto(id_atributo, nombre);
       }
       [WebMethod]
       public void BajaUsuario(String id_usuario)
       {
           AccesoLogica.BajaUsuario(id_usuario);
       }
       [WebMethod]
       public void BorraRuta(String id_ruta)
       {
           AccesoLogica.BorraRuta(id_ruta);
       } 
       [WebMethod]
       public void BorraRutaPuntoVenta(String id_ruta,String id_punto_venta)
       {
           AccesoLogica.BorraRutaPuntoVenta(id_ruta, id_punto_venta);
       }
       [WebMethod]
       public void AsignaProductoPV(String id_cat_producto, String id_punto_venta)
       {
           AccesoLogica.AsignaProductoPV(id_cat_producto, id_punto_venta);
       }
       [WebMethod]
       public void AgregarProducto(String nombre_producto)
       {
           AccesoLogica.AgregarProducto(nombre_producto);
       }
       [WebMethod]
       public void AltaPuntoVenta(String nombre_pv, String direccion_pv, String descripcion)
       {
           AccesoLogica.AltaPuntoVenta(nombre_pv, direccion_pv, descripcion);
       }
       [WebMethod]
       public void EditarProducto(String nombre_producto,String id_cat_producto)
       {
           AccesoLogica.EditarProducto(nombre_producto,id_cat_producto);
       }
       [WebMethod]
       public void EditaPuntoVenta(String id_punto_venta, String nombre_pv, String direccion_pv, String descripcion)
       {
           AccesoLogica.EditaPuntoVenta(id_punto_venta, nombre_pv, direccion_pv, descripcion);
       }
       [WebMethod]
       public void BorrarProducto(String id_cat_producto)
       {
           AccesoLogica.BorrarProducto(id_cat_producto);
       }
       [WebMethod]
       public void BorrarPuntoVenta(String id_punto_venta)
       {
           AccesoLogica.BorrarPuntoVenta(id_punto_venta);
       }
        //catalogos
       [WebMethod]
       public DataSet ObtieneCatlogin()
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneCatlogin();
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
       [WebMethod]
       public void CargaLote(String id_usuario, String nombre_ruta, String nombre_pv, String direccion_pv, String descripcion, String nombre_producto, String atributo, String valor)
       {
           AccesoLogica.CargaLote(id_usuario, nombre_ruta, nombre_pv, direccion_pv, descripcion, nombre_producto, atributo, valor);
       }
       [WebMethod]
       public DataSet ObtieneLoteOffline(String id_usuario)
       {
           DataTable tabla = new DataTable();
           DataSet ds = new DataSet();
           tabla = AccesoLogica.ObtieneLoteOffline(id_usuario);
           if (tabla.Rows.Count > 0)
           {
               ds.Tables.Add(tabla);
               return ds;
           }
           else
               return null;
       }
    }
}
