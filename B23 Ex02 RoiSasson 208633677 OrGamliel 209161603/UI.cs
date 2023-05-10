using System;

public class UI
{
    public int boardSize = 5;
    public void UserInterface()
    {
        string[] rows = { "1", "2", "3", "4", "5" };
        string[] cols = { "1", "2", "3", "4", "5" };

        Console.Write(" ");
        foreach (string col in cols)
        {
            Console.Write(" " + col + " ");
        }
        Console.WriteLine();

        foreach (string row in rows)
        {
            Console.Write(row);
            foreach (string col in cols)
            {
                Console.Write("|  ");
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("======================");
        }

    }
}