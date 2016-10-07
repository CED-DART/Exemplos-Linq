using CED.Repository.Model.Enum;
using System.Collections.Generic;

namespace CED.Repository.Model
{
    public class Gym
    {
        public Gym(string name, TypeEnum type)
        {
            Name = name;
            
            Type = type;
        }

        public string Name { get; set; }
        public TypeEnum Type { get; set; }
    }
}
