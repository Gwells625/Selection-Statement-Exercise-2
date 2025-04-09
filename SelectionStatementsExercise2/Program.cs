namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school Subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("No to math.");
                    break;
                case "science":
                    Console.WriteLine("Science is interesting.");
                    break;
                case "physical education":
                    Console.WriteLine("Physical Education is good for your health.");
                    break;
                case "history":
                    Console.WriteLine("History is helpful so we do not make the same mistakes.");
                    break;
                case "english":
                    Console.WriteLine("English is my favorite too.");
                    break;
                default:
                    Console.WriteLine("I like that too.");
                    break;
                
            }
            
        }
    }
}