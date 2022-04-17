using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Discard
    {
        public List<Card> Pile { get; }
        public Discard()
        {
            Pile = new List<Card>();

            Card card;
            do
            {
                card = new Card();
            }
            while (card.isWild());

            Pile.Add(card); // First Card In Pile set
        }

        public void Play(Card playedCard, Player player)
        {
            if (isValidPlay(playedCard))
            {
                player.Remove(playedCard);
                Pile.Add(playedCard);
            }
            else
            {
                throw new Exception("Invalid Card Played.");
            }
        }

        private bool isValidPlay(Card card)
        {
            Card faceCard = Pile.Last();

            return card.isWild() || faceCard.FaceValue == card.FaceValue || faceCard.Color == card.Color;
        }
    }
}
