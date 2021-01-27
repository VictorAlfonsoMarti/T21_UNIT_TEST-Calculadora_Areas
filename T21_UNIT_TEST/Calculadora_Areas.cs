using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T21_UNIT_TEST
{
    public partial class Calculadora_Areas : Form
    {
        public Calculadora_Areas()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            // MÉTODO usado por todos los botones para llamar al respectivo método para calcular
            // según el método mostramos unos labels u otros para pedir los datos
            
            Button boton = (Button)sender;

            panel2.Hide(); // ocultamos el panel de resultado por si ya se había mostrado antes
            // reiniciamos los textbox de inserción de números
            numero1.Text = "";
            numero2.Text = "";
            numero3.Text = "";

            // recogemos el nombre del boton para printar unos textos u otros
            // también cambiamos los nombres de los costados por cada polígono
            switch (boton.Name)
            {
                case "boton_cuadrado":
                    texto1.Text = "Lado:";
                    texto1.Show();
                    texto2.Hide();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Hide();
                    numero3.Hide();
                    break;
                case "boton_circulo":
                    texto1.Text = "Radio:";
                    texto1.Show();
                    texto2.Hide();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Hide();
                    numero3.Hide();
                    break;
                case "boton_triangulo":
                    texto1.Text = "Base:";
                    texto2.Text = "Altura:";
                    texto1.Show();
                    texto2.Show();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Show();
                    numero3.Hide();
                    break;
                case "boton_rectangulo":
                    texto1.Text = "Base:";
                    texto2.Text = "Altura:";
                    texto1.Show();
                    texto2.Show();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Show();
                    numero3.Hide();
                    break;
                case "boton_pentagono":
                    texto1.Text = "Apotema:";
                    texto2.Text = "Lado:";
                    texto1.Show();
                    texto2.Show();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Show();
                    numero3.Hide();
                    break;
                case "boton_rombo":
                    texto1.Text = "Diagonal Mayor:";
                    texto2.Text = "Diagonal Menor:";
                    texto2.Show();
                    texto2.Show();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Show();
                    numero3.Hide();
                    // reajustamos el tamaño de los textbox
                    numero1.Size = new System.Drawing.Size(125,55);
                    numero1.Location = new Point(210,18); 
                    numero2.Size = new System.Drawing.Size(125, 55);
                    numero2.Location = new Point(210, 68);
                    break;
                case "boton_romboide":
                    texto1.Text = "Base:";
                    texto2.Text = "Altura:";
                    texto2.Show();
                    texto2.Show();
                    texto3.Hide();
                    numero1.Show();
                    numero2.Show();
                    numero3.Hide();
                    break;
                case "boton_trapecio":
                    texto1.Text = "Base Menor:";
                    texto2.Text = "Base Mayor:";
                    texto3.Text = "Altura:";
                    // reajustamos el tamaño de los textbox
                    numero1.Size = new System.Drawing.Size(155, 55);
                    numero2.Size = new System.Drawing.Size(155, 55);
                    numero1.Location = new Point(190, 18);
                    numero2.Location = new Point(190, 68);
                    texto2.Show();
                    texto2.Show();
                    texto3.Show();
                    numero1.Show();
                    numero2.Show();
                    numero3.Show();
                    break;
                default:
                    break;
            }

            // añadimos el evento onclick para poder enviar a ejecutar las comprobaciones
            calcular.Click += (sender2, EventArgs) => { calcular_Click(sender2, EventArgs, boton.Name, numero1.Text, numero2.Text, numero3.Text); };
                        
            panel_datos.Show(); // mostramos el panel para que el usuario ponga los datos
        }

        private void calcular_Click(object sender, EventArgs e, string nom, string numero1, string numero2, string numero3)
        {
            // botó de calcular, cridem les diverses funcions per calcular

            // inicializamos variables vacias para enviarlas por parámetros en los métodos
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            // si nos han entrado algún contenido en las cajas de texto, si no contenido = 0
            // intentamos convertir el string en int, si no, da error
            if (numero1 != "")
            {
                try
                {
                    num1 = Convert.ToInt32(numero1);
                }
                catch
                {
                    MessageBox.Show("Error: Entrada de " + texto1.Text + " no reconeguda.");
                }
            }
            if (numero2 != "")
            {
                try
                {
                    num2 = Convert.ToInt32(numero2);
                }
                catch
                {
                    MessageBox.Show("Error: Entrada de " + texto2.Text + " no reconeguda.");
                }
            }
            if (numero3 != "")
            {
                try
                {
                    num3 = Convert.ToInt32(numero3);
                }
                catch
                {
                    MessageBox.Show("Error: Entrada de " + texto3.Text + " no reconeguda.");
                }
            }


            // llamamos al objeto geometria que contiene los métodos de cálculo
            Geometria g = new Geometria();

            switch (nom) // según el botón que hemos llamado al principio
            {
                case "boton_cuadrado":
                    // asignamos el valor del método a la caja de texto resultado
                    resultado.Text = Convert.ToString(g.areacuadrado(num1)); 
                    break;
                case "boton_circulo":
                    resultado.Text = Convert.ToString(g.areaCirculo(num1));
                    break;
                case "boton_triangulo":
                    resultado.Text = Convert.ToString(g.areatriangulo(num1, num2));
                    break;
                case "boton_rectangulo":
                    resultado.Text = Convert.ToString(g.arearectangulo(num1, num2));
                    break;
                case "boton_pentagono":
                    resultado.Text = Convert.ToString(g.areapentagono(num1, num2));
                    break;
                case "boton_rombo":
                    resultado.Text = Convert.ToString(g.arearombo(num1, num2));
                    break;
                case "boton_romboide":
                    resultado.Text = Convert.ToString(g.arearomboide(num1, num2));
                    break;
                case "boton_trapecio":
                    resultado.Text = Convert.ToString(g.areatrapecio(num1, num2, num3));
                    break;
                default:
                    break;
            }
            panel2.Show(); // mostramos el panel del resultado
        }
    }
}
