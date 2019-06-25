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
    public partial class GRUPO : Form
    {
        public GRUPO()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void GRUPO_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DEL FORMULARIO
            INICIO_SESION_DOCENTES obj = new INICIO_SESION_DOCENTES();
            //LLAMAMOS EL OBJETO Y LO PONEMOS VISIBLE
            obj.Visible = true;
            //OCULTAMOS 
            Visible = false;
        }
    }
}
