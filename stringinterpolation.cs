using System;
class Interpolation
{
    public void Interpolationstring()
    {
        Console.WriteLine("Enter the name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hi, I am {name}, my age is {age}");
    }
}