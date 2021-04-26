using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerCharacterClasses
{
    Assassin, Barbarian, Berserker, Minstrel, Necromancer, Pactmaker, Paladin, Pyromancer, Rogue,
    Warlock 
}
public enum PlayerCharacterRaces { Dwarf, Elf, Human, Orc }
public enum PlayerCharacterFactions { Annexors, Erusguud, Falthlar, Greycloaks, Kamraeia, Ravenskull }

[CreateAssetMenu(fileName = "New Player", menuName = "Cards/Creatures/Player")]
public class PlayerCreatureCardObject : CreatureCardObject 
{
    // private int _MAX_LEVEL = 20;
    public int level = 0;
    public int xp = 0;
    public int rank = 0;
    public int prestige = 0;

    public PlayerCharacterClasses charClass;  // need to make a <T> type CharClass
    public PlayerCharacterRaces charRace;   // need to make a <T> type CharRace
    public PlayerCharacterFactions charFaction;    // need to make a <T> type CharFaction

    private new void Start() {
        creatureType = CreatureType.Player;
    }

    //call this method when gaining XP
    private void LevelUp()
    {
        if (this.xp >= RecursiveAddition(level) * 100)
        {
            this.level = level + 1;
            this.xp = 0;
        }
    }

    private int RecursiveAddition(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            int factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial + i;
            }
            return factorial;
        }
    }
}