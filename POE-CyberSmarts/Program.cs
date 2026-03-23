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
            play.GreetingAudio();

            Console.WriteLine(" ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗███╗   ███╗ █████╗ ██████╗ ████████╗███████╗\r\n██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝████╗ ████║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝\r\n██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗██╔████╔██║███████║██████╔╝   ██║   ███████╗\r\n██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██║╚██╔╝██║██╔══██║██╔══██╗   ██║   ╚════██║\r\n╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║██║ ╚═╝ ██║██║  ██║██║  ██║   ██║   ███████║\r\n ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝\r\n                                                                                             ");
            Console.WriteLine("Hello " + name + ", And Welcome To CyberSmarts Where We Will Explore CyberSecurity Together!!");
        }
    }
}
