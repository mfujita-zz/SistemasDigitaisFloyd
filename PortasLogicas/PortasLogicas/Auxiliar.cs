using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortasLogicas
{
    class Auxiliar
    {
        public List<int> bitsErro { get; set; }
        private string respostaAluno;
        private string gabarito;

        public Auxiliar(string _resposta, string _gabarito)
        {
            respostaAluno = _resposta;
            gabarito = _gabarito;
        }

        public List<int> CorrecaoResposta()
        {
            bitsErro = new List<int>();
            for (int i = 0; i < gabarito.Length; i++)
            {
                if (!gabarito[i].Equals(respostaAluno[i]))
                {
                    bitsErro.Add(i);
                }
            }

            return bitsErro;
        }
    }
}
