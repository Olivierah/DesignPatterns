using DesignPatterns.Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    public interface IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf);
    }
}
