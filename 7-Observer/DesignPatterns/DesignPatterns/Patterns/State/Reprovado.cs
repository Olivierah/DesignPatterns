using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto adicional");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
