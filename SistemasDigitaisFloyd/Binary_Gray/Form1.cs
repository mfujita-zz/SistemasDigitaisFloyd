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
            txtBinary2GrayOut.Text = entrada[0] + ConvertBinary2Gray(entrada);
        }

        private void btnGray2Binary_Click(object sender, EventArgs e)
        {
            string entrada = txtGray2BinaryIn.Text;
            txtGray2BinaryOut.Text = entrada[0] + ConvertGray2Binary(entrada);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChoose.Items.Add("Binário → Gray");
            cbChoose.Items.Add("Gray → Binário");
            btnConvert.Size = new Size(180, 30);
            //Centralizar o botão de conversão entre as caixas de entrada e saída da aba "Conversão em lote"
            btnConvert.Location = new Point((txtLoteOut.Left - txtLoteIn.Right - btnConvert.Width) / 2 + txtLoteIn.Right, 
                txtLoteIn.Bottom - btnConvert.Height);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cbChoose.Text == "")
            {
                return;
            }
            else
            {
                List<string> lista = new List<string>();
                string values = txtLoteIn.Text;
                lista = values.Replace("\r\n", " ").Split(' ').ToList();

                #region
                //testando de 0 a 15
                //for (int i = 0; i < 16; i++)
                //{
                //    lista.Add(Convert.ToString(i, 2).PadLeft(4,'0'));
                //}
                #endregion

                if (cbChoose.Text.Equals("Binário → Gray"))
                {
                    foreach (var item in lista)
                    {
                        txtLoteOut.Text += item[0] + ConvertBinary2Gray(item) + "\r\n";
                    }
                }
                else if (cbChoose.Text.Equals("Gray → Binário"))
                {
                    foreach (var item in lista)
                    {
                        txtLoteOut.Text += item[0] + ConvertGray2Binary(item) + "\r\n";
                    }
                }
            }
        }

        private string ConvertBinary2Gray(string value)
        {
            string entrada = value;
            string binario2gray = "";
            for (int i = 0; i < entrada.Length - 1; i++)
            {
                if (entrada[i] == '0' && entrada[i + 1] == '0' || entrada[i] == '1' && entrada[i + 1] == '1')
                    binario2gray += "0";
                else if (entrada[i] == '0' && entrada[i + 1] == '1' || entrada[i] == '1' && entrada[i + 1] == '0')
                    binario2gray += "1";
            }

            return binario2gray;
        }

        private string ConvertGray2Binary(string value)
        {
            string entrada = value;
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

            return gray2Binary;
        }
    }
}
