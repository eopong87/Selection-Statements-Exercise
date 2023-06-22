namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            Console.WriteLine("Guess That Number Game ");
            Console.WriteLine("See if you can get that number?");
            
            //var userResponse = Console.ReadLine();

            //var upperLimit = int.Parse(userResponse);
            var random = new Random();
            var number = random.Next (1, 5);
            Console.WriteLine("Input your Guess:");

            var guess = int.Parse(Console.ReadLine());
                

           if(guess > number)
            {
                Console.WriteLine("sorry too high! Try Again");
            }

            else if(guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }

            else
            {
                Console.WriteLine("Correct");
            }
     

           //start exercise 2 here:




           
        }

    }
}
