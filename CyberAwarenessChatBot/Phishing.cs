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
            Console.WriteLine(@"
Phishing is a cyberattack where attackers pretend to be trustworthy sources (like banks, companies, or colleagues)
to trick you into revealing sensitive information such as passwords, credit card details, or personal data.");
        }

        public override void Identify()
        {
            Console.WriteLine(@"
How to Identify Phishing. Look out for these warning signs:
Suspicious sender email (misspelled or unusual domain)
+Urgent or threatening language (“Act now or your account will be closed!”)
+Generic greetings (“Dear customer” instead of your name)
+Strange links or attachments
+Mismatched URLs (hover over links to check the real address)
+Unexpected requests for sensitive info");
        }

        public override void BestPracticeAndMitigations()
        {
            Console.WriteLine(@"
Best Practices:
+Never click links or download attachments from unknown sources
+Verify requests directly with the company/person
+Check URLs carefully before entering information
+Use spam filters and email security tools
+Report phishing attempts to your IT team or provider");
        }

        public void ShowAll()
        {
            Definition();
            Identify();
            BestPracticeAndMitigations();

        }
    }
}
