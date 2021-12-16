using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJPesoIdeal
{  /// <summary>
/// Uma aplicação que calcula o peso ideal a partir das informações que são fornecidas pelos usuarios
/// fins didadicos by: Lincoln Lima
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();



        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try  // TENTE       
            {
                Double Altura = 0, PesoIdeal = 0;
                Altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + " Seu peso ideal é: " + PesoIdeal.ToString() + "KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + " Seu peso ideal é: " + PesoIdeal.ToString() + "KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Escolha o Sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                // Caso o usuario não preencha os campos corretamente essa função irá retornar uma mensagem informando o usuario a preencher todas informações corretamente

                MessageBox.Show(" Verifique os valores informados", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
