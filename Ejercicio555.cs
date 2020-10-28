using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Grupo_Anahua_Arias_Coloma
{
    public partial class Ejercicio555 : Form
    {
        public Ejercicio555()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString();

            txtTotal.Text = Convert.ToString(Ejercicio5.array.Sum());

            dgvResultado.DataSource = null;
            dgvResultado.DataSource = Ejercicio5.ACliente;
            
        }

        private void Ejercicio555_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
