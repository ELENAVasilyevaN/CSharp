﻿//
// string[,] table = new string[2, 5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] table [0,4]
// // table [1,0] table [1,1] table [1,2] table [1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"−{table[rows, columns]}−");
//     }
// }



// 2. Задали матрицу 3 на 4
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine( );
// }



// 3. Задали матрицу 3 на 4 и выводим на печать


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4]; // можно оставить в строке к примеру 32, здесь спустили для более скомпанованного видения кода

// PrintArray(matrix);





// 4. Задали матрицу 3 на 4 и выводим на печать и заполняем случайными числами


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr) //заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //в некс реально полуинтервал [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4]; // можно оставить в строке к примеру 32, здесь спустили для более скомпанованного видения кода

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // пробел между матрицами
PrintArray(matrix);
