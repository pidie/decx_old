using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CreatureType { Boss, Companion, Minion, Player }
public enum CreatureActionTypes
{
    Bash, Bite, Burrow, Cleave, ChillingHowl, DoubleTap, Maim, Maul, Pummel, Rend, Ritual__Gravedigger,
    Strike, ToxicStrike
}
public enum RaceCategoryTypes { Beast, Celestial, Faeroid, Synthetic, Tellusi, Undead }
public enum SubraceBeastCategoryTypes { Bear, Cat, Crustacean, Dog, Dragon, Insect, Jellyfish, Lizard, Mollusk, Primate, Raptor, Rodent, Shark, Snake, Spider, Wolf, Worm }
public enum SubraceCelestialCategoryTypes { Angel, Cherub, Host, Nefilim, Sanctir, Seraph }
public enum SubraceFaeroidCategoryTypes { Carnomaw, Cthulli, Demon, Djinix, Jyant, Pixie, Warvol }
public enum SubraceSyntheticCategoryTypes { Automaton, Construct, Cyborg, Golem, Homonculus, Mechanism }
public enum SubraceTellusiCategoryTypes { Aelfaen, Cyanite, Darkling, Driad, Dwarf, Elf, Goblin, Grokkin, Human, Orc, Pygmeri, Troll, Vesper }
public enum SubraceUndeadCategoryTypes { Abhoration, Disembodied, Lich, Phantom, Skeleton, Vampire, Zombie }

public abstract class CreatureCardObject : CardObject 
{
    public CreatureType creatureType;
    
    [Header("Creature Information")]
    public int health = 0;
    public int damage = 0;
    public int armor = 0;

    public string creatureRace;
    public string creatureSubRace;

    public bool affectLOS = true;
    public bool isUnique = false;

    public List<string> buffs;  // will have to make a <T> type StatusEffects

    public void Awake() 
    {
        cardType = CardType.Creature;
    }
}