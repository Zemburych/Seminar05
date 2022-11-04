// Задача 36:Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int[] array = new int[n];
// Рандомный ввод массива
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(0,9);
//Вывод массива 
            Console.WriteLine("Исходное число ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
                Console.WriteLine();
                if (i % 2 == 1)
                summ = summ + array[i];
            }
// сумму чисел на нечетных позициях
Console.Write("Сумма " + summ);