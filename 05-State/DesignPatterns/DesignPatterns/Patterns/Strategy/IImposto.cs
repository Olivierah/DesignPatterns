namespace DesignPatterns
{
    public abstract class IImposto
    {
        // Propriedades
        public IImposto OutroImposto { get; set; }

        //Construtor
        public IImposto(IImposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public IImposto()
        {
            OutroImposto = null;
        }


        //Métodos
        public abstract double Calcula(Orcamento orcamento);

        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
