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
Este repositório é a biblioteca SlackNet (.NET), que foi projetada para funcionar com um único Slack App por processo.
Quero manter o design original da biblioteca, sem transformá-la em multi-tenant genérica.

Objetivo
Implementar suporte para dois contextos Slack independentes (dois apps Slack com tokens diferentes) no mesmo processo, usando composição, não refatoração profunda.

Cada contexto Slack deve:

Ter suas próprias credenciais (Bot Token / App Token)

Ter seu próprio pipeline de eventos e interações

Ter seu próprio ServiceProvider interno

Restrições (NÃO FAÇA):

Não altere interfaces públicas existentes do SlackNet

Não modifique IEventHandler<T>, InteractionDispatcher, EventDispatcher

Não crie um sistema genérico de multi-tenant ou keyed handlers

Não espalhe lógica de chave (key) pelo core da biblioteca

Não altere DTOs, contratos ou middleware existentes

Abordagem desejada

Criar um novo conceito chamado SlackRuntime

Cada SlackRuntime encapsula:

Um ServiceCollection

Um SlackServiceBuilder

Um ServiceProvider isolado

O SlackNet deve continuar sendo inicializado normalmente dentro do runtime

Tarefa

Identifique onde o SlackNet é inicializado hoje (SlackServiceBuilder, DI setup, ASP.NET integration).

Extraia essa inicialização para permitir que ela seja chamada mais de uma vez.

Crie uma classe SlackRuntime que encapsule essa inicialização.

Mostre como dois SlackRuntime podem coexistir no mesmo processo sem conflito.

Não implemente lógica dinâmica ou genérica — assuma apenas dois contextos fixos.

Explique as mudanças propostas antes de aplicar qualquer alteração de código.
