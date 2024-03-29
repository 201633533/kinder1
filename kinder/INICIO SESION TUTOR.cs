﻿using MySql.Data.MySqlClient;
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
    public partial class INICIO_SESION_TUTOR : Form
    {
        TUTOR cmda = new TUTOR();

        public INICIO_SESION_TUTOR()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void INICIO_SESION_TUTOR_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridViewtutor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DEL FORMULARIO
            LOGIN obj = new LOGIN();
            //LLAMAMOS EL OBJETO Y LO PONEMOS VISIBLE
            obj.Visible = true;
            //OCULTAMOS 
            Visible = false;
        }
        class TUTOR
        {
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; database=proyecto;Uid=root");

            public void llenargrid(DataGridView grid)
            {
                MySqlCommand cn = new MySqlCommand("select * from proyecto.iniciotutor;", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
            }
        }
    }
}
