namespace Lektion15.Classes;

public class Card
{
    public int Value { get; init; }
    public Suits Suit { get; set; }
    public Card(int value, Suits suit) => (Value, Suit) = (value, suit);
}
