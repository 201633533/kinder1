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
        asigdoc cmda = new asigdoc();
        public ASIGNACION_DOCENTE()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ASIGNACION_DOCENTE_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridViewasigdocente);
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
        class asigdoc
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
        }
    }
}
