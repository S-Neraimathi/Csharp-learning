class ReverseArray
{
    public void Reversenum()
    {
        int[] number = { 1, 4, 5, 2, 6, 9, 10, 24 };
        int[] reversedArr = new int[number.Length];
        for (int i = 0, e = number.Length - 1; i < number.Length; i++, e--)
        {
            reversedArr[i] = number[e];
        }
        Console.WriteLine("The reversed array is : ");
        PrintArray(reversedArr);
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}