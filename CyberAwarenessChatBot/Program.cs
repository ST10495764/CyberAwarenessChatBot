namespace CyberAwarenessChatBot
{
    internal class Program
    {
        public static string UserName() 
        {
            Console.WriteLine("What is your name?:");
            string UserName = Console.ReadLine();

            return (UserName);
        }

        public static void UIDesign()
        {
            Console.WriteLine($@"
=========================================================================================================================

                            WELCOME TO THE CYBERSECURITY AWARENESS CHATBOT {UserName()}");
        }
        public static void GetToKnowMe()
        {
            Console.Write("Type here: ");
            string UserInput = Console.ReadLine().ToLower();
            if (UserInput == "how are you")
            {
                Console.WriteLine("I am doing okay, thank you for asking");
            }

        }
        public static string InvalidInput(string Input)
        {
            return Input; //leaving it like this for now
        }

        static void Main(string[] args)
        {
            UIDesign();

            //PasswordSafety passwordContent = new PasswordSafety();
            //passwordContent.Definition();

            GetToKnowMe();
        }
    }
}
