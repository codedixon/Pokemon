using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.Models
{

    public class Types
    {
        public Damage_Relations damage_relations { get; set; }
        public Game_Indices[] game_indices { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public Move_Damage_Class move_damage_class { get; set; }
        public Move[] moves { get; set; }
        public string name { get; set; }
        public Name[] names { get; set; }
        public Pokemon[] pokemon { get; set; }
    }

    public class Damage_Relations
    {
        public Double_Damage_From[] double_damage_from { get; set; }
        public Double_Damage_To[] double_damage_to { get; set; }
        public Half_Damage_From[] half_damage_from { get; set; }
        public Half_Damage_To[] half_damage_to { get; set; }
        public No_Damage_From[] no_damage_from { get; set; }
        public object[] no_damage_to { get; set; }
    }

    public class Double_Damage_From
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Double_Damage_To
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Half_Damage_From
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Half_Damage_To
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class No_Damage_From
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class TypeGeneration
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move_Damage_Class
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class TypeGame_Indices
    {
        public int game_index { get; set; }
        public Generation1 generation { get; set; }
    }

    public class Generation1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class TypeMove
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class TypeName
    {
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class TypeLanguage
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonType1
    {
        public PokemonType2 pokemon { get; set; }
        public int slot { get; set; }
    }

    public class PokemonType2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
