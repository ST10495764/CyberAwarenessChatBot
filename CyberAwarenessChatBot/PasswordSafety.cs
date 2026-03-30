using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class PasswordSafety: QuestionType
    {
        public PasswordSafety() { }

        public override void Definition()
        {
            Console.WriteLine("Password safety definition");
        }

        public override void Identify()
        {
            Console.WriteLine("identifying Password safety");
        }

        public override void BestPracticeAndMitigations()
        {
            Console.WriteLine("best practice for Password safety");
        }
    }
}

