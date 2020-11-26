﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Poke.Models
{

    public class Move
    {
        public Move1 move { get; set; }
        public Version_Group_Details[] version_group_details { get; set; }
    }

    public class Move1
    {
        public string name { get; set; }
        public string url { get; set; }
    }


    public class Moves
    {
        public int? accuracy { get; set; }
        public Contest_Combos contest_combos { get; set; }
        public Contest_Effect contest_effect { get; set; }
        public Contest_Type contest_type { get; set; }
        public Damage_Class damage_class { get; set; }
        public object effect_chance { get; set; }
        public object[] effect_changes { get; set; }
        public Effect_Entries[] effect_entries { get; set; }
        public Flavor_Text_Entries[] flavor_text_entries { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public object[] machines { get; set; }
        public Meta meta { get; set; }
        public string name { get; set; }
        public Name[] names { get; set; }
        public object[] past_values { get; set; }
        public int power { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public object[] stat_changes { get; set; }
        public Super_Contest_Effect super_contest_effect { get; set; }
        public Target target { get; set; }
        public Type type { get; set; }

        internal static Moves GetMoves(int id)
        {
            string json = new WebClient().DownloadString($"https://pokeapi.co/api/v2/move/{id}");
            Moves move = JsonConvert.DeserializeObject<Moves>(json);
            return move;
        }
    }

    public class Contest_Combos
    {
        public Normal normal { get; set; }
        public Super super { get; set; }
    }

    public class Normal
    {
        public object use_after { get; set; }
        public Use_Before[] use_before { get; set; }
    }

    public class Use_Before
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Super
    {
        public object use_after { get; set; }
        public object use_before { get; set; }
    }

    public class Contest_Effect
    {
        public string url { get; set; }
    }

    public class Contest_Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Damage_Class
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Meta
    {
        public Ailment ailment { get; set; }
        public int ailment_chance { get; set; }
        public Category category { get; set; }
        public int crit_rate { get; set; }
        public int drain { get; set; }
        public int flinch_chance { get; set; }
        public int healing { get; set; }
        public object max_hits { get; set; }
        public object max_turns { get; set; }
        public object min_hits { get; set; }
        public object min_turns { get; set; }
        public int stat_chance { get; set; }
    }

    public class Ailment
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Super_Contest_Effect
    {
        public string url { get; set; }
    }

    public class Target
    {
        public string name { get; set; }
        public string url { get; set; }
    }


    public class Effect_Entries
    {
        public string effect { get; set; }
        public Language language { get; set; }
        public string short_effect { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Flavor_Text_Entries
    {
        public string flavor_text { get; set; }
        public Language1 language { get; set; }
        public Version_Group version_group { get; set; }
    }

    public class Language1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

 
    public class Name
    {
        public Language2 language { get; set; }
        public string name { get; set; }
    }

    public class Language2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

}
