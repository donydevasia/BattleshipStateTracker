using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipStateTracker
{
    public enum Direction
    {
        Vertical, Horizontal
    };

    public interface IStateTracker
    {
        string AddShip(int rowNum, int colNum, Ship ship, Direction direction);
        string TakeAttack(int rowNum, int colNum);
    }

    public class StateTracker:IStateTracker
    {
        //data structure representing 10x10 board. for each square, 1 is assigned for Ship, -1 is assigned for Hit, 0 default value
        private int[,] _state = new int[10, 10];
        //counter of used squares on the board. it helps to know when all ships are sunk
        private int _numberOfUsedSquares;

        /* 
         * Adds ship to the board. 
         * rowNum represents row from 1 to 10(assumed to be translated from A to J)
         * colNum represent column from 1 to 10
         * ship is the abstract form of ships. there are 5 types of ships. Carrier with 5 squares, Battleship(4), Cruiser(3), Submarine(3), Destroyer(2)
         * direction is either horizontal or vertical
         * returns a message with ship name whether placed on the board or not
         */
        public string AddShip(int rowNum, int colNum, Ship ship, Direction direction)
        {
            int endPosition;

            //range validation
            if (!(rowNum >= 1 && rowNum <= 10) || !(colNum >= 1 && colNum <= 10))
                return "Row and Column numbers are invalid";
            
            //mark squares by incrementing column by the number of squares the ship has
            if (direction == Direction.Horizontal)
            {
                endPosition = colNum + ship.Squares - 1;
                //overlaps edge of the board
                if(endPosition > 10)
                {
                    return ship.Name + " couldn't placed successfully since not enough squares on the board";
                }
                for (int i = colNum - 1; i < endPosition; i++)
                {
                    //overlaps with another ship
                    if (_state[rowNum - 1, i] == 1)
                    {
                        return ship.Name + " couldn't be placed successfully since there is an overlap with another ship";
                    }
                    _state[rowNum - 1, i] = 1;
                    _numberOfUsedSquares++;
                }
            }
            //mark squares by incrementing row by the number of squares the ship has
            else if (direction == Direction.Vertical)
            {
                endPosition = rowNum + ship.Squares - 1;
                //overlaps edge of the board
                if (endPosition > 10)
                {
                    return ship.Name + " couldn't placed successfully since not enough squares on the board";
                }
                for (int i = rowNum - 1; i < endPosition; i++)
                {
                    //overlaps another ship
                    if(_state[i, colNum - 1] == 1)
                    {
                        return ship.Name + " couldn't be placed successfully since there is an overlap with another ship";
                    }
                    _state[i, colNum - 1] = 1;
                    _numberOfUsedSquares++;
                }
            }
            return ship.Name + " placed successfully";
        }

        /*
         * Takes attack from the opponent
         * input is row number and column number
         * returns whether hit or miss. if all ships are sunk, returns that information
         */
        public string TakeAttack(int rowNum, int colNum)
        {
            //range validation
            if (!(rowNum >= 1 && rowNum <= 10) || !(colNum >= 1 && colNum <= 10))
                return "Row and Column numbers are invalid";

            //hit
            if (_state[rowNum - 1, colNum - 1] == 1)
            {
                _state[rowNum - 1, colNum - 1] = -1;
                _numberOfUsedSquares--;
                if(_numberOfUsedSquares == 0)
                    return "Hit. All ships sunk";
                else
                    return "Hit";
            }
            //hit already
            if (_state[rowNum - 1, colNum - 1] == -1)
            {
                if (_numberOfUsedSquares == 0)
                    return "Hit. All ships sunk";
                else
                    return "Hit";
            }
            //miss
            else
            {
                return "Miss";
            }
        }
    }
}
