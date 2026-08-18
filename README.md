# Sistema de Cadastro de Funcionários — C#

Aplicação **Console desenvolvida em C#** para gerenciamento básico de funcionários, com foco na aplicação de conceitos de programação orientada a objetos, estruturas de dados, entrada e validação de informações.

## Sobre o Projeto

O projeto implementa um sistema de cadastro de funcionários executado em ambiente de terminal. A aplicação permite inserir, consultar, atualizar e remover registros por meio de uma interface textual.

O desenvolvimento tem como objetivo aplicar conceitos fundamentais da linguagem **C#** e da plataforma **.NET**, simulando uma aplicação de gerenciamento de dados em um cenário corporativo.

## Funcionalidades

* Cadastro de funcionários
* Listagem dos funcionários cadastrados
* Consulta de funcionários
* Atualização de dados
* Remoção de registros
* Identificação dos funcionários por ID
* Validação de entradas
* Interface baseada em menu
* Tratamento básico de exceções

## Tecnologias

* **C#**
* **.NET**
* **Console Application**
* **Programação Orientada a Objetos (POO)**
* **Visual Studio / Visual Studio Code**
* **Git e GitHub**

## Conceitos Aplicados

O projeto utiliza conceitos importantes da programação, incluindo:

* Classes e objetos
* Encapsulamento
* Construtores
* Propriedades
* Métodos
* Listas e coleções
* Estruturas condicionais
* Estruturas de repetição
* Manipulação de entrada e saída
* Validação de dados
* Tratamento de exceções
* Separação de responsabilidades

## Estrutura do Projeto

```text
CadastroFuncionarios/
│
├── Program.cs
├── Entities/
│   └── Funcionario.cs
│
└── README.md
```

A classe `Funcionario` representa a entidade principal do sistema, enquanto `Program.cs` concentra o fluxo de execução e interação com o usuário.

## Exemplo de Entidade

```csharp
 public Funcionario(int matricula, string nome, string endereço, string cidade, string uf, string cep, string cpf, string telefone, string email, DateTime datanasc)
{
    Matricula = matricula;
    Nome = nome;
    Endereço = endereço;
    Cidade = cidade;
    Uf = uf;
    Cep = cep;
    Cpf = cpf;
    Telefone = telefone;
    Email = email;
    Datanasc = datanasc;
}
```

## Execução

Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git
```

Entre no diretório:

```bash
cd CadastroFuncionarios
```

Execute o projeto:

```bash
dotnet run
```

## Objetivo Acadêmico

Este projeto foi desenvolvido como exercício prático para consolidar conhecimentos em **C# e Programação Orientada a Objetos**, utilizando uma aplicação de console como ambiente de implementação.

A arquitetura pode ser posteriormente expandida para utilizar persistência de dados, banco de dados relacional, API REST e uma interface gráfica.

## Possíveis Evoluções

* Persistência em **SQL Server ou MySQL**
* Implementação de **Entity Framework Core**
* Criação de uma API REST com **ASP.NET Core**
* Interface gráfica com **WinForms ou WPF**
* Implementação de autenticação e autorização
* Separação em camadas
* Aplicação de princípios **SOLID**
* Testes automatizados

## Status

**Concluido**

---

Desenvolvido por **Thiago Lopes**.
