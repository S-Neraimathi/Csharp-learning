// See https://aka.ms/new-console-template for more information
using System;
class Basic
{
    public void Basicprogram()
    {

        Console.WriteLine("Hello, World!");

        int num1 = 12;
        int num2 = 20;
        int sum = num1 + num2;//sum of digits
        Console.WriteLine(sum);

        int n = 10;//fibonacci
        int n1 = 0;
        int n2 = 1;
        int fibo;
        for (int i = 2; i <= n; i++)
        {
            fibo = n1 + n2;
            Console.WriteLine(fibo);
            n1 = n2;
            n2 = fibo;
        }

        int number = 6;//factorial
        int fact = 1;
        if (number < 0)
        {
            Console.WriteLine("Factorial cannot be defined to the number");
        }
        for (int i = 1; i <= number; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);

        int[] arr = { 12, 13, 14, 3, 5, 9, 8, 23 };//to find min and max number in an array
        if (arr.Length == 0)
        {
            Console.WriteLine("The array is empty");
        }
        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine("Minimum number is : " + min);
        Console.WriteLine("Maximum number is : " + max);

        int value = 234;//Reverse the number 
        int reverseNumber = 0;
        int originalNumber = value;

        while (value > 0)
        {
            int digit = value % 10;
            reverseNumber = reverseNumber * 10 + digit;
            value = value / 10;
        }

        Console.WriteLine(reverseNumber);

        string word = "hello";//to count the vowels
        int vowel = 0;
        for (int i = 0; i < word.Length; i++)
        {
            char Word = word[i];
            if (Word == 'a' || Word == 'e' || Word == 'i' || Word == 'o' || Word == 'u')
            {
                vowel++;
            }
        }
        Console.WriteLine(vowel);

        string original = "hello";//to reverse the string
        char[] arrays = original.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arrays);
        Console.WriteLine(reversed);
    }
}
