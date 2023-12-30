# API de Estoque

## ✨ Visão Geral
É uma API simples, para o gerenciamento de um estoque genérico de mercado ou similares.

Embora as funcionalidades sejam diretas e comuns, ainda sim é um sistema bem completo, com uma variedade interessante de recursos e manipulações de dados.

## 🏬 Arquitetura
A API utiliza a arquitetura [***Monólito***](https://github.com/WesleyTelesBenette/f-library/blob/master/pt-br/projeto-de-software/arquitetura/monolito.md).

Tendo em vista que o software se concentra numa **única aplicação**, a escolha dessa arquitetura se justifica por:
- 👷🏽‍♀️ Uma **equipe minúscula** (1 pessoa).
- ⚙️ **Não** ser um sistema tão **complexo** e **mirabolante**, a ponto da **dificuldade de manutenção** se tornar um problema sério.

<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/architecture.png" width="600" />

Dividindo a arquitetura dessa forma, acredito que satisfaça eficientemente os objetivos do projeto.

## 🎲 Banco de Dados
Construído com ***PostgreSQL*** (por comodismo), o banco de dados foi arquitetado utilizando representações visuais, como: [***MER***](https://www.hashtagtreinamentos.com/modelo-entidade-relacionamento-sql) e [***DER***](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-entidade-relacionamento).

### Modelo Entidade Relacionamento
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/MER.png" width="600" />

### Diagrama Entidade Relacionamento
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/DER.png" width="600" />

## 📑 UML
A um nível mais baixo de desenvolvimento estão os diagramas UML, com mais detalhes sobre os métodos e como vai ser implementado o sistema de fato.

Os diagramas utilizados são:
- 🔍 [**Caso de Uso**](https://www.lucidchart.com/pages/pt/diagrama-de-caso-de-uso-uml): para ser possível obter uma visão mais geral e até mesmo leiga, de como funciona o sistema.
- 📦 [**Classe**](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml): para ser um guia de implementação, agilizando o desenvolvimento e fornecendo um suporte visual para futuras manutenções.

### Caso de Uso
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/caso-de-uso.png" width="600" />

### Classe
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/classe.png" width="600" />

## 🛠️ Ficha Técnica
- 👤 **Autor**: [Wesley T. Benette](https://github.com/WesleyTelesBenette).
- 🪛 **Linguagem de Programação**: [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/).
- 🧰 **Frameworks**: [ASP.NET core](https://learn.microsoft.com/pt-br/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-8.0) e [Entity Framework](https://learn.microsoft.com/pt-br/ef/).
- 🎲 **Banco de Dados**: [PostgreSQL](https://www.postgresql.org/docs/).
- 🗄️ **Hospedagens Banco de Dados**: [ElephantSQL](https://www.elephantsql.com/).
- 🔌 **Testes de Conexão**: [Postman](https://www.postman.com/).
