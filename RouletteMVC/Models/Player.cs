using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteMVC.Models
{
    public class Player
    {
        public int Money { get; set; }

        public Player(int Money)
        {
            this.Money = Money;
        }
    }
}
