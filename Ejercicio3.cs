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
    public partial class Ejercicio3 : Form
    {
        int respuesta1,respuesta2,respuesta3,respuesta4;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt11.Text = "";
            txt111.Text = "";
            txt1111.Text = "";
            txt11111.Text = "";
            txt13.Text = "";
            txt14.Text = "";
            txt2.Text = "";
            txt22.Text = "";
            txt222.Text = "";
            txt2222.Text = "";
            txt3.Text = "";
            txt32.Text = "";
            txt33.Text = "";
            txt333.Text = "";
            txt3333.Text = "";
            txt33333.Text = "";
            txt333333.Text = "";
            txt4.Text = "";
            txt44.Text = "";
            txt5.Text = "";
            txtResultado.Text = "";
        }

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if ((txt1.Text == "c" || txt1.Text=="C") && (txt11.Text == "a" || txt11.Text=="A") && (txt111.Text == "b" || txt111.Text=="B") && (txt13.Text == "a" || txt13.Text=="A")
                && (txt1111.Text == "l" || txt1111.Text=="L") && (txt11111.Text == "l" || txt11111.Text=="L") && (txt14.Text == "o" || txt14.Text=="O"))
            {
                respuesta1 = 50;
            }
            else
            {
                respuesta1 = 0;
            }
            if((txt2.Text == "c" || txt2.Text == "C") && (txt32.Text=="a" || txt32.Text=="A") && (txt22.Text=="b" || txt22.Text=="B") && (txt222.Text=="r" || txt222.Text=="R") && (txt2222.Text=="a" || txt2222.Text=="A"))
            {
                respuesta2 = 50;
            }
            else
            {
                respuesta2 = 0;
            }
            if((txt3.Text == "m" || txt3.Text == "M") && (txt13.Text == "a" || txt13.Text == "A") && (txt33.Text == "r" || txt33.Text == "R") && (txt333.Text == "i" || txt333.Text == "I") && (txt3333.Text == "p" || txt3333.Text == "P")
                && (txt33333.Text == "o" || txt33333.Text == "O") && (txt333333.Text == "s" || txt333333.Text == "S") && (txt32.Text == "a" || txt32.Text == "A"))
            {
                respuesta3 = 50;
            }
            else
            {
                respuesta3 = 0;
            }
            if((txt4.Text == "l" || txt4.Text == "L") && (txt14.Text == "o" || txt14.Text == "O") && (txt44.Text == "b" || txt44.Text == "B") && (txt5.Text == "o" || txt5.Text == "O"))
            {
                respuesta4 = 50;
            }
            else
            {
                respuesta4 = 0;
            }
            txtResultado.Text = "Su puntaje total es : "+Convert.ToString(respuesta1 + respuesta2 + respuesta3 + respuesta4);
        }
    }
}
