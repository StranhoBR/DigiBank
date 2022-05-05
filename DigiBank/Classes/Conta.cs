using DigiBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta() 
        {
            this.NumeroAgencia = "0001";
            Conta.NumeroDaContaSequencial++;
            this.Movimentacoes = new List<Extrato>();
        }

        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroDaConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Deposito", valor));
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(valor > ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque", -valor));

            this.Saldo -= valor;
            return true;
        }

        public string GetCodigoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetNumeroDaConta()
        {
            return this.NumeroDaConta;
        }

        public List<Extrato> Extrato()
        {
            return this.Movimentacoes;
        }
    }
}
