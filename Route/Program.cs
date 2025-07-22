#region q01

//if(int.TryParse(Console.ReadLine(), out int hours))
//{
//    if (hours < 3)
//        Console.WriteLine("high efficient");
//    else if (hours > 3 && hours < 4)
//        Console.WriteLine("need to increase their speed");
//    else if (hours == 5)
//        Console.WriteLine("train");
//    else
//        Console.WriteLine("leave");
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}

#endregion

#region identity mat
//int.TryParse(Console.ReadLine(),out int n);
//for (int i = 0; i < n; i++)
//{for (int j = 0; j < n; j++)
//    { if (i == j)
//            Console.Write("1");
//        else
//            Console.Write("0");
//    }
//  Console.WriteLine();
//}
#endregion

#region sum of array elements
//int[] arr = { 3,1,4,1,2};
//int counter =0;
//for (int i = 0; i < arr.Length; i++)
//{
//    counter += arr[i];
//
//}
//Console.WriteLine("Sum of array elements: " + counter);
#endregion

#region merge and sort arrays
//int size;
//
// Console.Write("Enter the size of the arrays: ");
// int.TryParse(Console.ReadLine(), out size);
//
// int[] array1 = new int[size];
// int[] array2 = new int[size];
//
// Console.WriteLine("Enter elements for the first array:");
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"Element {i + 1}: ");
//     int.TryParse(Console.ReadLine(), out array1[i]);
// }
//
// Console.WriteLine("Enter elements for the second array:");
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"Element {i + 1}: ");
//     int.TryParse(Console.ReadLine(), out array2[i]);
// }
// int[] merged = new int[size * 2];
// for (int i = 0; i < size; i++)
// {
//     merged[i] = array1[i];
//     merged[size + i] = array2[i];
// }
// Array.Sort(merged);
// Console.WriteLine("Merged array in ascending order:");
// foreach (int value in merged)
// {
//     Console.Write(value + " ");
// }
//
// Console.WriteLine(); 
#endregion

#region frequency of elements in an array

//int size;

//Console.Write("Enter the size of the array: ");
//int.TryParse(Console.ReadLine(), out size);

//int[] arr = new int[size];
//int[] freq = new int[size]; // to track frequency
//int visited = -1;

//Console.WriteLine("Enter elements of the array:");
//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Element {i + 1}: ");
//    int.TryParse(Console.ReadLine(), out arr[i]);
//}

//for (int i = 0; i < size; i++)
//{
//    int count = 1;
//    for (int j = i + 1; j < size; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            count++;
//            freq[j] = visited; 
//        }
//    }

//    if (freq[i] != visited)
//        freq[i] = count;
//}
//Console.WriteLine("\nFrequency of each element:");
//for (int i = 0; i < size; i++)
//{
//    if (freq[i] != visited)
//        Console.WriteLine($"{arr[i]} occurs {freq[i]} time(s)");
//}



#endregion

#region max and min of array elements
//int max ;
//int min ;
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//max = arr[0];
//min = arr[0];
//for (int i= 0; i<arr.Length; i++)
//{
//    if (arr[i] > max)
//        max = arr[i];
//    else if (arr[i] < min)
//        min = arr[i];
//}
//Console.WriteLine($"max value: {max}");
//Console.WriteLine($"min value: {min}");
#endregion

#region second largest element in an array
//Console.Write("Enter the size of the array: ");
//int.TryParse(Console.ReadLine(), out int size);

//int[] arr = new int[size];

//Console.WriteLine("Enter the array elements:");
//for (int i = 0; i < size; i++)
//{
//    int.TryParse(Console.ReadLine(), out arr[i]);
//}

//int largest = int.MinValue;
//int secondLargest = int.MinValue;

//foreach (int num in arr)
//{
//    if (num > largest)
//    {
//        secondLargest = largest;
//        largest = num;
//    }
//    else if (num > secondLargest && num != largest)
//    {
//        secondLargest = num;
//    }
//}

//if (secondLargest == int.MinValue)
//{
//    Console.WriteLine("There is no second largest element.");
//}
//else
//{
//    Console.WriteLine("The second largest element is: " + secondLargest);
//}

#endregion

#region distance between two equal numbers
//Console.Write("Enter the size of the array: ");
//int.TryParse(Console.ReadLine(), out int size);
//int[] arr =new int[size];
//Console.WriteLine("Enter the array elements:"); 
//for (int i = 0; i < size; i++)
//{
//    int.TryParse(Console.ReadLine(), out arr[i]);
//}

//for (int i = 0; i < size; i++)
//{
//    for (int j = i + 1; j < size; j++)
//        if (arr[i] == arr[j])
//        {
//            Console.WriteLine($"distance between two equal nums:{(j-1) - i}");
//            Console.WriteLine(i);
//            Console.WriteLine(j);
//        }


//}
#endregion

#region reverse words in a string
//Console.WriteLine("Please Enter Sring ");
//string Words = Console.ReadLine();
//string[] strings = Words.Trim().Split(" "); 
//
//for(int i = strings.Length-1; i >=0; i--)
//{
//
//    Console.Write($"{strings[i]} ");
//}
#endregion

#region copy array elements multidimensional array
//bool flag;
//int[,] Array01 = new int[3, 3];
//int[,] Array02 = new int[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        do
//        {
//            Console.WriteLine($"Enter Element Of Row {i + 1} Column {j+1} Of Array 01");
//            flag = int.TryParse(Console.ReadLine(), out Array01[i,j]);


//        } while (!flag);
//    }
//}


//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Array02[i,j] = Array01[i,j];
//    }
//}



//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{Array02[i,j]}  " ) ;
//    }
//    Console.WriteLine();
//}
#endregion

#region reverse array elements
//int size;
//bool flag;
//do
//{
//    Console.WriteLine("Enter The Size Of Array");
//    flag = int.TryParse(Console.ReadLine(), out size);


//} while (flag ==false);

//int[] Arr = new int[size];

//for (int i = 0; i < Arr.Length; i++)
//{
//    do
//    {
//        Console.WriteLine($"Enter The Element {i+1} Of Array");
//        flag = int.TryParse(Console.ReadLine(), out Arr[i]);

//    } while (!flag);
//}

//for (int i = Arr.Length - 1; i >= 0; i--) 
//{
//    Console.Write($"{Arr[i]} ");
//}


#endregion