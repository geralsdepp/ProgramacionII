using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class Form1 : Form
    {
        Oficina oficina;
        public Form1()
        {
            InitializeComponent();
            cmbDepartamentoOficina.DataSource = Enum.GetValues(typeof(Departamentos));
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamentos));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrearOficina_Click(object sender, EventArgs e)
        {
            Departamentos dptos;
            Enum.TryParse<Departamentos>(cmbDepartamentoOficina.SelectedValue.ToString(), out dptos);

            if (nudPisoOficina.Value != 0)
            {
                oficina = new Oficina((short)nudPisoOficina.Value, dptos, new Jefe(txtNombreJefe.Text, txtApellidoEmpleado.Text, txtDNIJefe.Text, dtpIngreso.Value));

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Departamentos dptos;
            Enum.TryParse<Departamentos>(cmbDepartamentoOficina.SelectedValue.ToString(), out dptos);
            Empleado e1 = new Empleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, txtLegajoEmpleado.Text, (short)nudPiso.Value, dptos);
            oficina += e1;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (string)oficina; 
        }


    }
}
