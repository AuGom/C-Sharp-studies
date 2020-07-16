using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Form1 : Form
    {
        string[] prod = new string[10]; 
        string[] code = new string[10]; 
        double[] value = new double[10]; 
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            total = 0;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == 3)
            {
                for (int i = 0; i < prod.Length; i++)
                {
                    if (txtCode.Text == code[i])
                    {
                        lstCaixa.Items.Add(txtCode.Text + " - " + prod[i] + " - R$" + value[i]);
                        total += value[i];
                        txtTotal.Text = "Total: " + total;
                        txtCode.Text = "";
                        txtCode.Focus();
                    }
                }


            }
            else if (txtCode.Text.Length > 3)
                MessageBox.Show("Código invalido");
        }

        private void carregarArray()
        {
            code[0] = "001";
            code[1] = "002";
            code[2] = "003";
            code[3] = "004";
            code[4] = "005"; 

            prod[0] = "Pastel";
            prod[1] = "Coxinha";
            prod[2] = "Hot_Dog";
            prod[3] = "Chocolate";
            prod[4] = "Suco"; 

            value[0] = 6.00;
            value[1] = 5.00;
            value[2] = 12.00;
            value[3] = 3.50;
            value[4] = 8.00;     
        }

    }
}
