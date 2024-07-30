class Conditionstate
{
    public void conditionline()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 10)
            System.Console.WriteLine(true);
        else
            System.Console.WriteLine(false);

        switch (num)
        {
            case 10:
                System.Console.WriteLine(true);
                break;
            default:
                System.Console.WriteLine(false);
                break;
        }

    }

}

