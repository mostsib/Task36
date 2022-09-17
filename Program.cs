// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] myArray = new int[4];

 Random rand = new Random();
            
         for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(-100, 100);
                Console.WriteLine("Значение элемента массива " + i + " = " + myArray[i]);
            }
            
int sum = 0;
  for (int i = 0; i < myArray.Length; i++)
       {
          if (i % 2 == 1)
           sum += myArray[i];
       }
Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");
            