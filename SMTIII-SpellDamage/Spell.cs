using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTIII_SpellDamage
{
    class Spell
    {
        public string Name;
        public int Power { get; set; }
        public int Limit { get; set; }
        public int Correction { get; set; }
        public int Peak { get; set; }

        public Spell() { }

        public Spell(string name, int power, int limit, int correction) 
        { 
            Name = name;
            Power = power;
            Limit = limit;
            Correction = correction;
            CalculatePeak();
        }

        private void CalculatePeak()
        {
            double rawPeak = (Limit - Correction) / (double)Power; //Calculate a peak value using the spell's params
            double adjustedPeak = rawPeak * (255.0 / 24); //Multiply it by a constant value
            Peak = (int)Math.Round(adjustedPeak); //Round it to the nearest int (rather than floor)
        }
    }
}
