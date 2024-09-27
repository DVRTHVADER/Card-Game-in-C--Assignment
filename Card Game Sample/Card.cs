namespace Card_Game_Sample_INF1035;

public class Card
{
    public CardValue Value { get; set; }
    public CardColor Color { get; set; }
    public Effects Effect { get; set; }
    public int Score { get; set; }
    
    public Card(CardColor color, CardValue value, Effects effect = Effects.None)
    {
        Color = color;
        Value = value;
        Effect = effect;
        Score = (int)value; // Default score equals card value
    }

    // Helper to display card information
    public override string ToString()
    {
        return $"{Value} of {Color} (Effect: {Effect})";
    }
}
