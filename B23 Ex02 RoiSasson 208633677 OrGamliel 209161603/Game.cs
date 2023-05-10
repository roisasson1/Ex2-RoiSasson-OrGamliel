using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B23_Ex02_RoiSasson_208633677_OrGamliel_209161603
{
    internal class Game
    {
        UI userInterface = new UI();
        public void game()
        {
            userInterface.UserInterface();
        }
        // Board board = new Board(userInterface.boardSize);
    }
}
