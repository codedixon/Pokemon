using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poke.Models
{

    public class Abilities
    {
        public object[] effect_changes { get; set; }
        public Effect_Entries[] effect_entries { get; set; }
        public Flavor_Text_Entries[] flavor_text_entries { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public bool is_main_series { get; set; }
        public string name { get; set; }
        public Name[] names { get; set; }
        public Pokemon[] pokemon { get; set; }
    }

    public class AbilityGeneration
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability_Effect_Entries
    {
        public string effect { get; set; }
        public Language language { get; set; }
        public string short_effect { get; set; }
    }

    public class AbilityLanguage
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability_Flavor_Text_Entries
    {
        public string flavor_text { get; set; }
        public Language1 language { get; set; }
        public Version_Group version_group { get; set; }
    }

    public class AbilityLanguage1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class AbilityVersion_Group
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class AbilityName
    {
        public Language2 language { get; set; }
        public string name { get; set; }
    }

    public class AbilityLanguage2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class AbilityPokemon
    {
        public bool is_hidden { get; set; }
        public AbilityPokemonName pokemon { get; set; }
        public int slot { get; set; }
    }

    public class AbilityPokemonName
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
