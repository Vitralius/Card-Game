using UnityEngine;
using Types;
using System.Collections.Generic;
public class Deck : MonoBehaviour
{
    List<Card> deck;
    public short cardCount;
    public void Remove(Card card)
    {
        deck.Remove(card);
    }
    public void UseCard(Card card)
    {
        deck.Find(x => x.getID() == card.getID()).UseCard();
    }
}
