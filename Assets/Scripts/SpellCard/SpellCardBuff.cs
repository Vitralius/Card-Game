using UnityEngine;
using Types;
public class SpellCardBuff : SpellCard
{
    public DamageType buffedDamageType;
    //public short damageFactor;
    public SpellCardBuff(string id, string title, string description, short price, short manaCost, Rarity rarity, DamageType buffedDamageType) : base(id, title, description, price, manaCost, rarity, SpellType.Buff)
    {
        this.buffedDamageType = buffedDamageType;
    }
    public bool ApplyEffect(Attribute currentAttribute)
    {
        if ((int) buffedDamageType != (int) DamageType.Default) 
        {
            if (currentAttribute.AddDeBuff(buffedDamageType))
            return true; //buff is done
        }
        return false; //if current already has that buff, buff is not done
    }
}
