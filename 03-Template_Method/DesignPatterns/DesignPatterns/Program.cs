// Projeto Parte 3 : Template Method

// É um padrão que auxilia na definição de um algoritmo com partes do mesmo
// definidos por métodos abstratos.

using DesignPatterns;
using DesignPatterns.Patterns;

Orcamento orcamento = new Orcamento(8000);

ICPP icpp = new ICPP();
IKVC ikvc = new IKVC();

double ikvcResult = ikvc.Calcula(orcamento);
double icppResult = icpp.Calcula(orcamento);


Console.WriteLine($"Imposto IKVC: {ikvcResult}");
Console.WriteLine($"Imposto ICPP: {icppResult}");
Console.ReadKey();
