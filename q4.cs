using System;

class Program
{
    // This method takes two matrices as parameters and returns their sum
    // It assumes that the matrices have the same size
    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        // Get the number of rows and columns of the matrices
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        // Create a new matrix to store the sum
        int[,] sum = new int[rows, cols];

        // Loop through the elements of the matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Add the corresponding elements and store in the sum matrix
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Return the sum matrix
        return sum;
    }

    // This method prints a matrix to the console
    static void PrintMatrix(int[,] matrix)
    {
        // Get the number of rows and columns of the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Loop through the elements of the matrix
        for (int i = 0; i < rows; i++)
        {
            // Start a new line for each row
            Console.WriteLine();
            for (int j = 0; j < cols; j++)
            {
                // Print each element with a space
                Console.Write(matrix[i, j] + " ");
            }
        }
        // Print an empty line after the matrix
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Ask the user for the number of rows and columns of the matrices
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());