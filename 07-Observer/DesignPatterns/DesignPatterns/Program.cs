// Projeto Parte 7 : Observer

// O Observer é um padrão de projeto de
// software que define uma dependência um-para-muitos entre
// objetos de modo que quando um objeto muda o estado,
// todos seus dependentes são notificados e atualizados
// automaticamente.

using DesignPatterns.Patterns;
using DesignPatterns.Patterns.Builder;

CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
criador
    .ParaEmpresa("Empresa X")
    .ComCNPJ("12.345.678/0001-88")
    .ComItem(new ItemDaNota("item 1", 250.0))
    .ComItem(new ItemDaNota("item 1", 500.0))
    .DataDeEmissao()
    .ComObservacoes("OBS");

criador.AdicionaAcao(new EnviadorDeEmail());
criador.AdicionaAcao(new NotaFiscalDao());
criador.AdicionaAcao(new EnviadorDeSms());

NotaFiscal nf = criador.Construtor();

Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);

Console.ReadKey();
