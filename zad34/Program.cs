// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int kol = 0;
int[] array = new int[n];
// Рандомный ввод массива
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(100,999);
//Вывод массива 
            Console.WriteLine("Исходное число ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
                Console.WriteLine();
                if (array[i] % 2 == 0)
                kol++;
            }
// Количесвто четных чисел
Console.Write("Количество четных " + kol);