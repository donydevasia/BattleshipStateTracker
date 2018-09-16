using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleshipStateTracker;

namespace BattleshipStateTrackerTest
{
    [TestClass]
    public class StateTrackerTest
    {
        #region Add ships to the board
        [TestMethod]
        public void Carrier_55_Horizontal_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Carrier(), Direction.Horizontal);
            Assert.AreEqual("Carrier placed successfully", message);
        }

        [TestMethod]
        public void Carrier_55_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Carrier(), Direction.Vertical);
            Assert.AreEqual("Carrier placed successfully", message);
        }

        [TestMethod]
        public void Carrier_57_Horizontal_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 7, new Carrier(), Direction.Horizontal);
            Assert.AreEqual("Carrier couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Carrier_75_Vertical_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(7, 5, new Carrier(), Direction.Vertical);
            Assert.AreEqual("Carrier couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Battleship_55_Horizontal_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Battleship(), Direction.Horizontal);
            Assert.AreEqual("Battleship placed successfully", message);
        }

        [TestMethod]
        public void Battleship_55_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Battleship(), Direction.Vertical);
            Assert.AreEqual("Battleship placed successfully", message);
        }

        [TestMethod]
        public void Battleship_58_Horizontal_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 8, new Battleship(), Direction.Horizontal);
            Assert.AreEqual("Battleship couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Battleship_85_Vertical_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(8, 5, new Battleship(), Direction.Vertical);
            Assert.AreEqual("Battleship couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Cruiser_55_Horizontal_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Cruiser(), Direction.Horizontal);
            Assert.AreEqual("Cruiser placed successfully", message);
        }

        [TestMethod]
        public void Cruiser_55_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Cruiser(), Direction.Vertical);
            Assert.AreEqual("Cruiser placed successfully", message);
        }

        [TestMethod]
        public void Cruiser_59_Horizontal_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 9, new Cruiser(), Direction.Horizontal);
            Assert.AreEqual("Cruiser couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Cruiser_95_Vertical_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(9, 5, new Cruiser(), Direction.Vertical);
            Assert.AreEqual("Cruiser couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Submarine_55_Horizontal_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Submarine(), Direction.Horizontal);
            Assert.AreEqual("Submarine placed successfully", message);
        }

        [TestMethod]
        public void Submarine_55_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Submarine(), Direction.Vertical);
            Assert.AreEqual("Submarine placed successfully", message);
        }

        [TestMethod]
        public void Submarine_58_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 8, new Submarine(), Direction.Vertical);
            Assert.AreEqual("Submarine placed successfully", message);
        }

        [TestMethod]
        public void Submarine_95_Vertical_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(9, 5, new Submarine(), Direction.Vertical);
            Assert.AreEqual("Submarine couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Destroyer_55_Horizontal_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Destroyer(), Direction.Horizontal);
            Assert.AreEqual("Destroyer placed successfully", message);
        }

        [TestMethod]
        public void Destroyer_55_Vertical_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 5, new Destroyer(), Direction.Vertical);
            Assert.AreEqual("Destroyer placed successfully", message);
        }

        [TestMethod]
        public void Destroyer_510_Horizontal_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(5, 10, new Destroyer(), Direction.Horizontal);
            Assert.AreEqual("Destroyer couldn't placed successfully since not enough squares on the board", message);
        }

        [TestMethod]
        public void Destroyer_105_Vertical_Failure()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(10, 5, new Destroyer(), Direction.Vertical);
            Assert.AreEqual("Destroyer couldn't placed successfully since not enough squares on the board", message);
        }
        
        [TestMethod]
        public void Add_All_Ships_Success()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(1, 5, new Battleship(), Direction.Horizontal);
            message = stateTracker.AddShip(1, 2, new Cruiser(), Direction.Vertical);
            message = stateTracker.AddShip(6, 6, new Submarine(), Direction.Horizontal);
            message = stateTracker.AddShip(4, 7, new Destroyer(), Direction.Vertical);
            Assert.AreEqual("Destroyer placed successfully", message);
        }

        [TestMethod]
        public void Add_Ships_Failure_Overlap_1()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(3, 3, new Battleship(), Direction.Vertical);
            Assert.AreEqual("Battleship couldn't be placed successfully since there is an overlap with another ship", message);
        }

        [TestMethod]
        public void Add_Ships_Failure_Overlap_2()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(4, 2, new Battleship(), Direction.Horizontal);
            Assert.AreEqual("Battleship couldn't be placed successfully since there is an overlap with another ship", message);
        }
        #endregion

        #region Take attack
        [TestMethod]
        public void TakeAttack_Hit()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(1, 5, new Battleship(), Direction.Horizontal);
            message = stateTracker.AddShip(1, 2, new Cruiser(), Direction.Vertical);
            message = stateTracker.AddShip(6, 6, new Submarine(), Direction.Horizontal);
            message = stateTracker.AddShip(4, 7, new Destroyer(), Direction.Vertical);
            message = stateTracker.TakeAttack(1, 2);
            Assert.AreEqual("Hit", message);
        }

        [TestMethod]
        public void TakeAttack_Miss()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(1, 5, new Battleship(), Direction.Horizontal);
            message = stateTracker.AddShip(1, 2, new Cruiser(), Direction.Vertical);
            message = stateTracker.AddShip(6, 6, new Submarine(), Direction.Horizontal);
            message = stateTracker.AddShip(4, 7, new Destroyer(), Direction.Vertical);
            message = stateTracker.TakeAttack(1, 1);
            Assert.AreEqual("Miss", message);
        }

  
        [TestMethod]
        public void TakeAttack_All_Ships_Sunk()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(1, 5, new Battleship(), Direction.Horizontal);
            message = stateTracker.AddShip(1, 2, new Cruiser(), Direction.Vertical);
            message = stateTracker.AddShip(6, 6, new Submarine(), Direction.Horizontal);
            message = stateTracker.AddShip(4, 7, new Destroyer(), Direction.Vertical);
            message = stateTracker.TakeAttack(1, 2);
            message = stateTracker.TakeAttack(2, 2);
            message = stateTracker.TakeAttack(3, 2);
            message = stateTracker.TakeAttack(1, 5);
            message = stateTracker.TakeAttack(1, 6);
            message = stateTracker.TakeAttack(1, 7);
            message = stateTracker.TakeAttack(1, 8);
            message = stateTracker.TakeAttack(3, 3);
            message = stateTracker.TakeAttack(4, 3);
            message = stateTracker.TakeAttack(5, 3);
            message = stateTracker.TakeAttack(6, 3);
            message = stateTracker.TakeAttack(7, 3);
            message = stateTracker.TakeAttack(6, 6);
            message = stateTracker.TakeAttack(6, 7);
            message = stateTracker.TakeAttack(6, 8);
            message = stateTracker.TakeAttack(4, 7);
            message = stateTracker.TakeAttack(5, 7);
            Assert.AreEqual("Hit. All ships sunk", message);
        }


        [TestMethod]
        public void TakeAttack_All_Ship_Sunk_Bruteforce()
        {
            IStateTracker stateTracker = new StateTracker();
            string message = stateTracker.AddShip(3, 3, new Carrier(), Direction.Vertical);
            message = stateTracker.AddShip(1, 5, new Battleship(), Direction.Horizontal);
            message = stateTracker.AddShip(1, 2, new Cruiser(), Direction.Vertical);
            message = stateTracker.AddShip(6, 6, new Submarine(), Direction.Horizontal);
            message = stateTracker.AddShip(4, 7, new Destroyer(), Direction.Vertical);

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    message = stateTracker.TakeAttack(i, j);
                    if (message.Contains("All ships sunk"))
                    {
                        Assert.AreEqual("Hit. All ships sunk", message);
                        break;
                    }
                        
                }
            }
                        
        }
        #endregion
        //invalid range for adding ships
        //invalid range for taking attack
    }
}
