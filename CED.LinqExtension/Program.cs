using CED.Repository.Model;
using CED.Repository.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CED.LinqExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Listas paras os exemplos
             */
            var pokemons = Repository.Repository.GetAllPokemons();
            var gyms = Repository.Repository.GetAllGyms();
            var emptyList = new List<Pokemon>();

            #region Reescrevendo os exemplos de Linq Query em Linq Extension

            /*
            * Pegar todos os pokémons do tipo de fogo
            */
            var firePokemons = pokemons.Where(p => p.Type == TypeEnum.Fire);

            /*
             * Pegar o pokémon número 27
             */
            var number27 = pokemons.FirstOrDefault(p => p.Number == 27);

            /*
             * Join
             * Pokemons de um tipo que tenha um ginásio
             */
            var pokemonsWhoHasTheSameGymType = pokemons
                .Join(gyms, p => p.Type, g => g.Type, (p, g) => new { Pokemon = p, Gym = g })
                .Select(s => s.Pokemon).ToList();

            /*
             * Quantidade de pokemons por tipo em ordem descendente
             */
            var pokemonsByType = pokemons.GroupBy(p => p.Type)
                .Select(p => new { type = p.Key, quantity = p.Count() })
                .OrderByDescending(p => p.quantity).ToList();

            #endregion

            #region Linq avançado

            /*
             * Any vs All vs Exists
             */

            // Verfica se algum pokémon da lista tem o número 1
            Console.WriteLine("Tem algum pokémon número 1? {0}", pokemons.Any(p => p.Number == 1));
            // Verifica se todos os pokémons é o número 1
            Console.WriteLine("Todos os pokémon são número 1? {0}", pokemons.All(p => p.Number == 1));
            // Similar ao Any, mas uma versão antiga que não tem implementação para todas as listas
            Console.WriteLine("Tem algum pokémon número 1? {0}", pokemons.Exists(p => p.Number == 1));

            /*
             * LastOrDefault vs Last
             */

            /* 
             * Pega o último elemento da lista, caso a lista esteja vazia devolve o valor padrão.
             * Neste caso, por ser uma classe o retorno é null
             */
            Console.WriteLine(emptyList.LastOrDefault());
            // Pega o último elemento da lista, caso a lista esteja vazia devolve devolve um erro
            try
            {
                Console.WriteLine(emptyList.Last());
            }
            catch
            {
                Console.Write("Deu ruim");
            }

            /*
             * FirstOrDefault vs First
             */
            /* 
             * Pega o primeiro elemento da lista, caso a lista esteja vazia devolve o valor padrão.
             * Neste caso, por ser uma classe o retorno é null
             */
            Console.WriteLine(emptyList.FirstOrDefault());
            // Pega o último elemento da lista, caso a lista esteja vazia devolve devolve um erro
            try
            {
                Console.WriteLine(emptyList.First());
            }
            catch
            {
                Console.WriteLine("Deu ruim de novo");
            }


            /*
             * First vs Single vs SingleOrDefault
             */
            // Pega o primeiro item da lista e retorna o elemento
            Console.WriteLine(pokemons.FirstOrDefault(f => f.Type == TypeEnum.Water));
            /* 
             * Verifica se tem apenas um elemento compativel com a regra na lista, 
            *  se tive mais de um ou nenhum devolve um erro,
            *  caso tenha apenas um devolve o item
            */
            try
            {
                Console.WriteLine(pokemons.Single(f => f.Type == TypeEnum.Water));
            }
            catch
            {
                Console.WriteLine("De novo =/");
            }
            /* 
             * Verifica se tem apenas um elemento compativel com a regra na lista, 
            *  se tive mais de um devolve um erro
            *  caso tenha apenas um item devolve o item e caso tenha nenhum devolve o valor padrão
            */
            try
            {
                Console.WriteLine(pokemons.SingleOrDefault(f => f.Type == TypeEnum.Water));
            }
            catch
            {
                Console.WriteLine("Deu ruim mas menos ruim que o anterior...");
            }


            #endregion

            #region Dicas e más exemplos encontrados na Dart

            /*
             * Verificar se a lista tem itens
             * Muito comum encontrar nos códigos a verificação Count> 0, sendo que é muito mais legivel utilizar Any()
             */
            var temItensFeio = pokemons.Count > 0;
            var temItensBonito = pokemons.Any();

            /*
             * Pegar o primeiro item da lista
             * Não há necessidade de fazer um Where e depois pega o primeiro item, pode colocar a regra dentro do First.
             * Comum com outros casos, como Count(), Last()...
             */
            var primeiroItemFeio = pokemons.Where(p => p.Number == 28).First();
            var primeiroItemBonito = pokemons.FirstOrDefault(p => p.Number == 28);

            #endregion

        }
    }
}
