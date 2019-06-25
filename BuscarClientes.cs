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
    public partial class BuscarClientes : Form
    {
        DOC cmda = new DOC();

        public BuscarClientes()
        {
            InitializeComponent();
        }
        public agregardocen ClienteSeleccionado { get; set; }

        private void button1buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = asigdoc.Buscar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                String DOCENTE = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = asigdoc.ObtenerCliente(DOCENTE);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridView1);
        }
    }
    class DOC
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
