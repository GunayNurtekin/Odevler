using System;

namespace Soru10;

public class Character
{
    public Character(string? characterName, int characterHealth)
    {
        CharacterName = characterName;
        CharacterHealth = characterHealth;
    }

public string? CharacterName { get; set; }
public int CharacterHealth { get; set; }
}
