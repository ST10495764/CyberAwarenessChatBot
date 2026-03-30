using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class SafeBrowsing : QuestionType
    {
        public SafeBrowsing() { }

        public override void Definition()
        {
            Console.WriteLine("safe browsing definition");
        }

        public override void Identify()
        {
            Console.WriteLine("identifying if you are safe browsing");
        }

        public override void BestPracticeAndMitigations()
        {
            Console.WriteLine("best practice for safe browsing");
        }
    }
}

