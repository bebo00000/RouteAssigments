#region takeinput from user and print it
//int Number;
//Number=int.Parse(Console.ReadLine());
//Console.WriteLine(Number);
#endregion

#region parse input from user and print it

//bool parseMessage = int.TryParse(Console.ReadLine(), out int number);
//Console.Write(number);
//// If parsing fails, number will be 0
#endregion

#region add two numbers and print the result
//float number1 = 9.2f,number2=5.1f;
//number1+= number2;
//Console.WriteLine($"{number1}");

//float number1,number2;                          //from user
//Console.WriteLine("Enter first number:");
//number1=float.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//number2=float.Parse(Console.ReadLine());  
//Console.WriteLine($"The sum of {number1} and {number2} is {number1 + number2}");    
#endregion

#region //Extract a substring from a given string.
//Console.WriteLine("Enter String");
//string word = Console.ReadLine();
//Console.WriteLine("enter the start");
//int start;
//int.TryParse(Console.ReadLine(), out start);
//Console.WriteLine("enter the length");
//int length;
//int.TryParse(Console.ReadLine(), out length);
//string result = word.Substring(start, length); 
//Console.WriteLine(result);
#endregion

#region // value type
//int Number01 = 1;
//int Number02 = 2;
//Console.WriteLine($"{Number01} , {Number02}");
// Number01 = Number02;
//Console.WriteLine($"{Number01} , {Number02}");
//Number02 = 4;
//Console.WriteLine($"{Number01} , {Number02}");
#endregion

#region //reference type
//Point point01 = new Point();
//point01.X= 10;
//point01.Y= 10;

//// unreachable object 

//Point point02 = new Point();
//point02.X= 20;
//point02.Y= 20;

//point01 = point02;
//Console.WriteLine(point01);
//Console.WriteLine(point02);

//point02.X = 30;
//point02.Y = 30;
//Console.WriteLine("______________________________");
//Console.WriteLine(point01);
//Console.WriteLine(point02);

//Console.WriteLine("______________________________");
//Console.WriteLine("______________________________");
//Console.WriteLine("______________________________");

//point02 = new Point() {X=100 , Y =100 };

//Console.WriteLine(point01); // 100  100
//Console.WriteLine(point02); // 100  100
#endregion

#region //two strings as one variable
//Console.WriteLine("Enter first Word");
//string word01 = Console.ReadLine();
//Console.WriteLine("Enter second Word");
//string word02 = Console.ReadLine();
//Console.WriteLine($"Full String = {word01} {word02} ");
#endregion

#region //intrest
//double principal = 5;
//double rate = 7.5;
//double time = 2.3;
//double Interest = (principal * rate * time) / 100;
//Console.WriteLine(Interest);
#endregion

#region //BMI
//double weight = 85.5;
//double height = 1.7;
//double bmi = (weight) / (height*height);
//Console.WriteLine(bmi);
#endregion

#region //ternary operator coalase
//int temp = 25;
// string result = (temp < 10) ? "cold" : (temp > 30) ? "hot" : "good";
//Console.WriteLine(result);
#endregion

#region //date
//DateTime date = Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine(date);
//Console.WriteLine($"today date : {date.Day},{date.Month},{date.Year}");
//Console.WriteLine($"today date : {date.Day}/{date.Month}/{date.Year}");
//Console.WriteLine($"today date : {date.Day}-{date.Month}-{date.Year}");

#endregion

#region //divisible by 3 and 4
//int num1;
//Console.WriteLine("Enter First Number");
//num1=Convert.ToInt32(Console.ReadLine());
//if(num1 % 3 == 0 && num1 % 4 == 0) {
//    Console.WriteLine("Yes");
//}
//else {
//    Console.WriteLine("No");
//}
#endregion

#region //Positive or Negative
//int num1;
//Console.WriteLine("Enter Number");
//num1=Convert.ToInt32(Console.ReadLine());
//if(num1 <0) {
//    Console.WriteLine("Negative");
//}
//else {
//    Console.WriteLine("Positive");
//}

#endregion

#region //Max & Min of three numbers
//int num1, num2, num3;
//Console.WriteLine("Enter First Number");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Third Number");
//num3 = Convert.ToInt32(Console.ReadLine());
//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine($"Largest Number is {num1}");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine($"Largest Number is {num2}");
//}
//else
//{
//    Console.WriteLine($"Largest Number is {num3}");
//}
#endregion

#region even or odd
//Console.Write("Enter an integer: ");
//int number = Convert.ToInt32(Console.ReadLine());
//
//if (number % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}
#endregion

#region //vowel or consonant
//Console.Write("Enter a character: ");
//char ch = Convert.ToChar(Console.ReadLine());
//
//// Convert to lowercase to handle both upper and lower case
//ch = Char.ToLower(ch);
//
//if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//{
//    Console.WriteLine("vowel");
//}
//else
//{
//    Console.WriteLine("consonant");
//}
#endregion

#region //number of days in month

//Console.Write("Enter month number (1 to 12): ");
//int month = Convert.ToInt32(Console.ReadLine());
//
//switch (month)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        Console.WriteLine("Days in Month: 31");
//        break;
//
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine("Days in Month: 30");
//        break;
//
//    case 2:
//        Console.WriteLine("Days in Month: 28 or 29 (leap year)");
//        break;
//
//    default:
//        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
//        break;
//}
#endregion