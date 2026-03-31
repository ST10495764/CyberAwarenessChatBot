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
            Console.WriteLine(@"
Safe browsing means using the internet in a way that protects your devices and personal information from 
threats like malware, scams, and unsafe websites.");
        }

        public override void Identify()
        {
            Console.WriteLine(@"
How to Identify Unsafe Websites:
+URLs that start with http:// instead of https://
+Poor website design or lots of pop-ups
+Requests for unnecessary personal information
+Browser warnings about unsafe sites
+Fake download buttons");
        }

        public override void BestPracticeAndMitigations()
        {
            Console.WriteLine(@"
Best Practices:
+Only visit trusted and secure websites (HTTPS)
+Keep your browser and software up to date
+Avoid clicking on suspicious ads or pop-ups
+Install reputable antivirus/security software
+Log out of accounts when using shared devices
+Be cautious when using public Wi-Fi (use a VPN if possible)");
        }

        public void ShowAll()
        {
            Definition();
            Identify();
            BestPracticeAndMitigations();

        }
    }
}

