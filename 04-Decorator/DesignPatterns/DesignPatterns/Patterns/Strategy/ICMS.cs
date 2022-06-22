namespace DesignPatterns
{
    public class ICMS : IImposto
    {
        //Construtor
        public ICMS(IImposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        //Métodos
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculaOutroImposto(orcamento); ;
        }
    }
}
