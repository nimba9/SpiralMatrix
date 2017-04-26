using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp06ex18SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive number: ");
            string userInp = Console.ReadLine();

            int num = 0;

            bool checkInput = int.TryParse(userInp, out num);

            if (checkInput != true)

            {
                Console.WriteLine("Your entry is not valid");
            }

            int row = 0;
            int column = 0;
            int[,] table = new int[num, num];
            string direction = "right";

            int maxvalue = num * num;

            for (int start = 1; start <= maxvalue; start++)
            {
                if (direction == "right" && (column > num - 1 || table[row, column] != 0))
                {
                    direction = "down";
                    column--;
                    row++;
                 
                }

                if (direction == "down" && (row > num - 1 || table[row, column] != 0))
                {
                    direction = "left";
                    column--;
                    row--;
                
                }

                if (direction == "left" && (column < 0 || table[row, column] != 0))
                {
                    direction = "up";
                    column++;
                    row--;
                 
                }

                if (direction == "up" && (row < 0 || table[row, column] != 0))
                {
                    direction = "right";
                    column++;
                    row++;
                 }

                table[row, column] = start;

                switch (direction)
                {
                    case "right":
                    column++;
                    break;

                    case "down":
                    row++;
                    break;

                    case "left":
                    column--;
                    break;

                    case "up":
                    row--;
                    break;

                }
              
            }

            
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("{0,4}", table[i,j]);
                }
                Console.WriteLine();

            }

        }
    }
}
 
