using CED.Repository.Model.Enum;

namespace CED.Repository.Model
{
    public class Pokemon
    {
        public Pokemon(int number, string name, TypeEnum type)
        {
            Number = number;
            Name = name;
            Type = type;
        }

        public int Number { get; set; }
        public string Name { get; set; }
        public TypeEnum Type { get; set; }
    }
}
