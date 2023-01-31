using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTIII_SpellDamage
{
    class SpellList
    {
        public List<Spell> List { get; set;}

        public SpellList()
        {
            List = new List<Spell>()
            {
                //        Name                  Power   Limit   Correction
                new Spell("Agi",                37,     104,    10),
                new Spell("Maragi",             30,     85,     9),
                new Spell("Agilao",             55,     155,    16),
                new Spell("Maragion",           45,     126,    13),
                new Spell("Agidyne",            75,     220,    20),
                new Spell("Maragidyne",         65,     183,    19),
                new Spell("Fire Breath",        30,     85,     8),
                new Spell("Hellfire",           50,     140,    14),
                new Spell("Prominence",         90,     253,    26),
                new Spell("Hell Burner",        30,     85,     9),
                new Spell("Ragnarok",           80,     800,    20),
                new Spell("Magma Axis",         48,     470,    14),
                new Spell("Bufu",               30,     85,     9),
                new Spell("Mabufu",             20,     56,     6),
                new Spell("Bufula",             45,     126,    13),
                new Spell("Mabufula",           25,     98,     10),
                new Spell("Bufudyne",           65,     183,    19),
                new Spell("Mabufudyne",         55,     155,    16),
                new Spell("Ice Breath",         25,     70,     7),
                new Spell("Glacial Blast",      65,     183,    19),
                new Spell("Zio",                30,     85,     9),
                new Spell("Mazio",              20,     56,     6),
                new Spell("Zionga",             45,     126,    13),
                new Spell("Mazionga",           35,     98,     10),
                new Spell("Ziodyne",            65,     183,    19),
                new Spell("Maziodyne",          55,     155,    16),
                new Spell("Shock",              25,     70,     7),
                new Spell("Bolt Storm",         65,     183,    19),
                new Spell("Roundtrip",          55,     155,    16),
                new Spell("Mishaguji Raiden",   55,     155,    16),
                new Spell("Zan",                37,     104,    10),
                new Spell("Mazan",              30,     85,     9),
                new Spell("Zanma",              55,     155,    16),
                new Spell("Mazanma",            45,     126,    13),
                new Spell("Zandyne",            75,     220,    20),
                new Spell("Mazandyne",          65,     183,    19),
                new Spell("Wing Buffet",        30,     85,     8),
                new Spell("Tornado",            65,     183,    19),
                new Spell("Wind Cutter",        90,     330,    26),
                new Spell("Hell Exhaust",       40,     112,    11),
                new Spell("Wet Wind",           65,     200,    20),
                new Spell("Whirlwind",          65,     183,    19),
                new Spell("Hitokoto Storm",     65,     183,    19),
                new Spell("Deathtouch",         30,     84,     10),
                new Spell("Mana Drain",         15,     42,     2),
                new Spell("Life Drain",         30,     84,     8),
                new Spell("Meditation",         60,     84,     8),
                new Spell("Megido",             70,     197,    20),
                new Spell("Megidola",           80,     225,    23),
                new Spell("Megidolaon",         90,     253,    26),
                new Spell("Pestilence",         50,     120,    12),
                new Spell("Beast Roar",         80,     225,    23),
                new Spell("Showtime",           90,     253,    26),
                new Spell("Jiraiya Dance",      90,     253,    26),
                new Spell("Fire of Sinai",      90,     253,    26),
                new Spell("Death Flies",        90,     253,    26),
                new Spell("Violet Flash",       75,     220,    20),
                new Spell("Radiance",           75,     211,    21),
                new Spell("Hell Gaze",          50,     140,    14),
            };   
        }
    }
}
