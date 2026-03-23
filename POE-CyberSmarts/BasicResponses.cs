using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_CyberSmarts
{
    internal class BasicResponses
    {
        public string Response(string basics)
        {
            basics = basics.ToLower();

            //creating the basic responses, with basic question
            try
            {
                string inputLower = (basics ?? "").ToLower();

                if (basics.Contains("How are you"))
                    return "I am just great, thanks for asking";
                else if (basics.Contains("What is your purpose"))
                    return "Woo heavy question, I'd say my purpose is to share my knowledge on CyberSecurity with you \n Speaking of that, any questions in mind?";
                else if (basics.Contains("What can I ask you about"))
                    return "You can ask me all about CyberSecurity";
                else if (basics.Contains("Password Safety"))
                    return "Use a password manager: A password manager securely generates, stores, and autofills unique, complex passwords for all your accounts. This eliminates the need to remember multiple passwords and ensures you don't reuse them, significantly reducing the risk of account compromise. \r\n\r\nCreate strong, unique passphrases: Instead of single words, use a sequence of 4–7 unrelated random words (e.g., \"PurpleGuitarDanceTiger!\").  This method is easy to remember yet extremely hard to crack, meeting the modern security standard of length over complexity. \r\n\r\nEnable two-factor authentication (2FA): Add an extra layer of security by requiring a second verification step—like a code from your phone or an authentication app—when logging in. This protects your accounts even if your password is stolen. ";
                else if (basics.Contains("Phishing"))
                    return "Phishing attacks involve tricking a victim into taking some action that benefits the attacker. These attacks range from simple to complex. Many of them can be spotted by prepared users.";
                else if (basics.Contains("safe browsing"))
                    return "Safe Browsing is a service developed by Google that helps protect users from dangerous websites and online threats.  It works by maintaining a constantly updated list of malicious sites—such as those involved in phishing, malware distribution, unwanted software, and social engineering attacks—and checks websites you visit against this database in real time";
                else if (basics.Contains("Cyber Security"))
                    return "Cybersecurity is the practice of protecting computer systems, networks, devices, and data from digital attacks, unauthorized access, and cyber threats.  It ensures the confidentiality, integrity, and availability (CIA triad) of information by using a combination of technologies, processes, and best practices. \r\n\r\nProtects against: Malware, ransomware, phishing, social engineering, data breaches, and cyberattacks. \r\nKey areas include network security, application security, information security, identity management, and cloud security. \r\nEssential for: Individuals, businesses, governments, and critical infrastructure like power grids, healthcare systems, and financial services. \r\nWhy it matters: Cyberattacks can lead to financial loss, operational disruption, identity theft, reputational damage, and national security risks. \r\nEffective cybersecurity requires a layered defense strategy involving people, processes, and technology, with continuous updates and vigilance due to evolving threats.";
                else
                    return "That topic is out of my scope, you can ask me all about CyberSecurity instead!!!";
            }
            catch (NullReferenceException ex)
            {
                return "Error: The input was null or not properly initialized. Please try again.";
            }
            catch (ArgumentNullException ex)
            {
                return "Error: No text was provided to process. Please enter a question.";
            }
            catch (Exception ex)
            {
                return $"An unexpected error occurred: {ex.Message}";
            }
        }
    }
}
    