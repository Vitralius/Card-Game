using UnityEngine;
using Types;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Card : MonoBehaviour
{
    private string id;
    public string title;
    public string description;
    public bool isUsed;
    public short price;
    public short manaCost;
    public bool isOnBoard;
    public Rarity rarity;
    public Button inspectButton;
    public Button useButton;
    public Card()
    {
        id = "NULL";
        title = "NULL";
        description = "NULL";
        price = 0;
        rarity = Rarity.Default;
        isUsed = false;
        isOnBoard = false;
        inspectButton.interactable = false;
        useButton.interactable = false;
    }
    public Card(string id, string title, string description, short price, short manaCost, Rarity rarity)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.price = price;
        this.manaCost = manaCost;
        this.rarity = rarity;
        this.isUsed = false;
        this.isOnBoard = false;
        this.inspectButton.interactable = true;
        this.useButton.interactable = false;
    }
    public void Inspect()
    {
        isOnBoard = true;
    }
    public bool IsOnBoard()
    {
        return isOnBoard;
    }
    public void Return()
    {
        isOnBoard = false;
    }
    public void UseCard()
    {
        isUsed = true;
        inspectButton.interactable = false;
        useButton.interactable = false;
        isOnBoard = false;
    }
    public string getID()
    {
        return id;
    }
}
