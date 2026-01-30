# DesignPatterns
## Examples of how to use a Design Pattern

**Budget system**

###### Info: 
Framework Version: DotNet 6 

###### NOTE: 
All examples represent a progression of a budget system using appropriate Design Patterns for each situation.

Each enumerated folder contains a Design Pattern type. Just choose one to get started! 
I hope I can help =)

###### Just in case: 
**This project is part of my personal portfolio, so any feedback or suggestion that can contribute to my growth and improve my development skills will be most welcome.**



![Preview-Screens](ImageAsset/dp.png)





Contexto
Este repositório é a biblioteca SlackNet para .NET.
Atualmente, a integração com ASP.NET Core expõe o método público:

IServiceCollection AddSlackNet(IServiceCollection, Action<AspNetSlackServiceConfiguration>)


Esse método registra uma única instância da SlackNet no container de DI.

O objetivo é permitir duas instâncias da SlackNet no mesmo container, cada uma com credenciais diferentes, usando Keyed Services nativos do .NET.

Modelo mental esperado (IMPORTANTE)
A implementação desejada deve ser conceitualmente equivalente a:

services.AddKeyedSingleton<IApp, AppA>("appA");
services.AddKeyedSingleton<IApp, AppB>("appB");


No caso da SlackNet, o serviço registrado por chave será um runtime isolado:

services.AddKeyedSingleton<ISlackRuntime>("appA", ...);
services.AddKeyedSingleton<ISlackRuntime>("appB", ...);


Objetivo técnico
Criar uma sobrecarga do método AddSlackNet que:

Aceite um parâmetro adicional object key

Utilize AddKeyedSingleton

Permita múltiplos registros da SlackNet no mesmo container

Mantenha total compatibilidade com o método AddSlackNet existente

O consumidor da biblioteca deve conseguir escrever:

services.AddSlackNet("appA", c => { /* config app A */ });
services.AddSlackNet("appB", c => { /* config app B */ });


Restrições (NÃO FAÇA)

NÃO altere o método AddSlackNet existente

NÃO modifique sua assinatura

NÃO crie um método com nome diferente (use sobrecarga)

NÃO torne a SlackNet multi-tenant genérica

NÃO altere IEventHandler<T>, dispatchers ou DTOs

NÃO implemente lógica de roteamento ou resolução de chave aqui

NÃO espalhe lógica de key pelo core da biblioteca

Abordagem obrigatória

Crie um novo conceito chamado ISlackRuntime

Cada ISlackRuntime deve encapsular:

Um ServiceCollection próprio

Um AspNetSlackServiceConfiguration

Um ServiceProvider isolado

O SlackNet deve continuar sendo inicializado normalmente, apenas dentro desse runtime

Tarefa

Crie a sobrecarga de AddSlackNet(IServiceCollection, object key, Action<AspNetSlackServiceConfiguration>).

Use services.AddKeyedSingleton<ISlackRuntime>(key, ...) internamente.

Reutilize AspNetSlackServiceConfiguration e ConfigureServices() — não duplique lógica.

Mostre a implementação mínima necessária.

Explique brevemente por que essa sobrecarga não quebra compatibilidade com o método original.

Importante:
Explique as mudanças propostas antes de aplicar qualquer alteração de código.
