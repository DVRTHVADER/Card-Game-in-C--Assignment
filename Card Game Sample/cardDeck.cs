namespace Card_Game_Sample_INF1035;
/*  Displays colors of cards to be selected from
return type --> enum*/
public enum CardColor
{
    Trefle,
    Carreau,
    Coeur,
    Pique
}

/*  Displays Value of cards to be selected from
return type --> enum*/
public enum CardValue
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13
}

/*  Associate each Effect to a given card
return type --> enum*/
public enum Effects
{
    None = 0,   // Default for non-special cards
    Skip = 1,   // Ace
    Reverse = 10, // Ten
    DrawTwo = 7 // Seven
}


/*  This presents the Deck of 52 card to be shuffled
from which the Cards are chosen to be shared and drawn from
return type --> Stack
Parameters Cards*/
public class CardDeck
{
    //Public card variable
    public Stack <Card> Card { set; get; }

    
    //Creates card deck from Stack of cards.
    public CardDeck()
    {
        Card = new Stack<Card>();

        foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
        {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                  /*  switch (val)
                    {
                        case CardValue.Ace:
                        case CardValue.Two:
                        case CardValue.Three:
                        case CardValue.Four:
                        case CardValue.Five:
                        case CardValue.Six:
                        case CardValue.Seven:
                        case CardValue.Eight:
                        case CardValue.Nine:
                        case CardValue.King:
                        case CardValue.Queen:
                        //Add two copies of each color card 1-9
                        Card.Push(new Card()
                        {
                            Color = color,
                            Value = val,
                            Score = (int)val
                        });
                        Card.Push(new Card()
                        {
                            Color = color,
                            Value = val,
                            Score = (int)val
                        });
                        break;
                        case Effects.Skip:
                        case Effects.Reverse:
                        case Effects.DrawTwo:
                    }*/
                  Effects effect = DetermineEffect(value); // Check for special card effects

                  // Add a copie of each card for this specific card game
                  Card.Push(new Card(color, value, effect));
                  
                }
        }
    }

    // Method to determine if a card has any special effects
    private Effects DetermineEffect(CardValue value)
    {
        switch (value)
        {
            case CardValue.Ace:
                return Effects.Skip;
            case CardValue.Seven:
                return Effects.DrawTwo;
            case CardValue.Ten:
                return Effects.Reverse;
            default:
                return Effects.None; // Default for non-special cards
        }
    }

            

    
    
    
}