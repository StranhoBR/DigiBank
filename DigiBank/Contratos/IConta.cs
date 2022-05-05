using DigiBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Contratos
{
    public interface IConta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        double ConsultaSaldo();
        string GetCodigoBanco();
        string GetNumeroAgencia();
        string GetNumeroDaConta();

        List<Extrato> Extrato();
    }
}
