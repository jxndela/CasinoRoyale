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
    // Returns int 
    public getValue(int aNumber)
    {
        if (aNumber == 1) return 11; // can be 1 in game logic we'll see
        if (aNumber > 10) return 10; // Face cards
        return aNumber;
    }
}
