namespace CasinoRoyale.Data;

public class Card
{
    public readonly int Value; 
    public readonly bool isAce;

    // Default constructor
    public Card()
    {
        Value = 0;
        isAce = false;
    }
    // Overloaded constructor
    public Card(int aNumber, bool anAce)
    {
        Value = aNumber;
        isAce = anAce;
    }

    // Get value of the card for calculations
    // Returns int (true value of card)
    public int getValue(int aNumber)
    {
        if (aNumber == 1) return 11; // can be 1 in game logic we'll see
        if (aNumber > 10) return 10; // Face cards
        return aNumber;
    }

    // returns card value as a string. Should only be used during initial draws. 
    public string getValueString (int aNumber)
    {
        if (aNumber == 1) return "1/11";
        if (aNumber > 10) return "10";
        return number.ToString(aNumber);
    }

    // Determines if the card is an Ace
    // Returns a bool, true means it is an Ace, false means it is not an Ace
    public bool getAce(int aNumber)
    {
        if (aNumber == 1) return true;
        return false;
    }

    

}
