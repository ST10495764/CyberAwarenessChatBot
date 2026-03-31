using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class SafeBrowsing : QuestionType
    {
        public SafeBrowsing() { }

        public override string Definition()
        {
            return (@"
Safe browsing means using the internet in a way that protects your devices and personal information from 
threats like malware, scams, and unsafe websites.
PRESS ENTER TO CONTINUE READING ABOUT SAFE BROWSING");
        }

        public override string Identify()
        {
            return (@"
How to Identify Unsafe Websites:
+URLs that start with http:// instead of https://
+Poor website design or lots of pop-ups
+Requests for unnecessary personal information
+Browser warnings about unsafe sites
+Fake download buttons
PRESS ENTER TO CONTINUE READING ABOUT SAFE BROWSING");
        }

        public override string BestPracticeAndMitigations()
        {
            return (@"
Best Practices:
+Only visit trusted and secure websites (HTTPS)
+Keep your browser and software up to date
+Avoid clicking on suspicious ads or pop-ups
+Install reputable antivirus/security software
+Log out of accounts when using shared devices
+Be cautious when using public Wi-Fi (use a VPN if possible)
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

