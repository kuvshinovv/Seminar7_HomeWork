//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/* double[,] CreateRandom2DArray(int rows, int cols, double min, double max){
    double[,] array = new double[rows, cols];
    for(int i = 0 ; i <rows; i++){
        for(int j = 0; j<cols; j++){
            array[i,j] = Math.Round(new Random().NextDouble()*(max-min)+min, 1, MidpointRounding.AwayFromZero);
        }   // т.к. NextDouble() генерирует числа от 0 до 1, то такая форма записи NextDouble()*(max-min)+min 
            //позволяет раздвинуть диапазон от введенного минимума до введённого максимума. 
            //Потом я округлил чтобы программа не показывала число с 13 знаками после запятой.
    }
    return array;
}

void Show2dArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input numb of max: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] array = CreateRandom2DArray(rows, cols, min, max);

Show2dArray(array);
 */









//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2DArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for(int i = 0 ; i <rows; i++){
        for(int j = 0; j<cols; j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}



void ShowSrednee(int[,] array){
    
    double srednee = 0;
    Console.Write($"Среднее арифметическое ");
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {   
        for ( int cols = 0; cols < array.GetLength(1); cols++)
        {
            if (rows==cols){
            srednee = srednee + array[rows,cols];

             Console.Write($" "+srednee+"  ");
            }
        }
    }
}


Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(rows, cols, min, max);

Show2dArray(array);
Console.WriteLine();
ShowSrednee(array);