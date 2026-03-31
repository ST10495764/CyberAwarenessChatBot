using System;
using System.Collections.Generic;
using System.Text;

namespace CyberAwarenessChatBot
{
    internal class PasswordSafety: QuestionType
    {
        public PasswordSafety() { }

        public override string Definition()
        {
            return(@"
Password safety refers to creating and managing passwords in a way that prevents 
unauthorized access to your accounts.
PRESS ENTER TO CONTINUE READING ABOUT PASSWORD SAFETY");
        }

        public override string Identify()
        {
            return (@"
How to Identify Weak Password Practices:
+Using short or simple passwords (e.g., “123456”, “password”)
+Reusing the same password across multiple sites
+Writing passwords down in unsafe places
+Sharing passwords with others
PRESS ENTER TO CONTINUE READING ABOUT PASSWORD SAFETY");
        }

        public override string BestPracticeAndMitigations()
        {
            return(@"
Best Practices:
+Use long, complex passwords (at least 12–16 characters)
+Combine letters, numbers, and symbols
+Use a unique password for each account
+Enable two-factor authentication (2FA)
+Use a password manager to store passwords securely
+Change passwords if a breach is suspected
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

