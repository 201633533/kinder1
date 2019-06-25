using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinder
{
    public partial class ASIGNACION_DOCENTE : Form
    {
        asig cmda = new asig();
        public ASIGNACION_DOCENTE()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
       
      

        private void ASIGNACION_DOCENTE_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dgv1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DEL FORMULARIO
            INICIO_SESION_ADMINISTRADOR obj = new INICIO_SESION_ADMINISTRADOR();
            //LLAMAMOS EL OBJETO Y LO PONEMOS VISIBLE
            obj.Visible = true;
            //OCULTAMOS 
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.Docente = txtdocente.Text.Trim();
            pCliente.grado = comboBox2.Text.Trim();
            pCliente.grupo = comboBox3.Text.Trim();


            int resultado = ClientesDAL.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Docente asignado con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Docente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDocentes buscar = new BuscarDocentes();
            buscar.ShowDialog();

            if (buscar.ClienteSelecionado !=null)
            {
               
                comboBox2.Text = buscar.ClienteSelecionado.grado;
                comboBox3.Text = buscar.ClienteSelecionado.grupo;
            }
        }
    }
    public class Cliente
    {

        public string Docente { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }

        public Cliente() { }

        public Cliente(string pDocente, string pgrado, string pgrupo)

        {

            this.Docente = pDocente;
            this.grado = pgrado;
            this.grupo = pgrupo;

        }
    }
    class ClientesDAL
    {
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into asigGradoyGrupo (docente, grado, grupo) values ('{0}','{1}','{2}')",
                pCliente.Docente, pCliente.grado, pCliente.grupo), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Cliente> Buscar(string pdocente)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT docente, grado, grupo FROM asigGradoyGrupo  where docente ='{0}' ", pdocente), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Docente = _reader.GetString(0);
                pCliente.grado = _reader.GetString(1);
                pCliente.grupo = _reader.GetString(2);



                _lista.Add(pCliente);
            }

            return _lista;
        }
        public static Cliente ObtenerCliente(String pDocente)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT docente, grado, grupo FROM asigGradoyGrupo  where docente ='{0}' ", pDocente), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pCliente.Docente = _reader.GetString(0);
                pCliente.grado = _reader.GetString(1);
                pCliente.grupo = _reader.GetString(2);

            }

            conexion.Close();
            return pCliente;

        }


    }
    class asig
    {
        MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database=proyecto;Uid=root;");

        public void llenargrid(DataGridView grid)
        {
            MySqlCommand cn = new MySqlCommand("select * from proyecto.Usuarios;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

        }
    }
}

