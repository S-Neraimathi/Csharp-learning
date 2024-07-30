class Maximum
{
    public void Maxi()
    {
        int[] arr = new int[9];
        Console.WriteLine("Enter the number : ");
        for (int i = 0; i < 9; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("The maximum number is : " + max);
    }
}