                    // Задачи 36 и 38 ниже
                    
                    
                    
                    // Задача 34
// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
                                // Задача 36
// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

                                            // Задача 38

// Console.WriteLine($"\nНайдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

// double[] arrayRealNumbers = new double[10];
//   for (int i = 0; i < arrayRealNumbers.Length; i++ )
//   {
//     arrayRealNumbers[i] = new Random().Next(1, 10);
//     Console.Write(arrayRealNumbers[i] + " ");
//   }

// double maxNumber = arrayRealNumbers[0];
// double minNumber = arrayRealNumbers[0];

//   for (int i = 1; i < arrayRealNumbers.Length; i++)
//   {
//     if (maxNumber < arrayRealNumbers[i])
//     {
//       maxNumber = arrayRealNumbers[i];
//     }
//         if (minNumber > arrayRealNumbers[i])
//     {
//       minNumber = arrayRealNumbers[i];
//     }
//   }

//   double decision = maxNumber - minNumber;

//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
