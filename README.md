# TechTitans - Sistema de Gerenciamento de Manutenção

O TechTitans é um sistema desenvolvido em C# para auxiliar no gerenciamento de serviços de manutenção. 
A aplicação permite cadastrar ordens de serviço, controlar o estoque de peças, registrar funcionários responsáveis e calcular automaticamente os custos de cada manutenção.
O objetivo do projeto é centralizar todas as informações do processo de manutenção, proporcionando maior organização, controle e rastreabilidade.

# Tecnologias Utilizadas

* C#
* .NET
* Windows Forms
* SQL Server
* Visual Studio

# Funcionalidades

* Cadastro de clientes
* Cadastro de equipamentos
* Cadastro de funcionários
* Cadastro de peças
* Controle de estoque
* Abertura de Ordens de Serviço (OS)
* Associação de funcionários responsáveis
* Registro das peças utilizadas na manutenção
* Baixa automática do estoque ao utilizar peças
* Cadastro do valor da mão de obra
* Cálculo automático do valor total da manutenção
* Consulta e gerenciamento das Ordens de Serviço

# Principais Módulos

## Funcionários

Permite cadastrar os colaboradores responsáveis pelas manutenções, armazenando suas informações para posterior vinculação às Ordens de Serviço.

## Estoque de Peças

Gerencia o cadastro de peças utilizadas nas manutenções, incluindo:

* Nome da peça
* Quantidade em estoque
* Valor unitário

Sempre que uma peça é utilizada em uma Ordem de Serviço, sua quantidade é atualizada automaticamente no estoque.

## Ordem de Serviço

A Ordem de Serviço concentra todas as informações da manutenção:

* Cliente
* Equipamento
* Funcionário responsável
* Data de abertura
* Descrição do problema
* Peças utilizadas
* Valor das peças
* Valor da mão de obra
* Valor total do serviço
* Status da manutenção

## Controle de Custos

O sistema calcula automaticamente o valor total da manutenção com base em:

* Soma das peças utilizadas;
* Valor da mão de obra.

# Estrutura do Projeto

TechTitans/
│
├── Forms/
├── Models/
├── Data/
├── Services/
├── Repository/
├── Banco de Dados/
└── README.md

# Como Executar

## 1. Clone o repositório

git clone https://github.com/sMEduarda/TechTitans_Info.git

## 2. Abra o projeto

Abra o arquivo `.sln` utilizando o Visual Studio.

## 3. Configure o Banco de Dados

* Instale o SQL Server.
* Execute o script de criação do banco de dados (caso disponível).
* Atualize a *Connection String* no projeto com as configurações do seu ambiente.

## 4. Execute o projeto

Pressione F5 ou clique em Start no Visual Studio para iniciar a aplicação.

# Fluxo do Sistema

1. Cadastro de funcionários.
2. Cadastro de clientes.
3. Cadastro de equipamentos.
4. Cadastro de peças e controle do estoque.
5. Abertura da Ordem de Serviço.
6. Associação do funcionário responsável.
7. Seleção das peças utilizadas.
8. Baixa automática do estoque.
9. Registro da mão de obra.
10. Cálculo automático do valor total do serviço.
11. Encerramento da Ordem de Serviço.

# Regras de Negócio

* Não é possível utilizar uma quantidade de peças superior ao estoque disponível.
* Toda peça utilizada reduz automaticamente a quantidade em estoque.
* O valor total da Ordem de Serviço é calculado automaticamente.
* Cada Ordem de Serviço possui um funcionário responsável.
* Todas as movimentações ficam registradas para consulta.

# Conceitos Aplicados

* Programação Orientada a Objetos (POO)
* CRUD
* Windows Forms
* Banco de Dados Relacional
* Controle de Estoque
* Regras de Negócio
* Gestão de Ordens de Serviço

Projeto acadêmico desenvolvido com o objetivo de aplicar conceitos de desenvolvimento de software, banco de dados e gestão de processos de manutenção.
