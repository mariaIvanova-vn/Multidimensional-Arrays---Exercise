using System;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            FillMatrix(matrix);
            int removedKnightsCount = 0;


            while (true)
            {
                int maxAttack = 0;
                int rowAttackIndex = 0;
                int colAttackIndex = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == '0')
                        {
                            continue;
                        }

                        int currentAttacks = 0;

                        if (isInRange(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (isInRange(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (currentAttacks > maxAttack)
                        {
                            maxAttack = currentAttacks;
                            rowAttackIndex = row;
                            colAttackIndex = col;
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    matrix[rowAttackIndex, colAttackIndex] = '0';
                    removedKnightsCount++;
                }
                else
                {
                    Console.WriteLine(removedKnightsCount);
                    break;
                }
            }       
    }

        private static bool isInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
