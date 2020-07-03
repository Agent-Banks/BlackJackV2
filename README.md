# SDG Assignment #4 : 01 - 04 - Blackjack

Create a single-player blackjack game that plays against the house, i.e., a
human player and computer dealer.

![BlackJack Demo](https://github.com/codyb23/SDG-GIFS/blob/master/BlackJack.gif)

## Technologies used:
.NET 4.7, C#

## General Rules:

- [x] The game should be played with a standard deck of playing cards (52).
- [x] The house should be dealt two cards, hidden from the player until the
      house reveals its hand.
- [x] The player should be dealt two cards, visible to the player.
- [x] The player should have a chance to hit (i.e. be dealt another card) until
      they decide to stop or they _bust_ (i.e. their total is over 21). At which
      point they lose regardless of the dealer's hand.
- [x] When the player stands, the house reveals its hand and hits (i.e. draw
      cards) until they have 17 or more.
- [x] If dealer goes over 21 the dealer loses.

- [x] The player should have two choices: "Hit" and "Stand."
- [x] Consider Aces to be worth 11, never 1.
- [x] The app should display the winner. For this mode, the winner is who is
      closer to a blackjack (21) without going over.
- [x] There should be an option to play again; this should reset the hands and
      reshuffle the deck.
