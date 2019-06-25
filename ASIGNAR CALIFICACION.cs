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
    public partial class ASIGNAR_CALIFICACION : Form
    {
      

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
            codigo.CommandText = ("select * from Usuarios where Matricula = '" + txtmatricula.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read() == true)
            {
                textBox2.Text = leer["nombrecompleto"].ToString();

               
            }

            else
            {
                textBox2.Text = "";

               
            }

            conectar.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    }
    }
   
}

    

