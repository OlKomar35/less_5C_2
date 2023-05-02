//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateArray(int lengthArray, int start, int finish){
    int [] array = new int[lengthArray];
    for(int i=0; i<lengthArray;i++){
        array[i] = new Random().Next(start,finish+1);
    }
return array;
}

void SumOfElementsWithOddIndex(int [] array){
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if(index % 2 == 0 ) sum+=array[index];
    }
    Console.WriteLine($"Сумма чисел с нечетным индексом = {sum}");
}

void PrintArray(int [] array){
    Console.Write("[");
    for(int i=0;i<array.Length;i++){
        if(i!=array.Length-1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]}]");
    }
}

Console.Write("Введите длину массива N=");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапозона min=");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите окончание диапазона max=");
int max = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateArray(lengthArr,min,max);
PrintArray(arr);
SumOfElementsWithOddIndex(arr);

