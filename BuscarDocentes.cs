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
    public partial class BuscarDocentes : Form
    {
       

        public BuscarDocentes()
        {
            InitializeComponent();

        }

        
        public Cliente ClienteSelecionado { set; get; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = ClientesDAL.Buscar(txtMatricula.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                String Docente = Convert.ToString(dgvBuscar.CurrentRow.Cells[0].Value);
                ClienteSelecionado = ClientesDAL.ObtenerCliente(Docente);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }
    }

    }


