using UnityEngine;
public class ArenaManager : MonoBehaviour
{
    public GameObject firstOpponent;
    public GameObject secondOpponent;
    private Attribute fstOppAttribute;
    private Attribute scndOppAttribute;
    private DeckManager deckManager;
    public short turnCount;
    void Start()
    {
        fstOppAttribute = firstOpponent.GetComponent<Attribute>();
        scndOppAttribute = secondOpponent.GetComponent<Attribute>();
        deckManager = GetComponent<DeckManager>();
        turnCount = 1;
        if (Random.Range(0, 2) == 1)
        {
            fstOppAttribute.myTurn = true;
        }
        else
        {
            scndOppAttribute.myTurn = false;
        }
    }
    public void UseSpellCard(SpellCard spellCard)
    {
        if (fstOppAttribute.myTurn)
        {
            ApplyEffectOn(spellCard, fstOppAttribute, scndOppAttribute);
            deckManager.UseCard(spellCard, firstOpponent);
            TurnController();
        }
        else
        {
            ApplyEffectOn(spellCard, scndOppAttribute, fstOppAttribute);
            deckManager.UseCard(spellCard, secondOpponent);
            TurnController();
        }
    }
    public void TurnController()
    {
        if (fstOppAttribute.mana! > 0)
        {
            fstOppAttribute.myTurn = false;
            NextTurn();
        }
        if (scndOppAttribute.mana !> 0)
        {
            scndOppAttribute.myTurn = true;
            NextTurn();   
        }
    }
    public void NextTurn()
    {
        turnCount++;
        fstOppAttribute.RegenMana();
        scndOppAttribute.RegenMana();
        
    }
    public void ApplyEffectOn(SpellCard spellCard, Attribute current, Attribute target)
    {
        if (spellCard is SpellCardDamage damageCard)
        {
            damageCard.ApplyEffect(target);
        }
        else if (spellCard is SpellCardBuff buffCard)
        {
            buffCard.ApplyEffect(target);
        }
        else if (spellCard is SpellCardDebuff debuffCard)
        {
            debuffCard.ApplyEffect(target);
        }
        else if (spellCard is SpellCardHeal healCard)
        {
            healCard.ApplyEffect(target);
        }
        else if (spellCard is SpellCardEffect effectCard)
        {
            effectCard.ApplyEffect(target);
        }
    }
}
