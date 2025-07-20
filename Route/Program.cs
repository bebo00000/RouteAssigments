

/////////////////////////Assigment 04//////////////////// 


#region // Print numbers from 1 to N
//int.TryParse(Console.ReadLine(), out int number);
//for(int i=1;i<=number;i++)
//{
//    Console.WriteLine(i);
//}
#endregion

#region // Print multiplication table of a number
//int.TryParse(Console.ReadLine(), out int number);
//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine(number*i);
//}
#endregion

#region // Print even numbers from 1 to N
//if(int.TryParse(Console.ReadLine(), out int number))
//{
//    for (int i = 1; i <= number; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Invalid input.");
//}

#endregion

#region power of a number
//int.TryParse(Console.ReadLine(),out int number);
//int.TryParse(Console.ReadLine(),out int power);
//Console.WriteLine(Math.Pow(number,power));
#endregion

#region // Print sum and average of five numbers
//Console.WriteLine("Enter Five Number");
//int.TryParse(Console.ReadLine(), out int number01);
//int.TryParse(Console.ReadLine(), out int number02);
//int.TryParse(Console.ReadLine(), out int number03);
//int.TryParse(Console.ReadLine(), out int number04);
//int.TryParse(Console.ReadLine(), out int number05);
//Console.WriteLine("The sum of the five numbers is: " + (number01 + number02 + number03 + number04 + number05));
//Console.WriteLine($"Avg of the five numbers:{(number01 + number02 + number03 + number04 + number05) / 5}");
//Console.WriteLine("Percentage");
#endregion

#region // Reverse a string
using System;
using System.Transactions;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a string: ");
//        string input = Console.ReadLine();
//
//        string reversed = "";
//
//        // Loop from end of string to start
//        for (int i = input.Length - 1; i >= 0; i--)
//        {
//            reversed += input[i];  // Append each character
//        }
//
//        Console.WriteLine("Reversed string: " + reversed);
//    }
//}

#endregion

#region // Reverse a number
//Console.Write("Enter a number: ");
//bool success = int.TryParse(Console.ReadLine(), out int number);
//
//if (success)
//{
//    string numberStr = number.ToString();
//    string reversed = "";
//
//    for (int i = numberStr.Length - 1; i >= 0; i--)
//    {
//        reversed += numberStr[i];
//    }
//
//    Console.WriteLine("Reversed number: " + reversed);
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a valid number.");
//}



#endregion

#region // Check if a number is prime
//Console.Write("Input starting number of range: ");
//int start = int.Parse(Console.ReadLine());
//
//Console.Write("Input ending number of range: ");
//int end = int.Parse(Console.ReadLine());
//
//Console.WriteLine("\nThe prime numbers between {0} and {1} are:", start, end);
//
//for (int i = start; i <= end; i++)
//{
//     if (IsPrime(i))
//    {
//        Console.Write(i + " ");
//    }
//}
//
//Console.WriteLine(); 
//
//
//static bool IsPrime(int number)
//{
//    if (number <= 1) return false;
//    if (number == 2) return true;
//
//    for (int i = 2; i <= Math.Sqrt(number); i++)
//    {
//        if (number % i == 0) return false;
//    }
//
//    return true;
//}

#endregion

#region convert to binary
//Console.Write("Enter a number to convert: ");
//int number = int.Parse(Console.ReadLine());
//string binary = "";
//int n = number;
//while (n > 0)
//{
//    int remainder = n % 2;
//    binary = remainder + binary; // Build the binary string in reverse
//    n = n / 2;
//}
//Console.WriteLine($"The Binary of {number} is {binary}");
#endregion

#region three points in same line or not ?
//Console.Write("Enter x1: ");
//double x1 = double.Parse(Console.ReadLine());
//
//Console.Write("Enter y1: ");
//double y1 = double.Parse(Console.ReadLine());
//
//Console.Write("Enter x2: ");
//double x2 = double.Parse(Console.ReadLine());
//
//Console.Write("Enter y2: ");
//double y2 = double.Parse(Console.ReadLine());
//
//Console.Write("Enter x3: ");
//double x3 = double.Parse(Console.ReadLine());
//
//Console.Write("Enter y3: ");
//double y3 = double.Parse(Console.ReadLine());
//
//double area = x1 * (y2 - y3) +
//              x2 * (y3 - y1) +
//              x3 * (y1 - y2);
//
//if (area == 0)
//{
//    Console.WriteLine("The points lie on the same straight line.");
//}
//else
//{
//    Console.WriteLine("The points do NOT lie on the same straight line.");
//}
#endregion

#region identity matrix
//Console.Write("Enter the size of the identity matrix (n): ");
//int n = int.Parse(Console.ReadLine());
//
//Console.WriteLine("\nIdentity matrix of size {0} x {1}:\n", n, n);
//
//for (int i = 0; i < n; i++)      
//{
//    for (int j = 0; j < n; j++)  
//    {
//        if (i == j)
//            Console.Write("1 ");
//        else
//            Console.Write("0 ");
//    }
//    Console.WriteLine(); 
//}
#endregion
