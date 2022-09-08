
/* int[,] CreateRandom2DArray(int rows, int cols, int min, int max){
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
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(0); j++)
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
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(rows, cols, min, max);

Show2dArray(array);

 */









//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

 /* int[,] CreateRandom2DArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0 ; i <m; i++){
        for(int j = 0; j<n; j++){
            array[i,j] = i+j;
        }
    }
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}

Console.Write("Input numb of m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of n: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2DArray(m, n);
Show2dArray(array);
  */







//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
 /*  int[,] CreateRandom2DArray(int rows, int cols, int min, int max){
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
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}


int[,] Calculate(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i%2==0 && j%2==0){
                    array[i,j] *= array[i,j];
                }
            }
        }
    return array;
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
Calculate(array);
Console.WriteLine();
Show2dArray(array); 
 */
 









//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/* 
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
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}


int CalcSumDiagonal(int[,] array){
    int sum = 0;
    if(array.GetLength(0)==array.GetLength(1) ){
        for (int i = 0; i < array.GetLength(0); i++)
        {   Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i==j) sum += array[i,j];
            }
        }
    }
    return sum;
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

int sum = CalcSumDiagonal(array);
Console.WriteLine("Sum of numb on main is: "+sum);
 */





// ***Дан двумерный массив. Поменять местами:
//а) элементы, расположенные в правом верхнем и левом нижнем углах;
//б) элементы, расположенные в правом нижнем и левом верхнем углах.


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
    {   Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
    }
}


int[,] Calculate(int[,] array){    
      for (int i = 0; i <= array.GetLength(0)-1; i++)
        {   
            for (int j = 0; j <= array.GetLength(1)-1; j++)
            {
                int temp = array[0,array.GetLength(1)-1];
                array[0,array.GetLength(1)-1] = array[array.GetLength(0)-1,0];
                array[array.GetLength(0)-1,0] = temp;
                
                int temp2 = array[0,0];
                array[0,0] = array[array.GetLength(0)-1,array.GetLength(1)-1];
                array[array.GetLength(0)-1,array.GetLength(1)-1] = temp2;
            }
        }               
    return array;
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
Calculate(array);
Console.WriteLine();
Show2dArray(array);  