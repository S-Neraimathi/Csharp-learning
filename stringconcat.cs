class Stringconcate
{
    public void Concat()
    {
        Console.WriteLine("Enter your firstname : ");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your lastname : ");
        string lastname = Console.ReadLine();

        if (string.IsNullOrEmpty(firstname))
        {
            firstname = "Unknown";
        }

        if (string.IsNullOrEmpty(lastname))
        {
            lastname = "Unknown";
        }

        string fullname = firstname + " " + lastname;
        Console.WriteLine("The full name is : " + fullname);
    }
}