using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class Phishing: QuestionType
    {
        public Phishing() { }

        public override string Definition()
        {

            return (@"
Phishing is a cyberattack where attackers pretend to be trustworthy sources (like banks, companies, or colleagues)
to trick you into revealing sensitive information such as passwords, credit card details, or personal data.
PRESS ENTER TO CONTINUE READING ABOUT PHISHING");
        }

        public override string Identify()
        {
            return(@"
How to Identify Phishing. Look out for these warning signs:
Suspicious sender email (misspelled or unusual domain)
+Urgent or threatening language (“Act now or your account will be closed!”)
+Generic greetings (“Dear customer” instead of your name)
+Strange links or attachments
+Mismatched URLs (hover over links to check the real address)
+Unexpected requests for sensitive info
PRESS ENTER TO CONTINUE READING ABOUT PHISHING");
        }

        public override string BestPracticeAndMitigations()
        {

            return (@"
Best Practices:
+Never click links or download attachments from unknown sources
+Verify requests directly with the company/person
+Check URLs carefully before entering information
+Use spam filters and email security tools
+Report phishing attempts to your IT team or provider
PRESS ENTER TO LEARN ABOUT ANOTHER TOPIC");
        }

        public void ShowAll()
        {
            Definition();
            Identify();
            BestPracticeAndMitigations();

        }
    }
}
