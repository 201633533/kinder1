using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinder
{

    public partial class ASIGNAR_CALIFICACION : Form
    {
        asig cmda = new asig();

        public ASIGNAR_CALIFICACION()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ASIGNAR_CALIFICACION_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridViewCALI);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DEL FORMULARIO
            INICIO_SESION_DOCENTES obj = new INICIO_SESION_DOCENTES();
            //LLAMAMOS EL OBJETO Y LO PONEMOS VISIBLE
            obj.Visible = true;
            //OCULTAMOS 
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyecto;Uid=root");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where matricula = '" + textBoxmatricula.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read() == true)
            {
                textBoxalumno.Text = leer["nombrecompleto"].ToString();


            }

            else
            {
                textBoxalumno.Text = "";


            }

            conectar.Close();

        }

       

        private void dataGridViewCALI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        class asig
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database=proyecto;Uid=root");

            public void llenargrid(DataGridView grid)
            {
                MySqlCommand cn = new MySqlCommand("select * from proyecto.asigCalificacion;", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
            }
        }
    }
}

   


