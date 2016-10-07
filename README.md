# Exemplos-Linq
Projeto para apresentação sobre a utilização do Linq

# O que é Linq?
É o acrônimo de Language-Integrated Query que é o conjunto de recursos introduzidos no .NET Framework 3.5 que permitem a realização de consultas e manipulação de listas.
Você pode utilizar o Linq para:
* Linq para objetos
* Linq para DataSet
* Linq para SQL
* Ling para entidades
* Linq para XML

# Como utilizar?
Para utilizar basta referenciar o namespace [System.Linq](https://msdn.microsoft.com/pt-br/library/system.linq(v=vs.111).aspx). Existem dois tipos de linq:
* Linq Query
* Linq Extension

## Linq Query
É o Linq com uma sintaxe similar de consultas SQL, sua sintaxe base é:

`from <item da lista>  in <lista>
where <cláusula>
select <retorno do select>`

Para visualizar exemplos de sua utilização, veja a class "Program" dentro do project "CED.LinqQuery" ou [clique aqui](https://github.com/IgorRozani/Exemplos-Linq/blob/master/CED.LinqQuery/Program.cs)

## Linq Exension
É o Linq com uma sintaxe mais voltada ao C#, criada através de [extension methods](https://msdn.microsoft.com/pt-br/library/bb383977.aspx), sua sintaxe base é:

`<lista>.<método>(<expressão lambda>)`

Para visualizar exemplos de sua utilização, veja a class "Program" dentro do project "CED.LinqExtension" ou [clique aqui](https://github.com/IgorRozani/Exemplos-Linq/blob/master/CED.LinqExtension/Program.cs)

## Linq Query vs Linq Extension
Através dos exemplos, é possível perceber que o Linq Extension tem uma sintaxe mais simples e mais legível, por isso é preferivel a sua utilização na maioria dos casos. 
Outro ponto negativo do Linq Query é que comumente temos que misturar a sua utilização com Linq Extension, pois não é possível realizar todas consultas apenas com ele.

É preferivel utilizar a utilização de Linq Query quando tiver que realizar o join entre listas, pois sua sintaxe é mais clara.

# Links úteis
[Msdn sobre Linq Extension](https://msdn.microsoft.com/pt-br/library/system.linq.immutablearrayextensions(v=vs.111).aspx)

[101 exemplos de Linq](https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)
