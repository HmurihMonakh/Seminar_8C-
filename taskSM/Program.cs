// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

// int[,] array = GetArray(2, 10);
// PrintArray(array);
// Console.WriteLine("=============");
// PrintArray(ArrayTurn(array));


// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] GetArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// int[,] ArrayTurn(int[,] array)
// {

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int t = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = t;
//     }

//     return array;
// }




////////////////////////**второй вариант**


// int rows = 5, cols = 4;
// var array = GetDoubleArray(cols,rows,0,10);
// ViewDablArray(array);
// var result = RevertFirsNLastCols(array);
// Console.WriteLine();
// ViewDablArray(result);

// object[,] RevertFirsNLastCols(object[,] collection){
//     object[,] result = new object[collection.GetLength(0),collection.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             if (i == 0) result[i,j] = collection[collection.GetLength(0)-1,j];
//             else if (i == collection.GetLength(0)-1)  result[i,j] = collection[0,j];
//             else result[i,j] = collection[i,j];
//         }
//     }
//     return result;
// }

//////////////////////////////////////////////////////////////
// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

//**неправильный код надо переделать**

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int colums = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, colums, 0, 9);

// PrintArray(array);
// Console.WriteLine();
// if (array.GetLength(0) == array.GetLength(1))
//     {
//     int[,] array1 = ChangeRowsColums(array);
//     PrintArray(array1);
//     }
// else Console.WriteLine ("Ошибка");
// int rows = 5, cols = 5;
// var array = GetDoubleArray(cols, rows, 0, 10);
// if (rows != cols) Console.WriteLine("Невозможно заменить строки на столбцы с текущими параметрами двумерного массива");
// else
// {
//     ViewDablArray(array);
//     Console.WriteLine();
//     var result = RevertArray(array);
//     Console.WriteLine();
//     ViewDablArray(result);

// }

// object[,] RevertArray(object[,] collection)
// {
//     object[,] result = new object[collection.GetLength(0), collection.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = collection[j, i];
//         }
//     }
//     return result;
// }


////**подсказка проверки по дз**

// do
//                 {
//                     int x =new Random().Next(0,100);
//                     collection [i,j,y] = numbers[x];
//                     numbers[x] = 0;
//                 } while (collection[i,j,y] == 0);







// Задача 59: Отсортировать нечетные столбцы массива по возрастанию. 
// Вывести массив изначальный и массив с отсортированными нечетными столбцами

// int[,] sort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)// идем по строкам
//     {
//         if (i % 2 == 1)
//         {
//             int min = array[0,i];
//             for (int j = 0; j < array.GetLength(0); j++)// идем по столбцам
//             {
//                 if (array[i,j] < min)
//                 {
//                     int temp = min;
//                     min = array[i,j];
//                     array[i,j] = min;
//                 }

//             }
//         }
//     }
// }





///////////////////////////////////////////////////////////


// using System;
// using System.Text;

// class Program
// {

//     static string BuildArrayString(int[][] array, int numLength)
//     {
//         var result = new StringBuilder();
//         int length = array.GetLength(0);

//         for (int i = 0; i < length; i++)
//         {
//             foreach (var num in array[i])
//                 result.Append(num.ToString().PadLeft(numLength));
//             result.AppendLine();
//         }

//         return result.ToString();
//     }

//     static void Main()
//     {
//         const int arrayLength = 5;
//         const int maxNumber = 10;
//         const int numLength = 3;

//         var random = new Random();
//         var array = new int[arrayLength][];

//         for (int i = 0; i < arrayLength; i++)
//         {
//             array[i] = new int[arrayLength];
//             for (int k = 0; k < arrayLength; k++)
//                 array[i][k] = random.Next(maxNumber);
//         }

//         Console.WriteLine(BuildArrayString(array, numLength));
//         Console.Write("Нажмите любую клавишу для сортировки...");
//         Console.ReadKey(true);
//         Console.SetCursorPosition(0, 0);

//         for (int i = 0; i < arrayLength; i++)
//         {
//             Array.Sort(array[i]);
//             if (i % 2 == 1)
//                 Array.Reverse(array[i]);
//         }

//         Console.WriteLine(BuildArrayString(array, numLength));
//         Console.Write($"Укажите номер столбца для вывода (с 1 по {arrayLength}): ");

//         int numCollumn;
//         if (int.TryParse(Console.ReadLine(), out numCollumn) && numCollumn > 0 && numCollumn <= arrayLength)
//         {
//             numCollumn--;
//             Console.Write("Результат: ");
//             for (int i = 0; i < arrayLength; i++)
//                 Console.Write(array[i][numCollumn].ToString().PadLeft(numLength));
//             Console.WriteLine();
//         }
//         else
//             Console.WriteLine("Указано недопустимое значение!");

//         Console.WriteLine();
//         Console.Write("Нажмите любую клавишу для выхода...");
//         Console.ReadKey(true);
//     }
// }










