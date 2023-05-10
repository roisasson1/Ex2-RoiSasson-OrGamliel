using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B23_Ex02_RoiSasson_208633677_OrGamliel_209161603
{
    enum cellStatus
    {
        empty,
        player1Symoble,
        player2Symoble
    }

    internal class Board
    {
        public int boardSize = 5; // change it to user interface
        cellStatus[,] board;
        public Board(int boardSize)
        {
            board = new cellStatus[boardSize, boardSize];
        }
    }
}
