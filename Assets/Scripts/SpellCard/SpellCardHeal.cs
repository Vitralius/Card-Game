using UnityEngine;
using Types;

public class SpellCardHeal : SpellCard
{
    public short heal;
    public SpellCardHeal(string id, string title, string description, short price, short manaCost, Rarity rarity, short heal) : base(id, title, description, price, manaCost, rarity, SpellType.Heal)
    {
        this.heal = heal;
    }
    public bool ApplyEffect(Attribute currentAttribute)
    {
        if (currentAttribute.GetHeal(heal)) //if is not affected by heal immune
        {
            return true; //heal is done
        }
        return false;
    }
}
