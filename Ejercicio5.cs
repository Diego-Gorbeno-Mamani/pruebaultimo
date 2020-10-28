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
    public partial class Ejercicio5 : Form
    {
        int i = 0;          //declarar
        public static int[] array = new int[50];
        public static ArrayList ACliente = new ArrayList();
        public Ejercicio5()
        {
            InitializeComponent();
        }
        
        
        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
                      
            Ejercicio555 frm = new Ejercicio555();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            RUC.Enabled = false;
            Class_Agregar objAg = new Class_Agregar(); //instanciar
            Class_Factura objFa = new Class_Factura();
            objAg.Nombre = txtNombre.Text;
            objAg.Direccion = txtDireccion.Text;
            objAg.Ruc = RUC.Text;
            objAg.Telefono = txtTelefono.Text;
            if (cbRefrigerador.Checked)
            {
                if(cbProm.Checked)
                {
                    objAg.Electrodomestico = "Refrigerador";
                    objAg.Precio = 700;
                    array[i] = 700;
                }
                else
                {
                    objAg.Electrodomestico = "Refrigerador";
                    objAg.Precio = 800;
                    array[i] = 800;
                }    
                
                
            }
            if (cbPlancha.Checked)
            {
                if (cbProm.Checked)
                {
                    objAg.Electrodomestico = "Plancha oster";
                    objAg.Precio = 100;
                    array[i] = 100;
                }
                else
                {
                    objAg.Electrodomestico = "Plancha oster";
                    objAg.Precio = 120;
                    array[i] = 120;
                }
                

            }
            if (cbTelevisor.Checked)
            {
                if (cbProm.Checked)
                {
                    objAg.Electrodomestico = "HD 32 LG SMART TV";
                    objAg.Precio = 600;
                    array[i] = 600;
                }
                else
                {
                    objAg.Electrodomestico = "HD 32 LG SMART TV";
                    objAg.Precio = 700;
                    array[i] = 700;
                }
                

            }
            if (cbRadio.Checked)
            {
                if (cbProm.Checked)
                {
                    objAg.Electrodomestico = "RADIO CD CON BLUETOOTH";
                    objAg.Precio = 100;
                    array[i] = 100;
                }
                else
                {
                    objAg.Electrodomestico = "RADIO CD CON BLUETOOTH";
                    objAg.Precio = 150;
                    array[i] = 150;
                }
                

            }
            
            objFa.MtdAgregarUsuario(objAg);
            i += 1;
        }
    }
}
