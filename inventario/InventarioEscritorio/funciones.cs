using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;

namespace InventarioEscritorio
{
    class funciones
    {
        public static string path = Directory.GetCurrentDirectory()+ "\\XML\\";
        ServiceReference1.ServicioInventarioSoapClient servicio = new ServiceReference1.ServicioInventarioSoapClient();
        public void leeCatalogosXML()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //login
            DataSet dscat = new DataSet();
            dscat = servicio.ObtieneCatlogin();
            dscat.WriteXml(path + "login.xml");
            dscat = null;
            //rutas
            dscat = servicio.ObtieneTodasRutas();
            dscat.WriteXml(path + "rutas.xml");
            dscat = null;
            //puntos venta
            dscat = servicio.ObtieneTodosPuntosVenta();
            dscat.WriteXml(path + "punto_venta.xml");
            dscat = null;
            //cat_productos
            dscat = servicio.ObtieneProductos();
            dscat.WriteXml(path + "cat_productos.xml");
            dscat = null;
            //cat_atributos
            dscat = servicio.ObtieneTodosAtributos();
            dscat.WriteXml(path + "cat_atributos_producto.xml");
            dscat = null;
        }
        public void CreaXMLCarga(String nombre_ruta, String nombre_pv, String direccion_pv, String descripcion_pv, String nombre_producto, String atributo, String valor)
        {
            //revisamos si existe un xml
            DataTable dt = new DataTable();
            string ArchivoSale =path + "DatosCargaOffline.xml";
            if (!File.Exists(ArchivoSale))
            {         
                //si no existe lo creamos
                dt.TableName = "Table1";
                dt.Columns.Add("nombre_ruta");
                dt.Columns.Add("nombre_pv");
                dt.Columns.Add("direccion_pv");
                dt.Columns.Add("descripcion_pv");
                dt.Columns.Add("nombre_producto");
                dt.Columns.Add("atributo");
                dt.Columns.Add("valor");
                dt.Columns.Add("cargado");
                DataRow row = dt.NewRow();
                row["nombre_ruta"] = nombre_ruta;
                row["nombre_pv"] = nombre_pv;
                row["direccion_pv"] = direccion_pv;
                row["descripcion_pv"] = descripcion_pv;
                row["nombre_producto"] = nombre_producto;
                row["atributo"] = atributo;
                row["valor"] = valor;
                row["cargado"] = 0;
                dt.Rows.Add(row);
                dt.WriteXml(ArchivoSale);
            }
            else
            {
                //si existe lo abrimos para edicion. ;)
                DataSet ds = new DataSet();
                ds.ReadXml(ArchivoSale);
                foreach (DataTable dataTable in ds.Tables)
                    dataTable.EndLoadData();
                DataRow row = ds.Tables[0].NewRow();
                row["nombre_ruta"] = nombre_ruta;
                row["nombre_pv"] = nombre_pv;
                row["direccion_pv"] = direccion_pv;
                row["descripcion_pv"] = descripcion_pv;
                row["nombre_producto"] = nombre_producto;
                row["atributo"] = atributo;
                row["valor"] = valor;
                row["cargado"] = 0;
                ds.Tables[0].Rows.Add(row);
                ds.WriteXml(ArchivoSale);
            }
            
        }
        public int cuentaXMLCapturados()
        { 
            //revisa si hay registros caprutados
            if (File.Exists(path + "DatosCargaOffline.xml"))
            {
                DataSet dsnc = new DataSet();
                dsnc.ReadXml(path + "DatosCargaOffline.xml");
                return Convert.ToInt32(dsnc.Tables[0].Rows.Count.ToString());
            }
            else
                return 0;
        }
        public DataSet MuestraProductosCapturados()
        {
            if (File.Exists(path + "DatosCargaOffline.xml"))
            {
                DataSet capturados = new DataSet();
                capturados.ReadXml(path + "DatosCargaOffline.xml");
                return capturados;
            }
            else
            {
                return null;
            }
        }
        public void CargaLote(String id_usuario, String nombre_ruta, String nombre_pv, String direccion_pv, String descripcion, String nombre_producto, String atributo, String valor)
        {
            servicio.CargaLote(id_usuario, nombre_ruta, nombre_pv, direccion_pv, descripcion, nombre_producto, atributo, valor);
        }
        public void UpdateXMLCarga(DataSet ds)
        {
            if (File.Exists(path + "DatosCargaOffline.xml"))
            {
                ds.WriteXml(path + "DatosCargaOffline.xml");
            }
        }
        public void BorraXMLCarga()
        {
            if (File.Exists(path + "DatosCargaOffline.xml"))
            { 
                File.Delete(path + "DatosCargaOffline.xml");
            }
        }
    }
}
