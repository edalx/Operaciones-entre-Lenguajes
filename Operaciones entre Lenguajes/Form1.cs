using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Operaciones_entre_Lenguajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            resultado.Enabled = true;
            String[] arreglo1 = lenguaje1.Text.Split(',');
            String[] arreglo2 = lenguaje2.Text.Split(',');
            IEnumerable<String> diferencia = arreglo1.AsQueryable().Except(arreglo2);
            foreach (String num in diferencia)
            {
                resultado.AppendText("   " + num);
            }
        }
        
        private void alfabeto_TextChanged(object sender, EventArgs e)
        {
            String texto=alfabeto.Text.Trim();
            String cadena = texto.Replace(",", "|");
           
            if (Regex.IsMatch(texto, @"^(\S,)*[^,]{1}$"))
                {
                    aprobado.ForeColor = System.Drawing.Color.Green;
                    aprobado.Text = "✓";
                    lenguaje1.Enabled = true;
                    lenguaje2.Enabled = true;
                    
                }
                else
                {
                    aprobado.ForeColor = System.Drawing.Color.Red;
                    aprobado.Text = "x";
                    lenguaje1.Enabled = false;
                    lenguaje2.Enabled = false;
                }
        }

        private void lenguaje1_TextChanged(object sender, EventArgs e)
        {
            String texto = alfabeto.Text.Trim();
            String cadena = texto.Replace(",", "|");
            String probLenguaje1 = lenguaje1.Text;
            Console.WriteLine(cadena);
            if (Regex.IsMatch(probLenguaje1, @"^((" + cadena + ")*,)*("+cadena+")+$"))
            {
                label5.ForeColor = System.Drawing.Color.Green;
                label5.Text = "✓";
                union.Enabled = true;
                interseccion.Enabled = true;
                diferencia.Enabled = true;
                
            }
            else
            {
                union.Enabled = false;
                interseccion.Enabled = false;
                diferencia.Enabled = false;
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "x";
            }
        }

        private void lenguaje2_TextChanged(object sender, EventArgs e)
        {
            String texto = alfabeto.Text.Trim();
            String cadena = texto.Replace(",", "|");
            String probLenguaje2 = lenguaje2.Text;
            Console.WriteLine(cadena);
            if (Regex.IsMatch(probLenguaje2, @"^((" + cadena + ")*,)*(" + cadena + ")+$"))
            {
                label6.ForeColor = System.Drawing.Color.Green;
                label6.Text = "✓";
                union.Enabled = true;
                interseccion.Enabled = true;
                diferencia.Enabled = true;

            }
            else
            {
                union.Enabled = false;
                interseccion.Enabled = false;
                diferencia.Enabled = false;
                label6.ForeColor = System.Drawing.Color.Red;
                label6.Text = "x";
            }
        }

        private void union_Click(object sender, EventArgs e)
        {
            resultado.Enabled = true;
            String[] arreglo1 = lenguaje1.Text.Split(',');
            String[] arreglo2= lenguaje2.Text.Split(',');
            IEnumerable<String> opunion = arreglo1.AsQueryable().Union(arreglo2);
            foreach (String num in opunion)
            {
              resultado.AppendText("   " + num);
            }
        }

        private void interseccion_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            resultado.Enabled = true;
            String[] arreglo1 = lenguaje1.Text.Split(',');
            String[] arreglo2 = lenguaje2.Text.Split(',');
            IEnumerable<String> opintersect = arreglo1.AsQueryable().Intersect(arreglo2);
            foreach (String num in opintersect)
            {
                resultado.AppendText("   " + num);
            }
        }
    }
}
