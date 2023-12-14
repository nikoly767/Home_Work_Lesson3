/*Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [20,90]. */

int[] array = {10, 25, 33, 91, 45, 46};
int number = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 20 && array[i] < 90) {

        number = number + 1;
    }
}

Console.Write(number);