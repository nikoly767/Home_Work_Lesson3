/* Задайте массив на 10 целых чисел. 
Напишите программу, которая определяет количество чётных чисел в массиве.   */

int[] array = {3, 4, 5, 8, 7, 2, 2, 6};
int number = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        number = number + 1;
    }

}

Console.Write(number);