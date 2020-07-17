using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortasLogicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            string entradaA = WriteBitsSequence(148);
            string entradaB = WriteBitsSequence(208);
            string saida = WriteBitsSequence(268);
            FileStream fs = new FileStream("grid.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //MessageBox.Show(entradaA + "\r\n" + entradaB);
            sw.WriteLine(entradaA + "\r\n" + entradaB + "\r\n" + saida);

            #region AND
            //AND requer 2 inteiros na assinatura
            int andResult = AND(Convert.ToInt32(entradaA, 2), Convert.ToInt32(entradaB, 2));
            string resultado = FormataBits(andResult);
            #endregion

            #region OR
            //OR requer 2 inteiros na assinatura
            int orResult = OR(Convert.ToInt32(entradaA, 2), Convert.ToInt32(entradaB, 2));
            #endregion

            sw.WriteLine(resultado);
            sw.Close();
            fs.Close();
            Application.Exit();
        }

        private string WriteBitsSequence(int alturaY)
        {
            //alturaY: valor que inicia a análise da entrada de acordo com o eixo Y.
            //alturaY + 14: linha média entre os níveis alto e baixo.
            
            Image image = Image.FromFile("grid.jpg");
            Bitmap map = new Bitmap(image.Width, image.Height);
            Graphics grafico = Graphics.FromImage(map);
            grafico.Clear(Color.White);
            grafico.DrawImage(image, 0, 0, image.Width, image.Height);

            #region Identificar se começa com nível alto ou baixo
            string comecaCom0ou1 = "";
            for (int altura = alturaY; altura <= alturaY + 34; altura++)
            {
                //sw.WriteLine(map.GetPixel(1, altura).R + " " + map.GetPixel(1, altura).G + " " + map.GetPixel(1, altura).B);
                if (map.GetPixel(1, altura).R < 10 && altura < 162)
                    comecaCom0ou1 = "1";
                else if (map.GetPixel(1, altura).R < 10 && altura > 162)
                    comecaCom0ou1 = "0";
            }
            //sw.WriteLine("\t\tComeça com " + comecaCom0ou1);
            #endregion


            #region Busca as transições traçando uma linha entre os níveis alto e baixo
            string nivel = "";
            string bitSequence = comecaCom0ou1;
            int indice = 0;

            for (int coluna = 30; coluna < image.Height; coluna += 30)
            {
                // Se a linha média tiver cor preta significa que houve transição de nível.
                if (map.GetPixel(coluna, alturaY+14).R < 10 && map.GetPixel(coluna, alturaY+14).G < 10 && map.GetPixel(coluna, alturaY+14).B < 10)
                {
                    if (bitSequence[indice] == '0')
                        nivel = "1";
                    else if (bitSequence[indice] == '1')
                        nivel = "0";
                    bitSequence += nivel;
                }
                else
                {
                    bitSequence += bitSequence[indice];
                }
                indice++;
            }
            #endregion
            
            
            return bitSequence;
        }

        private int AND(int A, int B)
        {
            return A & B;
        }

        private int OR(int A, int B)
        {
            return A | B;
        }

        private string FormataBits(int base10)
        {
            //Converter de inteiro para string
            string resultado = Convert.ToString(base10, 2);
            //Preenche com 0 à esqueda
            return resultado.PadLeft(20, '0');
        }
    }
}
