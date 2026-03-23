using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POE_CyberSmarts
{
    //creating a class for the audio greeting
    public class Greeting
    {
        public void GreetingAudio()
        {
            try
            {
                SoundPlayer greeting = new SoundPlayer("C:\\Users\\manyi\\source\\repos\\POE-CyberSmarts\\Greeting.wav");
                greeting.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking the user for their name
            Console.WriteLine("Welcome To CyberSmarts, Please write your name.");
            string name = Console.ReadLine();

            //displaying the ASCII art and greeting the user
            Greeting greetingMessage = new Greeting();
            greetingMessage.GreetingAudio();

            Console.WriteLine(" ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗███╗   ███╗ █████╗ ██████╗ ████████╗███████╗\r\n██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝████╗ ████║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝\r\n██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗██╔████╔██║███████║██████╔╝   ██║   ███████╗\r\n██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██║╚██╔╝██║██╔══██║██╔══██╗   ██║   ╚════██║\r\n╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║██║ ╚═╝ ██║██║  ██║██║  ██║   ██║   ███████║\r\n ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝\r\n                                                                                             ");
            Console.WriteLine("Hello " + name + ", And Welcome To CyberSmarts Where We Will Explore CyberSecurity Together!!");

            //calling on the basic responses class
            BasicResponses greetingResponses = new BasicResponses();
            Console.WriteLine("Well how can I help you, " + name + " today?? ps. say exit to close the app");
            while (true)
            {
                Console.WriteLine("You: ");
                string userInput = Console.ReadLine();

                //making the program scan the users input to send out the basic responses
                Console.WriteLine(greetingResponses.Response(userInput));

                //allowing the user to exit the application
                if (userInput == "exit")
                {
                    Console.WriteLine("Goodbye, and stay safe online!");
                    break;
                }
            }
        }
    }
}
