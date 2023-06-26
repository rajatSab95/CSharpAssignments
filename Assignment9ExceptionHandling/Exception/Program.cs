class Exceptions
{
    public static void Main()
    {
        while(true)
        {
            int? choice;
            try
            {
                Menu1();
            }
            catch
            {

            }
        }
    }
    public static void Menu1()
    {
        System.Console.WriteLine("Please make your choice:\n"
        +"1. Divide by zero Exception"
        +"2. File Not found Exception"
        +"3. Array Index Out of Bound Exception"
        +"4. Custom Exception"
        +""
        );
        int choice;
        int.TryParse(Console.ReadLine(), out choice);
        switch (choice)
        {
            case 1:
            {
                //throw DivideByZeroException;
                break;
            }

            default:
               {
                System.Console.WriteLine("No Exception Thrown");
                break;
               } 
                
        }
    }
}