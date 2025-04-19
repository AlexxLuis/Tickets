# Sistema de Cadastro de Funcionários e Tickets

Este projeto foi desenvolvido no **Visual Studio** utilizando **C#** com **Windows Forms** do **.NET**. A aplicação tem como objetivo realizar o cadastro e a gestão de funcionários, bem como o controle de tickets associados a cada funcionário.

## Tecnologias Utilizadas:
- **Linguagem:** C#
- **Framework:** .NET
- **Interface:** Windows Forms
- **Banco de Dados:** SQLite
- **ORM:** Entity Framework Core

## Banco de Dados:
O banco de dados é gerado utilizando **SQLite** com **Entity Framework Core** para o gerenciamento das entidades. As tabelas são criadas por meio de **Migrations**, e as consultas são realizadas utilizando **LINQ**.

## Instruções de Execução:
1. **Pré-requisitos:**
   - Visual Studio (ou outra IDE compatível com C# e .NET).
   - SQLite para o banco de dados.
   - O banco de dados será gerado automaticamente ao rodar a aplicação, se necessário.

2. **Como Rodar o Sistema:**
   - Abra o projeto no Visual Studio.
   - Compile o projeto.
   - Execute a aplicação.

### Geração do Banco de Dados:
O banco de dados SQLite pode ser gerado de duas formas:

1. **Com Migrations:**
   Para gerar o banco de dados e as tabelas usando as Migrations do Entity Framework Core, basta executar os seguintes comandos no terminal:

   ```bash
   dotnet ef migrations add Inicial
   dotnet ef database update
2. **Com Script SQL:**
    No diretório raiz do repositório, há um script SQL denominado script_inicial.sql que contém os comandos para criação do banco de dados e das tabelas. Você pode executá-lo em qualquer ferramenta de banco de dados SQLite para criar o banco de dados manualmente.

   
