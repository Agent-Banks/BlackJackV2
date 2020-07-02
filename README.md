# SDG Assignment #4 : 01 - 04 - Blackjack

![BlackJack Demo](SDG-GIFS/BlackJack.gif)

In this project, you are creating a playable game of
[Blackjack](https://en.wikipedia.org/wiki/Blackjack). If you haven't played this
game ever, or in a while, grab a deck of cards and play a few games.

## Objectives

- Practice the skills and ideas you have learned so far.
- Effectively use loops, conditionals, and other control structures to implement
  [control flows](https://en.wikipedia.org/wiki/Control_flow)
- Demonstrate usage of data structures to model resources.

## Requirements

Create a single-player blackjack game that plays against the house, i.e., a
human player and computer dealer. You are free to create the user interface
however you want, **but keep it simple for Explorer Mode**.

### Explorer Mode

General Rules:

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

### Adventure Mode

- [ ] Reveal one of the house's cards to the player when cards dealt.
- [ ] Consider aces be worth one _or_ eleven.
- [ ] Allow the player to
      ["Split"](https://blog.betway.com/casino/blackjack-strategy-101-how-do-you-split-in-blackjack/).
- [ ] Improve the win requirements. From Wikipedia:
  > Players win by not busting and having a total higher than the dealer, or not
  > busting and having the dealer bust, or getting a blackjack without the
  > dealer getting a blackjack. If the player and dealer have the same total
  > (not counting blackjacks), this is called a "push," and the player typically
  > does not win or lose money on that hand. Otherwise, the dealer wins.

### Epic Mode

- [ ] Add a betting system that carries between rounds.
- [ ] Allow the player to "Double down" or "Surrender."
- [ ] Add more players.


# PEDAC Approach
## Data Structure

​
The following Nouns exist in the description of the "P"roblem:
​

- Deck
- Card
- Hand
- Player
- Dealer
  ​
  These have the following STATE (properties) and BEHAVIOR (methods)
  ​
- Deck
  ​
  - Properties: A list of 52 cards
  - Behavior: Make a new deck of 52 shuffled cards. Deal one card out of the deck.
    ​
- Card
  ​
  - Properties: The Face of the card, the Suit of the card
  - Behavior: The Value of the card according to the table in the "P"roblem part
    ​
- Hand
  ​
  - Properties: A list of individual Cards
  - Behavior: a TotalValue representing the sum of the individual Cards in the list. Add a card to the hand
    ​
- Player
  ​
  - Properties: a single Hand
    ​
- Dealer
  ​
  - Properties: a single Hand
    ​
- Game
  - Properties: the Dealer, the Player, the Deck
  - Behavior: Play
    ​
    Notes: Since the Player and the Dealer just have one property we may not need those and we could skip them and just use the Hand.
    ​
    Notes: We might put all the logic for the game into a `Game` class and have it be able to play.
    ​

## Algorithm

​

1. Create a new deck
2. Ask the deck to make a new shuffled 52 cards
3. Create a player hand
4. Create a dealer hand
5. Ask the deck for a card and place it in the player hand
6. Ask the deck for a card and place it in the player hand
7. Ask the deck for a card and place it in the dealer hand
8. Ask the deck for a card and place it in the dealer hand
9. Show the player the TotalValue of their Hand
10. If they have BUSTED, then goto step 15
11. Ask the player if they want to HIT or STAND
12. If HIT
    ​

- Ask the deck for a card and place it in the player hand
- goto step 10
  ​

13. If STAND continue on
14. Show the dealer's hand TotalValue
15. If the dealer has busted then goto step 17
16. If the dealer has less than 17
    - Ask the deck for a card and place it in the dealer hand
    - goto step 14
17. If the player busted show "COMPUTER WINS"
18. If the dealer busted show "PLAYER WINS"
19. If the dealer's hand is more than the player's hand then show "DEALER WINS", else show "PLAYER WINS"
20. -- Hmm, what to do if they are even?
21. Ask the user if they want to play again.
    ​

- If yes, goto step 1
  ​

22. Show the user "Thanks for playing"
