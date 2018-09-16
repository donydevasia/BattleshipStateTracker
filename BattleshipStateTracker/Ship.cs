using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipStateTracker
{
    //Ship is the abstract form of ships.there are 5 types of ships. Carrier with 5 squares, Battleship(4), Cruiser(3), Submarine(3), Destroyer(2)
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Squares { get; set; }
    }

    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Carrier";
            Squares = 5;
        }
    }

    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            Squares = 4;
        }
    }

    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Name = "Cruiser";
            Squares = 3;
        }
    }

    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            Squares = 3;
        }
    }

    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            Squares = 2;
        }
    }
}
