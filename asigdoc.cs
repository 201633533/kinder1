using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinder
{
    public class asigdoc
    {
        MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database=proyecto;Uid=root");

        public void llenargrid(DataGridView grid)
        {
            MySqlCommand cn = new MySqlCommand("select * from proyecto.asigGradoyGrupo;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }
        
        public static List<Cliente> Buscar(int pmatricula)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT matricula, grado, grupo FROM asigGradoyGrupo where matricula ='{0}'", pmatricula), BdComun.ObtnerCOnexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.matricula = _reader.GetInt32(0);
                pCliente.grado = _reader.GetString(1);
                pCliente.grupo = _reader.GetString(2); 
               

                _lista.Add(pCliente);
            }

            return _lista;
        }
        public static Cliente ObtenerCliente(int pmatricula)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BdComun.ObtnerCOnexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT matricula, grado, grupo FROM asigGradoyGrupo where matricula ='{0}'", pmatricula), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.matricula = _reader.GetInt32(0);
                pCliente.grado = _reader.GetString(1);
                pCliente.grupo = _reader.GetString(2);
                

            }

            conexion.Close();
            return pCliente;

        }
    }
}
