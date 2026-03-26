using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal abstract class QuestionType
    {
        public abstract string Definition();
        public abstract string Identify();

        public abstract string BestPractiseAndMitigations();

        public static void GetToKnowMe() 
        { 
        
            
        }

        public static string InvalidInput(string Input)
        {
            return Input; //leaving it like this for now
        }
    }
}
