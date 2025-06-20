using System.Data.Common;
using UnityEngine;
using Types;

public class SpellCardDamage : SpellCard
{
    public DamageType damageType;
    public short damage;
    public SpellCardDamage(string id, string title, string description, short price, short manaCost, Rarity rarity, short damage, DamageType damageType) : base(id, title, description, price, manaCost, rarity, SpellType.Damage)
    {
        this.damage = damage;
        this.damageType = damageType;
    }
    public bool ApplyEffect(Attribute enemyAttribute)
    {
        if (enemyAttribute.TakeDamage(damage, damageType)) //if health is not equal or less than 0
        {
            return false; //returns isDead attribute in logic
        }
        return true;
    }
}
