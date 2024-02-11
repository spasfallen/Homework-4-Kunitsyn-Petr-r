// Task 1
// int sumNumbers(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }
// bool GetEven(int sum)
// {
//     if (sum % 2 == 0)
//     {
//         return true;
//     }
//     else return false;
// }

// while (true)
// {
//     System.Console.WriteLine($"add number or q for answer:");

//     string input = Console.ReadLine()!;
//     if (input == "q")
//     {
//         break;
//     }
//     int numb;
//     if (int.TryParse(input, out numb))

//     {
//         int number = int.Parse(input);
//         int sum = sumNumbers(number);
//         if (GetEven(sum) == true)
//         {
//             System.Console.WriteLine($"even - EXIT");
//             break;
//         }
//         System.Console.WriteLine($"not even, write another number");

//     }
// }

//Task 2
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     Random number = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = number.Next(minValue, maxValue + 1);

//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int e in array)
//     {
//         System.Console.Write($"{e} ");
//     }
//     System.Console.WriteLine();
// }

// bool GetEven(int num)
// {
//     if (num % 2 == 0)
//     {
//         return true;
//     }
//     else return false;
// }

// int[] Array1 = GetRandomArray (3, 100, 999);
// int sumEven = 0;
// foreach (int e in Array1)
// {
//    if (GetEven(e) == true)
//    {
//     sumEven++;
//    } 
// }
// PrintArray(Array1);
// System.Console.WriteLine($"in massive {sumEven} even numbers");

// Task 3
