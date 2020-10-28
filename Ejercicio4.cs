using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_Anahua_Arias_Coloma
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        Class_matriz obj_matrices = new Class_matriz(); //Declaramos la clase

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            obj_matrices.Ejercicio4(txtFila, txtColumna);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            obj_matrices.mostrar_matriz(dgvResultado);
            obj_matrices.mostrar_diagonalPrincipal(dgvResultado2);
            obj_matrices.mostrar_diagonalSecundaria(dgvResultado3);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {

        }
    }
}
