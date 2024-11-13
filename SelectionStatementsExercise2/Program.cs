namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            favoriteSubject();
        }
        //public stattic is the Access Modifier
        //void is the return type
        //favoriteSubjects is the Type name

        public static void favoriteSubject()
        {
            Console.WriteLine("What is your favorite subject?!");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
               //case 
                case "math":
                    Console.WriteLine("I don't prefer math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "pe":
                case "p.e":
                case "physical education":
                    Console.WriteLine("P.E. is fun");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite too!");
                    break;
                case "geography":
                    Console.WriteLine("I like to study the world too!");
                    break;
                default:
                    Console.WriteLine("I like that too!");
                    break;
                
            }
            
            
            {
                
            }
        }
    }
}