class Exceptionhandle
{
    public void ExceptionHandle()
    {

        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong.");
        }
    }
}