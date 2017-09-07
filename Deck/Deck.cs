using System.Collections.Generic;
using System;

namespace doc{
    public class Deck{
        public List<Card> cards;

        public Deck(){
            reset();
            shuffle();
        }
        public Deck reset(){
            cards = new List<Card>();
            string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
            string[] strVals = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            foreach(string Suit in suits){
                for (int i = 0; i < strVals.Length; i++){
                    Card noob = new Card(strVals[i], Suit, i+1);
                    cards.Add(noob);
                }
            }
            return this;
        }

        public Deck shuffle(){
            Random rand = new Random();
            for (int end = cards.Count -1; end > 0; end--){
                int randx = rand.Next(end);
                Card temp = cards[randx];
                cards[randx] = cards[end];
                cards[end] = temp;
            }
            return this;
        }

        public Card deal(){
            if (cards.Count > 0){
                Card res = cards[0];
                cards.RemoveAt(0);
                return res;
            }
            else{
                reset();
                return deal();
            }
        }
    }
}