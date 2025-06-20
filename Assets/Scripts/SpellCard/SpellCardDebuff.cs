using UnityEngine;
using Types;
public class SpellCardDebuff : SpellCard
{
    public DamageType deBuffedDmgType;
    public SpellCardDebuff(string id, string title, string description, short price, short manaCost, Rarity rarity, DamageType deBuffedDmgType = DamageType.Default) : base(id, title, description, price, manaCost, rarity, SpellType.DeBuff)
    {
        this.deBuffedDmgType = deBuffedDmgType;
    }
    public bool ApplyEffect(Attribute enemyAttribute)
    {
        if ((int) deBuffedDmgType != (int) DamageType.Default) 
        {
            if (enemyAttribute.AddDeBuff(deBuffedDmgType))
            return true; //debuff is done
        }
        return false; //if enemy already has that deBuff, debuff is not done
    }
}
