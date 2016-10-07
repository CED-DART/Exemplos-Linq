using CED.Repository.Model;
using CED.Repository.Model.Enum;
using System.Collections.Generic;

namespace CED.Repository
{
    public static class Repository
    {
        public static List<Pokemon> GetAllPokemons()
        {
            var pokemons = new List<Pokemon>();

            pokemons.Add(new Pokemon(1, "Bulbassaur", TypeEnum.Grass));
            pokemons.Add(new Pokemon(2, "Ivysaur", TypeEnum.Grass));
            pokemons.Add(new Pokemon(3, "Venusaur", TypeEnum.Grass));

            pokemons.Add(new Pokemon(4, "Charmander", TypeEnum.Fire));
            pokemons.Add(new Pokemon(5, "Charmeleon", TypeEnum.Fire));
            pokemons.Add(new Pokemon(6, "Charizard", TypeEnum.Fire));

            pokemons.Add(new Pokemon(7, "Squirtle", TypeEnum.Water));
            pokemons.Add(new Pokemon(8, "Wartortle", TypeEnum.Water));
            pokemons.Add(new Pokemon(9, "Bastloise", TypeEnum.Water));

            pokemons.Add(new Pokemon(10, "Caterpie", TypeEnum.Bug));
            pokemons.Add(new Pokemon(11, "Metapod", TypeEnum.Bug));
            pokemons.Add(new Pokemon(12, "Butterfree", TypeEnum.Bug));

            pokemons.Add(new Pokemon(13, "Weedle", TypeEnum.Bug));
            pokemons.Add(new Pokemon(14, "Kakuna", TypeEnum.Bug));
            pokemons.Add(new Pokemon(15, "Beedrill", TypeEnum.Bug));

            pokemons.Add(new Pokemon(16, "Pidgey", TypeEnum.Flying));
            pokemons.Add(new Pokemon(17, "Pidgeotto",  TypeEnum.Flying));
            pokemons.Add(new Pokemon(18, "Pidgeot",  TypeEnum.Flying));

            pokemons.Add(new Pokemon(19, "Rattata", TypeEnum.Normal));
            pokemons.Add(new Pokemon(20, "Raticate", TypeEnum.Normal));

            pokemons.Add(new Pokemon(21, "Spearow",  TypeEnum.Flying));
            pokemons.Add(new Pokemon(22, "Fearow",  TypeEnum.Flying));

            pokemons.Add(new Pokemon(23, "Ekans", TypeEnum.Poison));
            pokemons.Add(new Pokemon(24, "Arbok", TypeEnum.Poison));

            pokemons.Add(new Pokemon(25, "Pikachu", TypeEnum.Electric));
            pokemons.Add(new Pokemon(26, "Raichu", TypeEnum.Electric));

            pokemons.Add(new Pokemon(27, "Sandshrew", TypeEnum.Ground));
            pokemons.Add(new Pokemon(28, "Sandslash", TypeEnum.Ground));

            pokemons.Add(new Pokemon(35, "Clefairy", TypeEnum.Fairy));
            pokemons.Add(new Pokemon(36, "Clefable", TypeEnum.Fairy));

            return pokemons;
        }

        public static List<Gym> GetAllGyms()
        {
            var gyms = new List<Gym>();

            gyms.Add(new Gym("Pewter Gym", TypeEnum.Rock));
            gyms.Add(new Gym("Cerulean Gym", TypeEnum.Water));
            gyms.Add(new Gym("Vermilion Gym", TypeEnum.Electric));
            gyms.Add(new Gym("Celadon Gym", TypeEnum.Grass));
            gyms.Add(new Gym("Fuchsia Gym", TypeEnum.Poison));
            gyms.Add(new Gym("Saffron Gym", TypeEnum.Psychic));
            gyms.Add(new Gym("Cinnabar Gym", TypeEnum.Fire));
            gyms.Add(new Gym("Viridian Gym", TypeEnum.Ground));

            return gyms;
        }
    }
}
