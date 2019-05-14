using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class manttoVendor
    {
        bdConex test = new bdConex();

        public String prueba() 
        {
            String mensaje;

            if(test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;
        }

        String codigoVendor, nombreVendor;

        public String NombreVendor
        {
            get { return nombreVendor; }
            set { nombreVendor = value; }
        }

        public String CodigoVendor
        {
            get { return codigoVendor; }
            set { codigoVendor = value; }
        }

        public void insertarVendor() 
        {
            try 
            {
                String insert = "insert into VENDEDOR values('" + codigoVendor +"','" + nombreVendor + "');";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch 
            {
            }
        }

        public void updateVendor() 
        {
            try 
            {
                String update = "update VENDEDOR set NOMBRE='" + nombreVendor + "' where VENDEDOR='" + codigoVendor + "'";

                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch 
            {
            }
        }

        //////////////

        public void consultar() 
        {
            try { 
            String select = "select '" + codigoVendor + "' '" + nombreVendor + "' from VENDEDOR where VENDEDOR = '" + codigoVendor +"'";
            test.Conectar();
            test.consultaSQL(select);
            test.Desconectar();
            }
            catch (Exception e) 
            {
            }
        }

        ////////////////
    }
}
