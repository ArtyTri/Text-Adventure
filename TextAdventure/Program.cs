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
                Console.WriteLine("You start out with a quick jab to the face of the robot judge.\nYour hand breaks against the metal and the judge snaps your neck.\nOh dear, you are dead!");
            }
            Ending();
        }

        public void Pause()
        {
            string resp3;
            Console.WriteLine("You freeze time.\nAll is quiet.\nNo wind.\nNo birds chirping.\nNo cars honking.");
            Console.WriteLine("Out of the nothing you hear a cry for help not too far away.\nThe cry is deafening and gets louder as you approach the area.");
            Console.WriteLine("You come across an old man with his leg stuck under and time frozen fallen tree.\nYou heave it off of him.");
            Console.WriteLine("He stands to thank you and offers you three choices for your reward.");
            Console.WriteLine("Will you choose:\nMore money.\nSuper strength.\nX-Ray vision.");
            resp3 = Console.ReadLine();
            if (resp3 == "money")
            {
                Console.WriteLine("Time start back up and you get an alert on your phone.\nYou are now 50 million dollars richer.");
                Console.WriteLine("You get another alert.\nYou bank account is also now temporarily frozen for suspicious activity.\nGood luck explaining this one.");
            }
            else if (resp3 == "strength")
            {
                Console.WriteLine("Your muscles inflate to tremendous size.\nWithin seconds your pass-out due to loss of blood circulation to your brain as it is all going into your biceps.");
                Console.WriteLine("You die, frozen in time, a mound of muscle unable to move, but with damn sweet abs.");
            }
            else if (resp3 == "x-ray")
            {
                Console.WriteLine("To have x-ray vision your eyes have to be able to emit and then receive legitimate rays of radioactive light.");
                Console.WriteLine("This quickly causes cancerous mutations in everything you look at.\nCongrats x-ray vision turned out to be cancer rays.\nYou are now the worst super villian ever.");

            }
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
