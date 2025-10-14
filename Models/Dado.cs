using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoladorDeDadosMAUI.Models
{
    public class Dado
    {
        private int qtelados;
        private int ladoSorteado;

        public Dado(int lados)
        {
            qtelados = lados;
        }

        public int LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }

        public void rolar()
        {
            ladoSorteado = Random.Shared.Next(1, qtelados + 1);
        }

    }
}
