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
            Console.WriteLine("Will send you backward in time, or pause time, or forward in time.");
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
            string resp2;
            Console.WriteLine("You go forward in time.\nThe world is bathed in chrome.\nAll things chrome all the time.");
            Console.WriteLine("You discover that humanity has long since been replaced by the robots they created.");
            Console.WriteLine("You are quickly discovered and sent to a court of robot law.\nHow do you defend yourself?");
            Console.WriteLine("Dance.\nPlead the 75th\nTry to overpower the robots physically.");
            resp2 = Console.ReadLine();
            if (resp2 == "dance")
            {
                Console.WriteLine("You break into freeform dance.\nAfter 3 hours of intense move busting the robots submit.\nYou are now leader of the robotic world and Supreme Chancellor of Dance.");
            }
            else if (resp2 == "plead")
            {
                Console.WriteLine("With your extremely luck guess as the the complexies of robot law, you are able to get out of the death penalty on a technicality.");
                Console.WriteLine("You instead have your memory wiped and are sent back in time.\nYou awaken and think the whole ordeal to be an odd dream.");
            }
            else if (resp2 == "overpower")
            {
                Console.WriteLine("You start out with a quick jab to the face of the robot judge.\nYour hand breaks against the metal and the judge snaps your neck. Oh dear, you are dead!");
            }
            Ending();
        }

        public void Pause()
        {
            Console.WriteLine("You freeze time.\nYou die.");
            Ending();
        }

        public void Backward()
        {
            Console.WriteLine("You go backward in time.\nYou die.");
            Ending();
        }

        public void Ending()
        {
            Console.WriteLine("The game is over.");
        }
    }
}
