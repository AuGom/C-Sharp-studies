using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDia.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Sabado":
                    MessageBox.Show("Você escolheu Sabado.", "Mensagem", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
