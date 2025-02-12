// See https://aka.ms/new-console-template for more information
/**
using Cards2;

Card card1= new Card(Rank.Jack, Suit.Diamonds);

Deck deck = new Deck();
deck.Shuffle();
for(int x = 1; x <=5; x++ ) {
card1 = deck.TakeTopCard();
Console.WriteLine("Card "+ x +": " + (int)card1.Rank + "-" +(int)card1.Suit);
}
**/
using System;
using Cards2;

// loop while there's more input
while(true)
{
string input = Console.ReadLine();
 if (string.IsNullOrEmpty(input)) // exit loop if input is empty
    {
        break;
    }

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();

Card[] player1 = new Card[5]; //array for player1 hand max 5 cards
Card[] player2 = new Card[5];
Card[] player3 = new Card[5];
Card[] player4 = new Card[5];

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
for (int round = 0; round < 2; round++)
{
    player1[round] = deck.TakeTopCard();
    player2[round] = deck.TakeTopCard();
    player3[round] = deck.TakeTopCard();
    player4[round] = deck.TakeTopCard();
}

// deal 1 more card to players 2 and 3
player2[2] = deck.TakeTopCard();
player3[2] = deck.TakeTopCard();


// flip all the cards over - consider using foreach in update
for (int round =0; round <2 ; round++) //for hands with 2 cards
{
    if (player1[round].FaceUp==false)
    {
        player1[round].FlipOver();
    }

    if (player4[round].FaceUp==false)
    {
        player4[round].FlipOver();
    }
}

for (int round =0; round <3 ; round++) //for hands with 3 cards
{
    if (player2[round].FaceUp==false)
    {
        player2[round].FlipOver();
    }

    if (player3[round].FaceUp==false)
    {
        player3[round].FlipOver();
    }
}


// print the cards for player 1
Console.WriteLine("Player 1 Hand:");
for (int round = 0; round < 2; round++)
{
Console.WriteLine(" Card " + (round+1) +"-" + player1[round].Rank +" "+player1[round].Suit); 
}

// print the cards for player 2
Console.WriteLine("Player 2 Hand:");
for (int round = 0; round < 3; round++)
{
Console.WriteLine(" Card " + (round+1) +"-" + player2[round].Rank +" "+player2[round].Suit); 
}

// print the cards for player 3
Console.WriteLine("Player 3 Hand:");
for (int round = 0; round < 3; round++)
{
Console.WriteLine(" Card " + (round+1) +"-" + player3[round].Rank +" "+player3[round].Suit); 
}

// print the cards for player 4
Console.WriteLine("Player 4 Hand:");
for (int round = 0; round < 2; round++)
{
Console.WriteLine(" Card " + (round+1) +"-" + player4[round].Rank +" "+player4[round].Suit); 
}

}