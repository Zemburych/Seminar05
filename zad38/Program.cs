// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
// ввод массива
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {    
        array[i] = random.NextDouble() * 10; // вещественное число от 0 до 10
        Console.Write("{0,6:F3}", array[i]);
    }
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
    Console.WriteLine();        
// вывод результата     
Console.WriteLine("max:  " + max);
Console.WriteLine("min  " + min);
Console.WriteLine("Разница максимального и минимального: " + "{0,6:F3}", (max - min));
