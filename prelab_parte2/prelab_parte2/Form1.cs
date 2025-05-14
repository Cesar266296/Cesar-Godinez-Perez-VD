using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelab_parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                // Agregar las 20 opciones de conversión
                comboBox1.Items.Add("Litros a Galones (US)");
                comboBox1.Items.Add("Galones (US) a Litros");
                comboBox1.Items.Add("Litros a Galones (UK)");
                comboBox1.Items.Add("Galones (UK) a Litros");
                comboBox1.Items.Add("Mililitros a Litros");
                comboBox1.Items.Add("Litros a Mililitros");
                comboBox1.Items.Add("Pies Cúbicos a Litros");
                comboBox1.Items.Add("Litros a Pies Cúbicos");
                comboBox1.Items.Add("Centímetros Cúbicos a Litros");
                comboBox1.Items.Add("Litros a Centímetros Cúbicos");
                comboBox1.Items.Add("Metros Cúbicos a Litros");
                comboBox1.Items.Add("Litros a Metros Cúbicos");
                comboBox1.Items.Add("Galones (US) a Pies Cúbicos");
                comboBox1.Items.Add("Pies Cúbicos a Galones (US)");
                comboBox1.Items.Add("Galones (US) a Mililitros");
                comboBox1.Items.Add("Mililitros a Galones (US)");
                comboBox1.Items.Add("Galones (UK) a Pies Cúbicos");
                comboBox1.Items.Add("Pies Cúbicos a Galones (UK)");
                comboBox1.Items.Add("Galones (UK) a Mililitros");
                comboBox1.Items.Add("Mililitros a Galones (UK)");
            }
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el valor ingresado
                double valor = double.Parse(textBox1.Text);

                // Obtener la selección del ComboBox
                string seleccion = comboBox1.SelectedItem.ToString();

                // Variable para el resultado
                double resultado = 0;

                // Lógica de las conversiones
                switch (seleccion)
                {
                    case "Litros a Galones (US)":
                        resultado = valor * 0.264172;
                        break;
                    case "Galones (US) a Litros":
                        resultado = valor * 3.78541;
                        break;
                    case "Litros a Galones (UK)":
                        resultado = valor * 0.219969;
                        break;
                    case "Galones (UK) a Litros":
                        resultado = valor * 4.54609;
                        break;
                    case "Mililitros a Litros":
                        resultado = valor / 1000;
                        break;
                    case "Litros a Mililitros":
                        resultado = valor * 1000;
                        break;
                    case "Pies Cúbicos a Litros":
                        resultado = valor * 28.3168;
                        break;
                    case "Litros a Pies Cúbicos":
                        resultado = valor / 28.3168;
                        break;
                    case "Centímetros Cúbicos a Litros":
                        resultado = valor / 1000;
                        break;
                    case "Litros a Centímetros Cúbicos":
                        resultado = valor * 1000;
                        break;
                    case "Metros Cúbicos a Litros":
                        resultado = valor * 1000;
                        break;
                    case "Litros a Metros Cúbicos":
                        resultado = valor / 1000;
                        break;
                    case "Galones (US) a Pies Cúbicos":
                        resultado = valor * 0.133681;
                        break;
                    case "Pies Cúbicos a Galones (US)":
                        resultado = valor * 7.48052;
                        break;
                    case "Galones (US) a Mililitros":
                        resultado = valor * 3785.41;
                        break;
                    case "Mililitros a Galones (US)":
                        resultado = valor / 3785.41;
                        break;
                    case "Galones (UK) a Pies Cúbicos":
                        resultado = valor * 1.20095;
                        break;
                    case "Pies Cúbicos a Galones (UK)":
                        resultado = valor * 0.832674;
                        break;
                    case "Galones (UK) a Mililitros":
                        resultado = valor * 4546.09;
                        break;
                    case "Mililitros a Galones (UK)":
                        resultado = valor / 4546.09;
                        break;
                    default:
                        MessageBox.Show("Por favor seleccione una conversión válida.");
                        return;
                }

                // Mostrar el resultado en el Label
                label1.Text = "Resultado: " + resultado.ToString("0.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}