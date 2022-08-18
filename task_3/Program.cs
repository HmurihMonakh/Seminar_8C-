/*Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза*/


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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
    }
}

void ChangeArray(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int t = matr[0,j];
        matr[0,j]=matr[matr.GetLength(0)-1,j];
        matr[matr.GetLength(0)-1,j]=t;
    }
}


var x = new HashSet<int>() { 2, 3, 4 };
Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m,n];
FillArray (array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
ChangeArray(array);
Console.WriteLine("Образованный массив: ");
PrintArray(array);







