using System.Collections.Generic;
using Types;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Attribute : MonoBehaviour
{
    public string title = "NULL";
    public short health = 50;
    public bool isDead = false;
    public short mana = 20;
    public bool myTurn = false;
    public List<Effect> effectList; //special Effects
    public List<DamageType> resistList; //resist against taken Damages
    public List<DamageType> weaknessList; //vulnarable against taken Damages
    public List<DamageType> buffList; //buffed given Damages
    public List<DamageType> deBuffList; //debuffed given Damages
    void Start()
    {
        health = 50;
        isDead = false;
        mana = 20;
        myTurn = false;
        effectList = new List<Effect>();
        resistList = new List<DamageType>();
        weaknessList = new List<DamageType>();
        buffList = new List<DamageType>();
        deBuffList = new List<DamageType>();
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public bool TakeDamage(short damage, DamageType damageType)
    {
        health -= FinalDamage(damage, damageType);
        if (health <= 0)
        {
            isDead = true;
            return isDead;
        }
        return isDead;
    }
    public short FinalDamage(short damage, DamageType damageType)
    {
        if (resistList.Contains(damageType) && !weaknessList.Contains(damageType))
        {
            return (short)(damage / 2);
        }
        return damage;
    }
    public bool GetHeal(short heal)
    {
        if (effectList.Find(x => x.effectType == EffectType.HealImmune) != null)
        {
            health = (short)math.min((heal + health), 75);
            return true;
        }
        return false;
    }
    public void RegenHealth()
    {
        health = 50;
    }
    public void RegenMana()
    {
        mana = 50;
    }
    public void GetMana(short regenerated)
    {
        mana = (short)math.min((mana + regenerated), 75);
    }
    public bool AddDeBuff(DamageType deBuffedDmgType)
    {
        if (deBuffList.Contains(deBuffedDmgType))
        {
            return false;
        }
        deBuffList.Add(deBuffedDmgType);
        return true;
    }
    public bool AddBuff(DamageType buffedDmgType)
    {
        if (buffList.Contains(buffedDmgType))
        {
            return false;
        }
        buffList.Add(buffedDmgType);
        return true;
    }
    public bool AddResistance(DamageType resistedDmgType)
    {
        if (resistList.Contains(resistedDmgType))
        {
            return false;
        }
        resistList.Add(resistedDmgType);
        return true;
    }
    public bool AddWeakness(DamageType weaknedDmgType)
    {
        if (weaknessList.Contains(weaknedDmgType))
        {
            return false;
        }
        weaknessList.Add(weaknedDmgType);
        return true;
    }
    public bool AddEffect(Effect effect)
    {
        if (effectList.Contains(effect))
        {
            return false;
        }
        effectList.Add(effect);
        return true;
    }
}
