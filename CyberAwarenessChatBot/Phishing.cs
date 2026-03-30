using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class Phishing: QuestionType
    {
        public Phishing() { }

        public override void Definition()
        {
            Console.WriteLine("Phishing definition");
        }

        public override void Identify()
        {
            Console.WriteLine("how you identify phishing");
        }

        public override void BestPracticeAndMitigations()
        {
            Console.WriteLine("how you fight against Phishing");
        }
    }
}
