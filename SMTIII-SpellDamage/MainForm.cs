using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SMTIII_SpellDamage
{
    public partial class MainForm : Form
    {
        private List<Spell> spells = new SpellList().List;
        private Spell currentSpell = new Spell();

        private const double damageMultiplier = 0.004;

        public MainForm()
        {
            InitializeComponent();
            SelectedSpell.Items.AddRange(spells.Select(x => x.Name).ToArray());
            SelectedSpell.SelectedIndex = 0;
        }

        private void SetSpell()
        {
            //Set the spell from the list and write values in boxes
            currentSpell = spells.First(x => x.Name == SelectedSpell.Text);
            PowerBox.Text = currentSpell.Power.ToString();
            LimitBox.Text = currentSpell.Limit.ToString();
            CorrectionBox.Text = currentSpell.Correction.ToString();
            PeakBox.Text = currentSpell.Peak.ToString();
        }

        private void SetGraph()
        {
            //Write values to the graph using the currently selected spell
            DamageChart.Series.Clear();
            Series series = CreateGraphData();
            DamageChart.Series.Add(series);
            //Adjust graph values that don't auto-adjust properly...
            DamageChart.ChartAreas[0].AxisX.Minimum = 1;
            int max = (int)series.Points.Max(x => x.YValues[0]);
            DamageChart.ChartAreas[0].AxisY.Maximum = max + (10 - (max % 10)); //Set Y max to the nearest multiple of 10 above the highest damage value
        }

        private Series CreateGraphData()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Name = "Damage";
            //Levels in SMT III go from 1 to 255 (Although only up to level 99 is displayed in menus)
            //However every value after 160 will be the same, so just cap it off at 171 for nicer visuals
            for (int i = 1; i <= 201; i++)
            {
                double damage = CalculateDamage(i);
                series.Points.Add(new DataPoint(i, damage));
            }
            return series;
        }

        private double CalculateDamage(int level)
        {
            int magic = (int)MagicStat.Value;
            double damage = 0;
            if (level < currentSpell.Peak)
            {
                //Consider magic stat but with a detriment from level
                double magicComponent = 5 * (magic + 36) - level;
                //Level is also considered here as a multiplier, making it a net positive, i.e. damage goes up with level instead of down
                double powerComponent = 24.0 * currentSpell.Power * (level / 255.0) + currentSpell.Correction;
                //Multiply components together with a small constant
                damage = damageMultiplier * magicComponent * powerComponent;
            }
            else if (level == currentSpell.Peak)
            {
                //Level no longer subtracting from damage
                double magicComponent = 5 * (magic + 36);
                //This formula considers the peak before rounding
                double rawPeak = (currentSpell.Limit - currentSpell.Correction) / (double)currentSpell.Power; //Calculate a peak value using the spell's params
                double adjustedPeak = rawPeak * (255.0 / 24); //Multiply it by a constant value
                //Subtract the peak from the magic and round
                double rawDamage = Math.Floor(magicComponent - adjustedPeak);
                //Multiply that by the same small constant as before and the spell's limit value
                damage = damageMultiplier * rawDamage * currentSpell.Limit;
            }
            else if (currentSpell.Peak < level && level <= 160)
            {
                //Now, level purely a detriment to damage
                double rawDamage = 5 * (magic + 36) - level;
                damage = damageMultiplier * rawDamage * currentSpell.Limit;
            }
            else //Level > 160
            {
                //Level's detriment to damage caps out at level 160
                double rawDamage = 5 * (magic + 36) - 160;
                damage = damageMultiplier * rawDamage * currentSpell.Limit;
            }
            return damage;
        }

        private void SelectedSpell_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSpell();
            SetGraph();
        }

        private void MagicStat_ValueChanged(object sender, EventArgs e)
        {
            MagicStatBar.Value = (int)MagicStat.Value;
            SetGraph();
        }

        private void MagicStatBar_Scroll(object sender, EventArgs e)
        {
            MagicStat.Value = MagicStatBar.Value;
            SetGraph();
        }
    }
}
