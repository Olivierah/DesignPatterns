namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double meuImposto = imposto.Calcula(orcamento);
            Console.WriteLine(meuImposto);
        }
        
    }
}
