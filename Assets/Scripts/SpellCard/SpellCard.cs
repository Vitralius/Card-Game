using UnityEngine;
using Types;
public class SpellCard : Card
{
    public SpellType spellType;
    public SpellCard(string id, string title, string description, short price, short manaCost, Rarity rarity, SpellType spellType) : base(id, title, description, price, manaCost, rarity)
    {
        this.spellType = spellType;
    }
    public virtual void ApplyEffect() { Debug.Log("Parent SpellCard Called!"); }
}
