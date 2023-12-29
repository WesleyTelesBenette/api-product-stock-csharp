# API de Estoque

## ✨ Visão Geral
É uma API simples, para o gerenciamento de um estoque genérico de mercado ou similares.

Embora as funcionalidades sejam diretas e comuns, ainda sim é um sistema bem completo, com uma variedade interessante de recursos e manipulações de dados.

## 🏬 Arquitetura
A API utiliza a arquitetura ***Monólito***.

Tendo em vista que o software se concentra numa **única aplicação**, a escolha dessa arquitetura se justifica por:
- 👷🏽‍♀️ Uma **equipe minúscula** (1 pessoa).
- ⚙️ **Não** ser um sistema tão **complexo** e **mirabolante**, a ponto da **dificuldade de manutenção** se tornar um problema sério.

<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/architecture.png" width="600" />

Dividindo a arquitetura dessa forma, acredito que satisfaça eficientemente os objetivos do projeto.

## 🎲 Banco de Dados
Construido com ***PostgreSQL***, o banco de dados foi arquitetado utilizando representações visuais, como: ***MER*** e ***DER***.

### Modelo Entidade Relacionamento
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/MER.png" width="600" />

### Diagrama Entidade Relacionamento
<!--
<img src="https://github.com/WesleyTelesBenette/my-sources-for-docs/blob/main/api-product-stock/architecture.png" width="600" />
-->
> [!NOTE]
> Em breve...

## 🛠️ Tecnologias e Ferramentas Utilizadas
- Linguagem de Programação: ***C#***.
- Framework (backend): ***ASP.NET core***.
- Framework (manipulação de dados): ***Entity Framework***.
- Banco de Dados: ***PostgreSQL***.
- Testes de Conexão: ***Postman***.
