using UnityEngine;

namespace Types
{
    public enum Rarity
    {
        Common = 1,
        Advenced = 2,
        Uncommon = 3,
        Rare = 4,
        Epic = 5,
        Legendary = 6,
        Default = 7,
    }
    public enum SpellType
    {
        Damage = 1,
        Heal = 2,
        Buff = 3,
        DeBuff = 4,
        Effect = 5,
        Default = 6,
    }
    public enum EffectType
    {
        HealImmune = 1,
        Default
    }
    public enum DamageType
    {
        Fire = 1, //Fire + Earth does both types of damages
        Water = 2,
        Earth = 3, //Fire + Earth does both types of damages
        Air = 4,
        Ice = 5, //Water + Earth
        Lightning = 6, //Fire + Air
        Poision = 7, //Water + Air
        Antimatter = 8, //Fire + Water || Earth + Air
        Physical = 9,
        Piercing = 10,
        Bludgeoning = 11,
        Slashing = 12,
        Default = 13,
    }
}