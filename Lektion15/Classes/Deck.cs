using Lektion15.Exceptions;

namespace Lektion15.Classes;

public enum Suits
{
    All, Hearts, Spades, Diamonds, Clubs

}

public class Deck
{
    List<Card> _cards = new();
    //List<string> _suits = new() { "", "", "", "" };
    public List<Card> Cards { get; private set; } = new();

    public Deck()
    {
        CreateDeck();
    }

    public void CreateDeck()
    { 
        try
        {
            foreach (var suit in Enum.GetValues<Suits>())
                if(suit != Suits.All)
                    for (int i = 2; i <= 14; i++)
                        _cards.Add(new Card(i, suit));
        }
        catch
        {
            throw;
        }
    }

    /*public void Get(string suit)
    {
        Cards.Clear();
            
        if (suit == string.Empty) Cards.AddRange(_cards);

        Cards.AddRange(_cards.Where(s => s.Suit == suit));
    }*/

    public void Get(Suits suit)
    {
        Cards.Clear();

        if (suit == Suits.All) Cards.AddRange(_cards);

        Cards.AddRange(_cards.Where(s => s.Suit == suit));
    }

    public void Get(Func<Card, bool>? lamda) //lamda är detta: s => s.Suit == suit
    {
        Cards.Clear();

        if (lamda is null)
        {
            Cards.AddRange(_cards);
            return;
        }

        Cards.AddRange(_cards.Where(lamda));
    }

    public Card? Single(Func<Card, bool>? lamda)
    {
        if (lamda is null) return null;

        try
        {
            return _cards.Single(lamda); 
        }
        catch 
        {
            throw new CardException("Card not found.");
        }
    }
}
