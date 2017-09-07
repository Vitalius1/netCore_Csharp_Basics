using System.Collections.Generic;
namespace doc{
    public class Player{
        public string name;
        public List<Card> hand;

        public Player(string person){
            name = person;
            hand = new List<Card>();
        }

        public Card draw(Deck decky){
            Card noob = decky.deal();
            hand.Add(noob);
            return noob;
        }

        public Player draw(Deck decky, int num)
        {
            for(int i = 0; i< num; i++)
            {
                this.draw(decky);
            }
            return this;
        }

        public Card discard(int idx){
            if (idx < 0 || idx > hand.Count){
                System.Console.WriteLine("learn to count");
                return null;
            }
            else{
                Card res = hand[idx];
                hand.RemoveAt(idx);
                return res;
            }
        }
    }
}