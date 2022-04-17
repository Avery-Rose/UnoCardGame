using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Player
    {
        public List<BOLayer.Card> hand { get; set; }

        public Player()
        {
            hand = new List<BOLayer.Card>();
            // generate hand
            for (int i = 0; i <= 7; i++)
            {
                Add(new Card());
            }
        }

        public void Add(Card c)
        {
            hand.Add(c);
        }

        public void Remove(Card c)
        {
            if (hand.Contains(c))
            {
                hand.Remove(c);
            }
            else
            {
                throw new Exception("Card Doesn't exist in hand");
            }
        }

        private int HandCount()
        {
            return hand.Count;
        }

        public void Play(Card card)
        {

        }
    }
}
