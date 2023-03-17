namespace AgeCalculator
{
    public class Program
    {
        public static void Main()
        {
            do
            {
                try
                {
                    Console.Write("Birthyear: ");
                    int birthYear = int.Parse(Console.ReadLine());
                    int date = DateTime.Now.Year;
                    int age = date - birthYear;
                    
                    if (age == 1 || age == 0) 
                    {
                        Console.WriteLine($"{age} years old. "); 
                    }
                    else if (age < 0) 
                    {
                        Console.WriteLine($"Birthyear cannot be in the future. Please input an age before {date} "); 
                    }
                    else if (birthYear > date || birthYear < 1890)
                    {
                        Console.WriteLine("Please type a correct birthyear.");
                    }
                    else
                    {
                        Console.WriteLine($"{age} years old."); 
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            } while (true);

        }
    }
}
