using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public GameObject firstOpponent;
    public GameObject secondOpponent;
    private Deck fstOppDeck;
    private Deck scndOppDeck;
    void Start()
    {
        fstOppDeck = firstOpponent.GetComponent<Deck>();
        scndOppDeck = secondOpponent.GetComponent<Deck>();
    }
    public void RemoveCard(SpellCard usedCard, GameObject user)
    {
        user.GetComponent<Deck>().Remove(usedCard);
    }
    public void UseCard(SpellCard usedCard, GameObject user)
    {
        user.GetComponent<Deck>().UseCard(usedCard);
    }
}
