using System;

namespace RouletteMVC.Models
{
    public class Ball
    {
        public int ballLocation { get; }
        public int row { get; set; }
        public Ball()
        {
            Random r = new Random();
            ballLocation = r.Next(1, 39);
            row = Row();

        }

        public int Row()
        {

            if (ballLocation <= 3)
            {
                row = 1;
                return row;
            }

            else if (ballLocation > 3 && ballLocation <= 6)
            {
                row = 2;
                return row;
            }

            else if (ballLocation > 6 && ballLocation <= 9)
            {
                row = 3;
                return row;
            }

            else if (ballLocation > 9 && ballLocation <= 12)
            {
                row = 4;
                return row;
            }

            else if (ballLocation > 12 && ballLocation <= 15)
            {
                row = 5;
                return row;
            }

            else if (ballLocation > 15 && ballLocation <= 18)
            {
                row = 6;
                return row;
            }

            else if (ballLocation > 18 && ballLocation <= 21)
            {
                row = 7;
                return row;
            }

            else if (ballLocation > 21 && ballLocation <= 24)
            {
                row = 8;
                return row;
            }

            else if (ballLocation > 24 && ballLocation <= 27)
            {
                row = 9;
                return row;
            }

            else if (ballLocation > 27 && ballLocation <= 30)
            {
                row = 10;
                return row;
            }

            else if (ballLocation > 30 && ballLocation <= 33)
            {
                row = 11;
                return row;
            }

            else if (ballLocation > 33 && ballLocation <= 36)
            {
                row = 12;
                return row;
            }

            else
            {
                Console.WriteLine("Green Row Wins");
                row = 0;
                return row;
            }
        }
    }
}
