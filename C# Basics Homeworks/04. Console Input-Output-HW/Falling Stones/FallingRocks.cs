using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FallingStones
{
    struct Object
    {
        public int row;
        public int col;
        public string str;
        public ConsoleColor color;
    }
    class FallingRocks
    {
        static void PrintOnPosition(int col, int row, string objects, ConsoleColor color = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(objects);
        }
        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 25;
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            int playerField = 20;
            int livesCount = 2;
            int playerPoints = 0;
            int roundsCounter = 0;
            int threadSpeed = 150;

            Random randomNumbers = new Random();

            Object dwarf = new Object();
            dwarf.col = playerField / 2 - 1;
            dwarf.row = Console.WindowHeight - 1;
            dwarf.str = "(0)";
            dwarf.color = ConsoleColor.Black;
            PrintOnPosition(dwarf.col, dwarf.row, dwarf.str, dwarf.color);
            List<Object> objects = new List<Object>();

            string[] enemys = { "@", "*", "+", "-", "^", "&", "%", "!", "#", "$", ".", ";", "++", "--" };
            string[] colorNames = {"Black", "Cyan", "Green", "Magenta",  
                                    "DarkBlue", "DarkCyan", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow"};

            //Console.BufferHeight = 300;
            //foreach (string color in colorNames)
            //{
            //    Console.WriteLine(color);    
            //}
            //Console.ReadLine();
            while (true)
            {

                // stoneGenerator = -1 = empty row  stoneGenerator = 0-3 = 1 to 4 stones per row
                int stoneGenerator = randomNumbers.Next(-1, 4);
                // random col
                int colGenerator = randomNumbers.Next(0, playerField);
                // Choosing random color . it is -1 beacuse last color in the array is white and the console is white so the item will not be seen
                string colorName = colorNames[randomNumbers.Next(colorNames.Length)];
                // chance to get life or enemys
                int chance = randomNumbers.Next(0, 100);
                // if the row is not empty
                if (stoneGenerator != -1)
                {
                    // 3% chance to generate row with Life on it
                    if (chance < 4)
                    {
                        Object livePlus = new Object();
                        livePlus.col = colGenerator;
                        livePlus.row = 0;
                        livePlus.str = "L";
                        livePlus.color = ConsoleColor.Red;
                        objects.Add(livePlus);
                    }
                    else
                    {
                        for (int i = 0; i <= stoneGenerator; i++)
                        {
                            int enemysGenerator = randomNumbers.Next(enemys.Length);
                            Object enemyObjects = new Object();
                            enemyObjects.col = colGenerator;
                            enemyObjects.row = 0;
                            enemyObjects.str = enemys[enemysGenerator];
                            enemyObjects.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                            objects.Add(enemyObjects);
                        }
                    }
                }
                // moving the dwarf
                while (Console.KeyAvailable)
                {

                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.col - 1 >= 0)
                        {
                            dwarf.col = dwarf.col - 1;
                            PrintOnPosition(dwarf.col, dwarf.row, dwarf.str, dwarf.color);
                            PrintOnPosition(dwarf.col + 3, dwarf.row, " ");
                        }
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.col + 2 <= playerField)
                        {
                            dwarf.col = dwarf.col + 1;
                            PrintOnPosition(dwarf.col, dwarf.row, dwarf.str, dwarf.color);
                            PrintOnPosition(dwarf.col - 1, dwarf.row, " ");
                        }
                    }
                }

                List<Object> newObjects = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Object oldObject = objects[i];
                    Object newObject = new Object();
                    newObject.col = oldObject.col;
                    newObject.row = oldObject.row + 1;
                    newObject.str = oldObject.str;
                    newObject.color = oldObject.color;
                    if (newObject.row == dwarf.row)  // Points
                    {
                        playerPoints += 10;
                    }
                    if (newObject.str == "L" && newObject.row == dwarf.row && (newObject.col >= dwarf.col && newObject.col <= dwarf.col + 2)) // lives++
                    {
                        livesCount++;
                        if (livesCount >= 5) livesCount = 5;
                    }
                    else if ((newObject.row == dwarf.row && (newObject.col >= dwarf.col && newObject.col <= dwarf.col + 2)) || // check colision with single character stones
                        ((newObject.str == "++" || newObject.str == "--") && (newObject.row == dwarf.row) &&                   // check colision with double character stones
                        (newObject.col + 1 >= dwarf.col && newObject.col + 1 <= dwarf.col + 2)))
                    {
                        playerPoints -= 1000;
                        if (playerPoints <= 0) playerPoints = 0;
                        objects.Clear();
                        livesCount--;
                        threadSpeed = 150;
                        if (livesCount == 0)
                        {
                            PrintOnPosition(25, 15, "GAME OVER", ConsoleColor.Red);
                            PrintOnPosition(25, 10, "Lives :" + livesCount, ConsoleColor.Black);
                            Console.SetCursorPosition(25, 16);
                            Console.ReadLine();
                            return;
                        }
                    }
                    if (newObject.row < Console.WindowHeight)
                    {
                        newObjects.Add(newObject);
                    }
                }
                Console.Clear();
                objects = newObjects;

                // print everything
                PrintOnPosition(dwarf.col, dwarf.row, dwarf.str, dwarf.color);
                foreach (Object obj in objects)
                {
                    PrintOnPosition(obj.col, obj.row, obj.str, obj.color);
                }

                PrintOnPosition(25, 10, "Lives :" + livesCount, ConsoleColor.Black);
                PrintOnPosition(25, 11, "Points : " + playerPoints, ConsoleColor.Black);
                // Press button to reset speed

                roundsCounter++;
                if (playerPoints % 1000 == 0 && playerPoints > 0)
                {
                    threadSpeed -= 5;
                }
                Thread.Sleep(threadSpeed);

            }
        }
    }
}
