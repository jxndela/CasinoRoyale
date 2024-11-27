using SamplePlugin;
using static CasinoRoyale.Data.Card;
namespace CasinoRoyale.Data;

public enum BlackjackActions
{
    None,
    Hit,
    Bust,
    Stay,
    Split,
    Blackjack,
    Surrender,
    DoubleDown
}

public class BlackjackPlayer
{
    public readonly string Name;
    public readonly bool IsSplit;

    public bool CanSplit;
    public bool IsAlive = true;
    public BlackjackActions LastAction = BlackjackActions.None;

    public int Bet;
    public readonly List<Card> Cards = new(); // Cards in hand

    public BlackjackPlayer(string name, int bet)
    {
        Bet = bet;
        Name = name;
    }

    // Constructor for when player splits
    public BlackjackPlayer(BlackjackPlayer player)
    {
        Bet = player.Bet;
        Name = $"{player.Name} Split";
        IsSplit = true;
    }

    // Calculate total value of cards in hand
    public int CalculateCardValues()
    {
        var totalValue = 0;
        var hasAce = false;
        foreach (var card in Cards)
        {
            totalValue += card.Value;
            if (card.IsAce)
                hasAce = true;
        }
        // If there is no ace, return total value
        if (!hasAce)
        {
            return totalValue;
        }
        else // has ace
        {
            // If total value is less than 11, ace is worth 11
            if (totalValue - 1 < 11)
            {
                return totalValue + 10;
            }
            // If total value is 11 or more, ace is worth 1
            else
            {
                return totalValue;
            }
        }
    }

}

public class Blackjack
{
    private readonly Plugin Plugin; // Reference to plugin
    public BlackjackPlayer Dealer = new BlackjackPlayer("Dealer", 0);
    public List<BlackjackPlayer> Players = new(); // List of players
    public int CurrentPlayerIndex = 0; // Index of current player
    public BlackjackPlayer CurrentPlayer => Players[CurrentPlayerIndex]; // Current player

    // constructor to pass reference to plugin
    public Blackjack(Plugin plugin)
    {
        Plugin = plugin;
    }

    

}