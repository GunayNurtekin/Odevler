using System;

namespace Soru10;

public class Mage : Character
{
    public Mage(string? characterName, int characterHealth, string? specialMove) : base(characterName, characterHealth)
    {
        SpecialMove = specialMove;
    }
    public string? SpecialMove { get; set; }

     public void Attacking() 
    {
        System.Console.WriteLine($"{CharacterName} adindaki savaşçi , {CharacterHealth} puan cani var ve {SpecialMove} özel saldirisini kullaniyor.");
    }

}
