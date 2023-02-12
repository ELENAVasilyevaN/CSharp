// // 1. Определить число, факториал которого надо вычислить

// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6



// // 2. Определить число, факториал большого числа которого надо вычислить

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i)); //вывод каждого действия в отдельной строке
// }


// // 3. Определить число, факториал большого числа которого надо вычислить. Задача 2, вывод развернутый

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }


// 4. факториал числа. int меняем на double
double Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}


// // 5. Фибоначчи

// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6