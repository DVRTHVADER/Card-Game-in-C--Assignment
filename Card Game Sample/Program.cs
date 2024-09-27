// See https://aka.ms/new-console-template for more information

using Card_Game_Sample_INF1035;

CardDeck deck = new CardDeck();

// Display each card in the deck
foreach (Card Card in deck.Card)
{
    Console.WriteLine(Card);
}