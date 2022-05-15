using System;

namespace Hilo_Game
{
    public class Card
    {
        public int value = 0;
        public Card()
        {
            Random randomGenerator = new Random();
            value = randomGenerator.Next(1,13);
        }
    }
}
