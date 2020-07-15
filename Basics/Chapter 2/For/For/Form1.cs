using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//carrega esta funçao junto do carregamento do form
        {
            int count; 
            for (count = 2020; count >= 1950; count--) 
            { 
                cmbAno.Items.Add(count); 
            }
        }
    }
}
