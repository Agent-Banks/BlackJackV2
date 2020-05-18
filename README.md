# BlackJackV2

# Data Structure

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

# Algorithm

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
