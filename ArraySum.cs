//sum of arrays

class Arraysum
{
    public void Arrayadd()
    {


        int[] numbers = new int[6];

        Console.WriteLine("enter the numbers : ");

        for (int i = 0; i < 6; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        for (int i = 0; i < 6; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum of array = " + sum);
    }
}


