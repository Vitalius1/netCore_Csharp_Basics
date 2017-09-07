namespace doc{
    public class Card{
        public string stringVal;
        public string suit;
        public int val;

        public Card(string name, string suitType, int value){
            stringVal = name;
            suit = suitType;
            val = value;
        }
    }
}