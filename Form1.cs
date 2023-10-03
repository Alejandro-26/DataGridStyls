using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWridPersonalizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(dgvListar);

            row.Cells[0].Value = txtNombre.Text;
            row.Cells[1].Value = txtTelefono.Text;
            row.Cells[2].Value = txtDireccion.Text;


            dgvListar.Rows.Add(row);

            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }
    }
}
