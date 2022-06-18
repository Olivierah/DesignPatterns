// Projeto Parte 6 : Builder

// O Builder permite produzir diferentes tipos e representações de um objeto usando o mesmo código de construção.

using DesignPatterns.Patterns;

CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
criador
    .ParaEmpresa("Empresa X")
    .ComCNPJ("12.345.678/0001-88")
    .ComItem(new ItemDaNota("item 1", 250.0))
    .ComItem(new ItemDaNota("item 1", 500.0))
    .DataDeEmissao()
    .ComObservacoes("OBS");

NotaFiscal nf = criador.Construtor();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);

Console.ReadKey();
