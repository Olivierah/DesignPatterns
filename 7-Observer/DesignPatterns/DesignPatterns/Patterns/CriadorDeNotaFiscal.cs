using DesignPatterns.Patterns.Builder;

namespace DesignPatterns.Patterns
{
    public class CriadorDeNotaFiscal
    {
        //Propriedades

        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime Data { get; set; }
        private double ValorTotal { get; set; }
        private double Impostos { get; set; }
        private string Observacoes { get; set; }

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        private IList<IAcaoAposGerarNota> TodasAsAcoesASeremExecutadas = new List<IAcaoAposGerarNota>(); 


        // Métodos
        public NotaFiscal Construtor()
        {
            NotaFiscal nf = new NotaFiscal(
                RazaoSocial,
                CNPJ,
                Data,
                ValorTotal,
                Impostos,
                TodosItens,
                Observacoes
                );

            foreach(IAcaoAposGerarNota item in TodasAsAcoesASeremExecutadas)
            {
                item.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            TodasAsAcoesASeremExecutadas.Add(novaAcao);
        }

        public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public CriadorDeNotaFiscal ComCNPJ(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public CriadorDeNotaFiscal DataDeEmissao()
        {
            Data = DateTime.Now;
            return this;
        }

    }
}
