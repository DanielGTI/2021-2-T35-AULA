using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Instalando o software.");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Instalando... otário");
        }
    }
}
