namespace DesignPatterns
{
    public class ISS : IImposto
    {
        //Construtor
        public ISS(IImposto outroImposto) : base(outroImposto) { }
        public ISS() : base() { }
        //Métodos
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
        }

       
    }
}
