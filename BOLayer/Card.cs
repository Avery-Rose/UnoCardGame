using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Card
    {
        static Random random = new Random();
        public bool wild { get; }
        /// <summary>
        /// Constructs a Card by passing the facevalue and color
        /// </summary>
        /// <param name="newColor"></param>
        /// <param name="newValue"></param>
        public Card()
        {
            // The random min value is INCLUSIVE, and the max value is EXLUSIVE
            Color color = (Color)random.Next(0, 4);

            FaceValue face;

            if (random.Next(0, 14) == 0)
            {
                wild = true;
                face = random.Next(0, 2) == 0 ? FaceValue.ChangeColor : FaceValue.Draw;
            }
            else
            {
                int num = random.Next(0, 13);
                face = (FaceValue)num;
            }

            Color = color;
            FaceValue = face;
        }

        public bool isWild()
        {
            return wild;
        }

        /// <summary>
        /// Gets the color of the card
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// Gets the FaceValue of the card
        /// </summary>
        public FaceValue FaceValue { get; }
    }
}
