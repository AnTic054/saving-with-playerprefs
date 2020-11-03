using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsList
{

        public ClassBuilder pirate = new ClassBuilder("Pirate", 20, 16, 6, 11, 3);
        public ClassBuilder knight = new ClassBuilder("Knight", 18, 16, 10, 8, 3);
        public ClassBuilder sellsword = new ClassBuilder("Sell Sword", 13, 9, 20, 6, 6);
        public ClassBuilder darkMage = new ClassBuilder("Dark Mage", 9, 7, 9, 1, 20);
}

public class ClassBuilder
{
    public string name;
    public int health;
    public int strength;
    public int dexterity;
    public int light;
    public int dark;

    public ClassBuilder(string Name,int Health,int Strength,int Dexterity,int Light,int Dark)
    {
        this.name = Name;
        this.health = Health;
        this.strength = Strength;
        this.dexterity = Dexterity;
        this.light = Light;
        this.dark = Dark;
    }
}
