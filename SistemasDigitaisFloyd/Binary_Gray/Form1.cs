using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Gray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinary2Gray_Click(object sender, EventArgs e)
        {
            string entrada = txtBinary2GrayIn.Text;
            string binario2gray = "";
            for (int i = 0; i < entrada.Length - 1; i++)
            {
                if (entrada[i] == '0' && entrada[i + 1] == '0' || entrada[i] == '1' && entrada[i + 1] == '1')
                    binario2gray += "0";
                else if (entrada[i] == '0' && entrada[i + 1] == '1' || entrada[i] == '1' && entrada[i + 1] == '0')
                    binario2gray += "1";
            }

            txtBinary2GrayOut.Text = entrada[0] + binario2gray;
        }

        private void btnGray2Binary_Click(object sender, EventArgs e)
        {
            string entrada = txtGray2BinaryIn.Text;
            char primeiroDigito = entrada[0];
            string gray2Binary = "";

            if (primeiroDigito == '0' && entrada[1] == '0' || primeiroDigito == '1' && entrada[1] == '1')
                gray2Binary += "0";
            else if (primeiroDigito == '0' && entrada[1] == '1' || primeiroDigito == '1' && entrada[1] == '0')
                gray2Binary += "1";

            for (int i = 0; i < entrada.Length - 2; i++)
            {
                if (gray2Binary[i] == '0' && entrada[i + 2] == '0' || gray2Binary[i] == '1' && entrada[i + 2] == '1')
                    gray2Binary += "0";
                else if (gray2Binary[i] == '0' && entrada[i + 2] == '1' || gray2Binary[i] == '1' && entrada[i + 2] == '0')
                    gray2Binary += "1";
            }

            txtGray2BinaryOut.Text = entrada[0] + gray2Binary;
        }
    }
}
