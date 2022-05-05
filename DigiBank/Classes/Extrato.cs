using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Extrato
    {
        public Extrato(DateTime data, string descricao, double valor)
        {
            this.Data = data;
            this.Descricao = descricao;
            this.Valor = valor;
        }

        public DateTime Data { get; private set; }

        public string Descricao { get; private set; }

        public double Valor { get; private set; }
    }
}
