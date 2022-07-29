using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioCalculoFrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            


        void CalcularFrete()
        {
            decimal frete = 0M;
            string Valor = txtValor.Text;
            if (Valor == "") 
            {
                MessageBox.Show("Adicione um valor para calcular",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                               
                return; 
            }

            if (decimal.Parse(Valor)>=1000)
            {
                frete = 0M;
            }
            else if (cbxUf.Text == "SP")
            {
                frete = 5.00M;
            }
            else if (cbxUf.Text == "RJ")
            {
                frete = 10.00M;
            }
            else if (cbxUf.Text == "AM")
            {
                frete = 20.00M;
            }
            else
            {
                frete = 15.00M;
            }
            lblFrete.Text = frete.ToString("F2",CultureInfo.InvariantCulture);

            lblValordaCompra.Text = decimal.Parse(txtValor.Text).ToString("F2", CultureInfo.InvariantCulture);

            lblTotal.Text = (decimal.Parse(Valor)+frete).ToString("F2", CultureInfo.InvariantCulture);


        }

        void LimparCampos()
        {
            lblTotal.Text = "________";
            lblFrete.Text = "________";
            lblValordaCompra.Text = "________";

            txtNome.Text = "";
            txtValor.Text = "";
            cbxUf.Text = String.Empty;



        }
        
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValor.Select();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxUf.Select();
            }
        }

        private void cbxUf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Select();
            }
        }
    }
}
