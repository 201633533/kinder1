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
    public partial class ASIGNACIONALUMNOS : Form
    {
        asigalumno cmda = new asigalumno();

        public ASIGNACIONALUMNOS()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void ASIGNACIONALUMNOS_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dgvalumno);
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


        private void button1_Click(object sender, EventArgs e)
        {
            Clientealumno pClientealumno = new Clientealumno();
            pClientealumno.alumno = txtalumno.Text.Trim();
            pClientealumno.grado = comboBoxalumno.Text.Trim();
            pClientealumno.grupo = comboBoxgrupo.Text.Trim();


            int resultado = ClientesD.Agregar(pClientealumno);
            if (resultado > 0)
            {
                MessageBox.Show("Alumno asignado con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Alumno", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDocentes buscar = new BuscarDocentes();
            buscar.ShowDialog();

            if (buscar.ClienteSelecionado != null)
            {

                comboBoxalumno.Text = buscar.ClienteSelecionado.grado;
                comboBoxgrupo.Text = buscar.ClienteSelecionado.grupo;
            }

        }



    }
    public class Clientealumno
    {

        public string alumno { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }

        public Clientealumno() { }

        public Clientealumno(string palumno, string pgrado, string pgrupo)

        {

            this.alumno = palumno;
            this.grado = pgrado;
            this.grupo = pgrupo;

        }
    }
    class ClientesD
    {
        public static int Agregar(Clientealumno pClientealumno)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into asigGyg (alumno, grado, grupo) values ('{0}','{1}','{2}')",
                pClientealumno.alumno, pClientealumno.grado, pClientealumno.grupo), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Clientealumno> Buscar(string pnombre)
        {
            List<Clientealumno> _lista = new List<Clientealumno>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT nombre, grado, grupo FROM asigGyg  where nombre ='{0}' ", pnombre), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientealumno pClientealumno = new Clientealumno();
                pClientealumno.alumno = _reader.GetString(0);
                pClientealumno.grado = _reader.GetString(1);
                pClientealumno.grupo = _reader.GetString(2);



                _lista.Add(pClientealumno);
            }

            return _lista;
        }
        public static Clientealumno Obteneralumno(String palumno)
        {
            Clientealumno pClientealumno = new Clientealumno();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT docente, grado, grupo FROM asigGyg  where alumno ='{0}' ", palumno), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pClientealumno.alumno = _reader.GetString(0);
                pClientealumno.grado = _reader.GetString(1);
                pClientealumno.grupo = _reader.GetString(2);

            }

            conexion.Close();
            return pClientealumno;

        }


    }
    class asigalumno
    {
        MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database=proyecto;Uid=root;");

        public void llenargrid(DataGridView grid)
        {
            MySqlCommand cn = new MySqlCommand("select * from proyecto.asigGyg;", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;

        }
    }

}

