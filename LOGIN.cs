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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyecto;Uid=root;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where matricula ='" + textBoxusuario.Text + "' and pass= '" + textBoxcontraseña.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido administrador");
                INICIO_SESION_ADMINISTRADOR llamar = new INICIO_SESION_ADMINISTRADOR();
                llamar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

            conectar.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyecto;Uid=root;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where matricula ='" + textBoxusuario.Text + "' and pass= '" + textBoxcontraseña.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido tutor");
                INICIO_SESION_TUTOR llamar = new INICIO_SESION_TUTOR();
                llamar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

            conectar.Close();

        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyecto;Uid=root;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where matricula ='" + textBoxusuario.Text + "' and pass= '" + textBoxcontraseña.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido docente");
                INICIO_SESION_DOCENTES llamar = new INICIO_SESION_DOCENTES();
                llamar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

            conectar.Close();

        }
    }
    }

    
    

