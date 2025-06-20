using UnityEngine;
using Types;
public class SpellCardEffect : SpellCard
{
    public Effect effect;
    public SpellCardEffect(string id, string title, string description, short price, short manaCost, Rarity rarity, Effect effect) : base(id, title, description, price, manaCost, rarity, SpellType.Effect)
    {
        this.effect = effect;
    }
    public bool ApplyEffect(Attribute targetAttribute)
    {
        if (targetAttribute.AddEffect(effect))
        {
            return true; //effect is done
        }
        return false; //if target already has that effect, effect is not done
    }
}
