using CED.Repository.Model;
using CED.Repository.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CED.LinqQuery
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

            /*
             * Pegar todos os pokémons do tipo de fogo
             */
            var firePokemons = (from pokemon in pokemons
                                where pokemon.Type == TypeEnum.Fire
                                select pokemon).ToList();
            Console.WriteLine("Foram encontrados {0} pokémons do tipo de fogo.", firePokemons.Count);

            /*
             * Pegar o pokémon número 27
             */
            var number27 = (from pokemon in pokemons
                            where pokemon.Number == 27
                            select pokemon).FirstOrDefault();
            Console.WriteLine("O pokémon número 27 é {0}", number27.Name);

            /*
             * Join
             * Pokemons de um tipo que tenha um ginásio
             */
            var pokemonsWhoHasTheSameGymType = (from pokemon in pokemons
                                                join gym in gyms on pokemon.Type equals gym.Type
                                                select pokemon).ToList();

            /*
             * Quantidade de pokemons por tipo em ordem descendente
             */
            var countByType = (from pokemon in pokemons
                               group pokemon by pokemon.Type into pokemonGroup
                               orderby pokemonGroup.Count() descending
                               select new
                               {
                                   Type = pokemonGroup.Key,
                                   total = pokemonGroup.Count()
                               }).ToList();
        }
    }
}
