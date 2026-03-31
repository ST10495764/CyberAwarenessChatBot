using Spectre.Console;
using System;
using System.Reflection;
using System.Text;
using System;
using System.Threading;

namespace CyberAwarenessChatBot
{
    internal class Program
    {
        static void DrawBox(int x, int y, int width, int height)  //x and y are for the cursor position and width and height are for the console boarder parameters 
        {
            // Top border
            Console.SetCursorPosition(x, y);
            Console.Write("+" + new string('=', width - 1) + "+"); // the string method takes in a char and count

            // Side borders
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("|");                              //writing on far left

                Console.SetCursorPosition(x + width - 1, y + i);
                Console.Write("|");                             //writing on far right
            }

            // Bottom border
            Console.SetCursorPosition(x, y + height - 1);
            Console.Write("+" + new string('=', width - 2) + "+");
        }

        public static string TypingInput(string prompt, int delay = 30)
        {
            foreach (char c in prompt)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            return Console.ReadLine();

        }
        
            
        


        public static void Greetings()
        {
          
               
        }



        //console boarders 




        public static void GetToKnowMe()
        {
            int x = 2;
            int y = 2;
            int width = 95;
            int height = 25;
            while (true)
            {
                Console.Title = "GET TO KNOW ME";
                //DrawBox(x, y, width, height);
                //Console.SetCursorPosition(x, y);


                string userInput1 = TypingInput("Ask any question about myself or type yes to start learning: ");

                //Console.ReadKey();

               string userInput = userInput1.ToLower();



                if (userInput == "how are you")
                {
                    TypingInput(@"I am doing okay, thank you for asking.");

                }
                else if (userInput == "what is your purpose")
                {
                    TypingInput(@"
My purpose is to help you learn about security concepts.
I cover topics like threats and how you can protect yourself.");
                }
                else if (userInput == "what can i ask you about")
                {
                    TypingInput(@"
You can ask about phishing, safe browsing, and password safety.
I'll explain definitions, how to identify threats,and best practices.");
                }
                else if (userInput == "yes")
                {
                    PickTopic();




                }
                else
                {
                    TypingInput("I didn't understand that. Please rephrase.");
                }


            }
        }




        public static void PickTopic()
        {

            while (true)
            {
                Console.Title = "LEARN ABOUT CYBER SECURITY";

               string topic1 = TypingInput("Choose a topic to learn about Phishing, safe browsing or password safety: ");

               string topic = topic1.ToLower();


                Phishing phishing = new Phishing();
                PasswordSafety passwordSafety = new PasswordSafety();
                SafeBrowsing safeBrowsing = new SafeBrowsing();










                if (topic == "phishing")
                {
                    TypingInput(phishing.Definition());
                    TypingInput(phishing.Identify());
                    TypingInput(phishing.BestPracticeAndMitigations());
                    Console.Clear();                                          //CLEARS CONSOLE
                }
                else if (topic == "password safety")
                {
                    TypingInput(passwordSafety.Definition());
                    TypingInput(passwordSafety.Identify());
                    TypingInput(passwordSafety.BestPracticeAndMitigations());
                    Console.Clear();
                }
                else if (topic == "safe browsing")
                {
                    TypingInput(safeBrowsing.Definition());
                    TypingInput(safeBrowsing.Identify());
                    TypingInput(safeBrowsing.BestPracticeAndMitigations());
                    Console.Clear();
                }
                else if (topic == "exit")
                {

                }
                else
                {
                }

            }
        }
                static void Main(string[] args)
                {

            //string name = TypingInput("Hello there! What's your name? ");
            //TypingInput($"\nNice to meet you, {name}!");

            
           GetToKnowMe();
            Console.ReadKey();



                }



            }
        }
    

