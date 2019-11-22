using System;

namespace TextAdventure
{
    public class Program
    {
        static void Main()
        {
            string resp1;
            Program prog = new Program();
            Console.WriteLine("You discover a book.");
            Console.WriteLine("Will send you backwards in time, or pause time, or forward in time.");
            Console.WriteLine("What will you do?");
            resp1 = Console.ReadLine();

            if (resp1 == "forward")
            {
                prog.Forward();
            }
            else if (resp1 == "pause")
            {
                prog.Pause();
            }
            else if (resp1 == "backward")
            {
                prog.Backward();
            }

        }

        public void Forward()
        {
            Console.WriteLine("You go forward in time.\nThere is nothing.\nYou die.");
            Ending();
        }

        public void Pause()
        {

        }

        public void Backward()
        {

        }

        public void Ending()
        {
            Console.WriteLine("The game is over.");
        }
    }
}
