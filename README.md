# SMTIII-SpellDamage
This is a small tool which graphs damage as your level increases for Shin Megami Tensei III: Nocturne.

## Why?

SMTIII: Nocturne has some interesting formulae. There are five stats in the game:
* Strength
* Vitality
* Magic
* Agility
* Luck

The popular opinion of fans is that **three of these fives stats** are borderline useless.

Luck does not apply to crit rate, likelihood to inflict ailments, or item drop rates, and the things it does apply to it does so minimally. 
For the miscellaneous formulae that luck plays a part in, your results can be increased more effectively by investing in other stats.

Agility is fine for the most part, except for the big formula: Hit/dodge chance. As the player's level increases, their chance to hit or dodge decreases,
making investing in agility feel like a Sisyphean task of trying to outpace the deterioration.

And finally, magic, which is the most complicated to describe its awfulness. Basically, each spell has a "Peak" value, determined by three parameters of the spell:
Power, Limit, and Correction. There are four different formulas for spell damage, and which one is selected depends on the relation between the player's level and this
peak value. For the vast majority of spells in the game, the peak value is 26-28.

As the player's level approaches the peak value, the spell gradually does more and more damage **(Formula 1)**, 
until doing its maximum possible damage when the player's level is equal to the peak value **(Formula 2)**.
Then, **Formula 3** kicks in and it starts deteriorating, as the player's level *starts subtracting from spell damage*. This means that for every level you gain
after 28, your spells become more and more useless, and there's nothing you can do about it besides use the 2 spells which have a peak value in the hundreds.
Finally, the deterioration maxes out at level 160, when **Formula 4** is used.

For exact details on how these formulas are calculated, check out the [CalculateDamage function in Mainform.cs](SMTIII-SpellDamage/MainForm.cs#L66)

## Program Features

This program allows you to select almost any spell in the game, except:
* Those which do not have a Limit or Correction value (For the most part, these are spells which have a chance of dealing instant death instead of doing damage).
* Those which deal a specified proportion of the target's HP.

The spell's Power, Limit, Correction, and calculated Peak will then be displayed.

You may also set the player's Magic stat, which ranges from 1 to 40. The default value is the maximum, 40.

A graph will then be displayed which shows the selected spell's damage as the player's level increases.
In SMTIII, the player's level ranges from 1 to 255, although only up to level 99 is displayed in the menus.
However, since spell damage no longer changes after 160, the graph stops going past 201 (which was chosen for visual reasons.)

You will notice a sharp linear increase until the peak value is reached, at which point the damage begins a gradual linear decrease,
before finally resting on a static value at level 160.

![image](https://user-images.githubusercontent.com/30701749/215744058-461b0678-9408-4382-8cc5-a0a532b8ce7b.png)

## Notable Files

[Mainform.cs](SMTIII-SpellDamage/MainForm.cs) contains most of the program logic, including the damage calculation functions.

[Spell.cs](SMTIII-SpellDamage/Spell.cs) is a simple class which stores information about a spell, includes the Peak calculation function.

[SpellList.cs](SMTIII-SpellDamage/SpellList.cs) contains the list of all valid spells in the game and their Power, Limit, and Correction values.

## Credits

References for the exact formulae and spell parameters, as well as some of the explanation on what makes the game's formulae kind of terrible, 
came from [this Steam thread](https://steamcommunity.com/sharedfiles/filedetails/?id=2503470293).

Massive thanks to Sabaca for creating the thread.
