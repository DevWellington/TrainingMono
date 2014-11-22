#Introdução ao .NET Framework 

##Introdução ao .NET Framework 

- Class Library: Conjunto de funcionalidades que são divididas em Classes;

- CLR (Common Language Runtime): Maquina virtual que vai executar os programas escritos em C#;

C# é uma linguagem de alto nível.

##O que é o C#

- Compativel com o .NET Framework;
- Inspirado no C, C++ e algumas coisas em Java;
- O ECMA especifica a linguagem C#;

O Mono é o CLR (VM .NET);

##Três Pilares Principais

Desenvolvimento rápido de aplicativos;
  
Colaboração eficaz;


#Assembly

##O que é um Assembly?

Block de uma aplicacao (DLL ou EXE por exemplo);

Código IL (Código traduzido para a CLR)

Podem receber uma assinatura digital


##Visual Studio 2013

Caracteristicas:

- Desenvolvimento Rápido de Aplicações
- Acesso a banco de dados
- Debug avançado
- Etc;

##Visual Studio 2010

Templates:  

- Permitem a criação da base de um projeto:

    - Ex: Windows Forms, Windows Service, ASP.NET MVC, etc;
    
##Xamarin Studio

Diferencas:

- Multiplataforma
- Acesso a banco de dados
- Debug
- Tratamento de Erro
- Documentacao de Código

Não conseguimos o "desenhador de telas do Windows Forms"

##Classes e Namespaces

###Classe

Define as características básicas de uma entidade;

Partir dela é gerado um objeto;

###Namespaces

Representa um agrupamento lógico de classes;

##Estrutura de um Programa

```Csharp
// adiciona o name "System" ao escopo da aplicacao
using System; 
    // Declaração do namespace da Aplicacao
    namespace ProjetoAula
    {
        // Declaracao do nome da classe "Program"
        class Program
        {
            // Declaracao do metodo "Main"
            // void: Não retorna nada
            static void Main(string[] args)
            {
            
            }
        }
    }

```

##Console Application

- Clear();
    - Limpa a saída do Console
    
- Read()
    - Retorna o que for digitado
    
- Write()
    - Escreve uma mensagem
    
using System;
    Console.WriteLine("Hello world");

##Variaveis

###Declaracao

São declaradas definindo seu tipo e nome
Ex TipoDeDado NomeDaVariavel;

###Atribuicao de Valor
  
Determina um valor para a variável

Ex: NomeDaVariavel = Valor ou TipoDeDado NomeDaVariavel = Valor;


##Escopo da Variavel

###Bloco
Dentro de um bloco de comandos

```Csharp
if (tamanho > 10)
{
    int area = 2 * lado;
}
```

###Metodo
No corpo de um método

```Csharp
void MostrarNome()
{
    string name = "Wellington Ribeiro";
}
```

###Classe
Em toda a class

```Csharp
private string texto;

void DefinirText()
{
    texto = "Novo Texto";
}
```

###Modificadores de Acesso

Permite o acesso controlaro às variáveis;

- Public: Permite irrestrito
- Protected: Permite acesso à classe que a define 
- Private: Somente dentro do codigo da classe

**.... Video travou na tela do Alexandre :(**


##Tipos por Referencia

- Armazenam na memoria Heap
- Trabalha com ponteiros

##Conversão de Tipo

###Conversão Implicita

- Realizada diretamente pela CLR;
- Não ha risco de perda de dados ou erros;

```Csharp
int a = 4;
long b;
b = a;
```

###Conversão Explicita

- Exige escrita de código
- Há risco de perda de dados ou erros

```Csharp
int contador = Convert.ToInt32("1234");

int number = 0;
if (int.TryParse("1234", out numbero))
```

##Tipo de Dados

Boxing/Unboxing

Unboxing: Conversão de um tipo por referencia para um tipo por valor;

Boxing: Conversão de um tipo por valor para um tipo por referência;

```Csharp
int i = 123;
Object Obj;
Obj = i;
String S;
S = Obj.ToString();
int x;
x = (int) 0;
```



















