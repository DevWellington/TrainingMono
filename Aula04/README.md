#Outros Tipos de Dados

##Enumeradores 

- Identificam um conjunto de constantes nomeadas;
- Permite uma leitura facilitada do codigo


```cSharp
enum DiaSemana : int
{
	SegundaFeira,
	TercaFeira,
	QuartaFeira,
	QuintaFeira,
	SextaFeira,
	Sabado,
	Domingo
}

DiasDaSemana dia;
Dia = DiasDaSemana.Domingo;

```

##Classes

E uma "fabrica" para produzir objetos

Determina um conjuunto de objetos com:

- Propriedade semelhantes
- Comportamentos semelhantes
- Relacionamentos comuns

###Modificadores de acesso

- Public
- Protected
- Internal
- Private

###Partial Class

Divide a definicao de uma classe em varios arquivos

- Ajuda em organização
- Ex: Propriedades arquivo 1, metodos arquivo 2;

###Definicao de Classe

```cSharp
public class Carro
{
    public TipoCarro tipo;
    public int numeroDePortas;
    
    public int Autonomia()
    {
    
    }
}
```    

###Construtores

- São metodos especiais que implementam as ações necessárias para inicializar um objeto
- Tem o mesmo nome da classe

Define o padrão

```cSharp
public class Carro
{
    public int numeroDePortas;
    
    public int Carro(TipoCarro tipo)
    {
    }
}
``` 
###Instancias

Cria um objeto distinto na memoria

Realiza pela clausula NEW

```cSharp
Carro meuCarro = new Carro(TipoCarro.Sedan);
Carro meuCarro = new Carro(TipoCarro.Hatch);
``` 

###Membros de Classe

```cSharp
Carro meuCarro = new Carro(TipoCarro.Sedan);
meuCarro.numeroDePortas = 4;
int autonomia = meuCarro.Autonomia();
``` 

###Propriedades

São metodos que protegem o acesso aos membros da classe

```cSharp
private string _nome;
public string Nome
{
    get{ return _nome;}
    set{_nome = value;}
}
``` 

```cSharp
Pessoa objPessoa = new Pessoa();
objPessoa.Nome = "Wellington";

``` 

###Propriedades Automaticas

- Podem ser utilizadas quando o objetivo é apenas armazenar um valor

```cSharp
public string nome
{
    get;
    set;
}
``` 
```cSharp
Pessoa objPessoa = new Pessoa();
objPessoa.Nome = "Wellington";

``` 

###Estruturas

- Uso recomendado para representar objetos leves
- Nao podem ser herdados, porem podem implementar interfaces;
- Nao eh permitido um construtor sem parametros;
- Nao eh permitido um destrutor


###Definicao estrutura

Descreve o conteudo da estrutura

```cSharp
struct Moradia
{
    public string rua.
    public int numero;
}

Moradia minhaCasa;

minhaCasa.Rua = "Tallfas";
minhaCasa.Numero = 3948;

``` 

###Nullables Types

Permite tipos por valor assumirem valores nulos

```cSharp
int valor1 = 0;
int? valor2 = null;

if(valor2.HasValue)
    valor1 = valor2.Value;

``` 

- HasValue verifica se a variavel eh nula;
- Value retorna o valor numerico caso haja;

Por padrao tipo numerico nao pode receber nulo, utilizando o [?] voce permite a utilizacao;

###Exceções podem indicar erros

- Exceções não tratadas são propagadas;
- A exceção é propagada até ser tratada;
- Caso não seja tratada a aplicação ira reportar o erro com um "crash";

###try ... catch

- Permite tratar as exceções detecdadas;
- Trata as exceções com diferentes tipos de especificidade

```cSharp
try
{
    int x = 10/0;
}
catch (DivideByZeroException ex)
{ }
catch (Exception ex)
{ }
``` 

###Finally

- É executado depois de um bloco Try Catch
- Quando definido é executado caso haja erro ou não

```cSharp
try
{
    WriteToFile(...);
} catch(IOException ex) {
    Console.WriteLine(ex.Message);
} finally  {
    CloseFile("MyFile");
}

``` 

###Trow

Permite criar exceções

```cSharp
public int RaizInteira(int operand)
{
    double root = Math.Sqrt(operand);
    if (root != (int) root)
        trow new ArgumentException("Numero nao eh Inteiro");
    } 
    
    return (int) root;
}
``` 


















