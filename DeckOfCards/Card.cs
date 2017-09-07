public class Card{
    public string stringVal;
    public string suit;
    public int val;

    public Card(string cardSuit, int numVal){
        suit = cardSuit;
        val = numVal;
        if (numVal >1 && numVal < 11){
            stringVal = numVal.ToString();
        }
        else if (numVal == 11){
            stringVal = "Jack";
        }
        else if (numVal == 12){
            stringVal = "Queen";
        }
        else if (numVal == 13){
            stringVal = "King";
        }
        else if (numVal == 1){
            stringVal = "Ace";
        }
        else{
            stringVal = "Joker";
        }
    }
}