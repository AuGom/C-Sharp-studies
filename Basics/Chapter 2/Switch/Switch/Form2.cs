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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            switch (cmbDigito.Text)
            {
                case "1":
                case "2":
                    lblRes.Text = "O Dia de seu rodízio é Segunda-Feira!"; 
                    break;
                case "3":
                case "4":
                    lblRes.Text = "O Dia de seu rodízio é Treça-Feira!";
                    break;
                case "5":
                case "6":
                    lblRes.Text = "O Dia de seu rodízio é Quarta-Feira!";
                    break;
                case "7":
                case "8":
                    lblRes.Text = "O Dia de seu rodízio é Quinta-Feira!";
                    break;
                case "9":
                case "0":
                    lblRes.Text = "O Dia de seu rodízio é Sexta-Feira!";
                    break;
            }
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();  
            novo.Show();             
            this.Visible = false;
        }
    }
}
