using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Grupo_Anahua_Arias_Coloma
{
    class Class_matriz
    {
        int[,] matriz = new int[100, 100];
        int fila, columna, i, j;
        public void Ejercicio4(TextBox p1, TextBox p2)
        {
            Random rnd = new Random();
            fila = int.Parse(p1.Text);
            columna = int.Parse(p2.Text);
            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matriz[i, j] = rnd.Next(0, 9);
                }
            }

        }
        public void mostrar_matriz(DataGridView tabla)
        {
            tabla.Rows.Clear(); //limpiar datagrid
            tabla.ColumnCount = columna;
            tabla.RowCount = fila;
            if(columna==fila)  //condicinal si es una matriz cuadrada o no
            {
                for (i = 0; i <= fila - 1; i++)
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();

                        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                    }

                }
                for (i = 0; i <= fila - 1; i++) //color de la diagonal principal
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        if (i == j)
                        {
                            tabla.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            tabla.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        }
                    }
                }
                for (i = 0; i <= fila - 1; i++) //color de la diagonal secundaria
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        if (j + i == columna - 1)
                        {
                            tabla.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No es una matriz cuadrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (i = 0; i <= fila - 1; i++)
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();

                        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                    }

                }
            }
            
        }
        public void mostrar_diagonalPrincipal(DataGridView tabla)
        {
            tabla.Rows.Clear(); //limpiar datagrid
            tabla.ColumnCount = columna;
            tabla.RowCount = fila;
            if(columna==fila)  //condicional matriz cuadrada
            {
                
                for (i = 0; i <= fila - 1; i++)
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        if (i == j)
                        {
                            tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                            tabla.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            tabla.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        }
                        else
                        {
                            tabla.Rows[i].Cells[j].Value = "-";
                            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                        }
                    }

                }
            }           
            
        }
        public void mostrar_diagonalSecundaria(DataGridView tabla)
        {
            tabla.Rows.Clear(); //limpiar datagrid
            tabla.ColumnCount = columna;
            tabla.RowCount = fila;
            if(columna==fila)   //matriz cuadrada
            {
                
                for (i = 0; i <= fila - 1; i++)
                {
                    for (j = 0; j <= columna - 1; j++)
                    {
                        if (j + i == columna - 1)
                        {
                            tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                            tabla.Rows[i].Cells[j].Style.BackColor = Color.Aqua;
                        }
                        else
                        {
                            tabla.Rows[i].Cells[j].Value = "-";
                            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //Ajustar tamaño de celdas al numero ingresado
                        }
                    }
                }
            }
            

        }
    }
}
