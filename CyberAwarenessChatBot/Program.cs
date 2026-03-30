using Spectre.Console;
using System;
using System.Reflection;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class Program
    {
        static void DrawBox(int x, int y, int width, int height)
        {
                // Top border
                Console.SetCursorPosition(x, y);
                Console.Write("+" + new string('-', width - 2) + "+");

                // Side borders
                for (int i = 1; i < height - 1; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write("|");

                    Console.SetCursorPosition(x + width - 1, y + i);
                    Console.Write("|");
                }

                // Bottom border
                Console.SetCursorPosition(x, y + height - 1);
                Console.Write("+" + new string('-', width - 2) + "+");
            }
        

        public static void Greetings()
        {
            DrawBox(0,0,50,10);
            int startX = 2;
            int startY = 2;

            Console.SetCursorPosition(startX, startY);
            var UserName = new StringBuilder();
            Console.WriteLine("What is your name?:");
            string UserName = Console.ReadLine();
            Console.WriteLine($@"
========================================================================================================================

                            WELCOME TO THE CYBERSECURITY AWARENESS CHATBOT {UserName}");
        }

        //console boarders 
       

        

        public static void GetToKnowMe()
        {
            while (true)
            {
                Console.Write("Type here: ");
                string UserInput = Console.ReadLine().ToLower();
                if (UserInput == "how are you")
                {
                    Console.WriteLine(@"
            I am doing okay, thank you for asking.Type yes to start learning or 
            ask me more about myself");
                }
                else if (UserInput == "what is your purpose")
                {
                        Console.WriteLine(@$"
            My Purpose is to help you learn about security concepts
            covering topics like threats and how you can protect yourself against 
            such threat in this new age of technology. Type yes to start learning.");
                }
                else if (UserInput == "what can i ask you about")
                {
                    Console.WriteLine(@$"
            You can ask me about Phishing,safe browsing and password safety. I will tell you the definition,
            how to identify these threats and what is the best practice for each.
            If you've asked me about my purpose, then that's pretty much there is to know 
            about me. Do you want to start learning?");
            }
                else if(UserInput == "yes")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"I didn't quite understand that can you please rephrase");
                }
            }

        }

        public static void PickTopic()
        {
            //creating object of each topic class

            Phishing phishing = new Phishing();
            PasswordSafety passwordSafety = new PasswordSafety();
            SafeBrowsing safeBrowsing = new SafeBrowsing();

            Console.WriteLine("Do you want to learn about Phishing, Safe Browsing, or Password safety? ");

            Console.Write("Type here: ");

            //reading what the user wants to learn about
            string topic = Console.ReadLine().ToLower(); //making input lowercase
            Console.WriteLine("");

            //presenting different content depending on what the user chooses 
            if (topic == "phishing")
            {
                phishing.Definition();
                Console.WriteLine("");
                phishing.Identify();
                Console.WriteLine("");

                phishing.BestPracticeAndMitigations();
            }
            else if (topic == "password safety")
            {
                passwordSafety.Definition();
                Console.WriteLine("");
                passwordSafety.Identify();
                Console.WriteLine("");
                passwordSafety.BestPracticeAndMitigations();
            }
            else if(topic == "safe browsing")
            {
                safeBrowsing.Definition();
                Console.WriteLine("");
                safeBrowsing.Identify();
                Console.WriteLine("");
                safeBrowsing.BestPracticeAndMitigations();
                Console.WriteLine("");
            }
        }
       

        static void Main(string[] args)
        {
            //int width = 70;
            //int height = 20;

            ////DrawBox(0, 0, width, height);

            //int startX = 2;
            //int startY = 2;

            //Console.SetCursorPosition(startX, startY);

            //var input = new StringBuilder();
            //int cursorX = startX;

            //while (true)
            //{
            //    var key = Console.ReadKey(true);

            //    if (key.Key == ConsoleKey.Enter)
            //        break;

            //    if (key.Key == ConsoleKey.Backspace && input.Length > 0)
            //    {
            //        input.Remove(input.Length - 1, 1);
            //        cursorX--;

            //        Console.SetCursorPosition(cursorX, startY);
            //        Console.Write(" ");
            //        Console.SetCursorPosition(cursorX, startY);
            //    }
            //    else if (!char.IsControl(key.KeyChar))
            //    {
            //        input.Append(key.KeyChar);
            //        Console.SetCursorPosition(cursorX, startY);
            //        Console.Write(key.KeyChar);
            //        cursorX++;
            //    }
            //}

            //// Output inside the box
            //Console.SetCursorPosition(2, 4);
            //Console.Write("You typed: " + input.ToString());

            //Console.SetCursorPosition(0, height + 1);
            //Console.ReadKey();

            Greetings();

        }

       
        //CreateInteractiveBorderedArea(30, 30);
       
        //GetToKnowMe();
        //PickTopic();

    }
    }

