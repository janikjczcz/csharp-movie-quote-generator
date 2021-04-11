using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMovieQuoteGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-- Console Movie Quote Generator v 1.0 --");
            Console.WriteLine("-----------------------------------------");

            bool cont = true;

            while(cont)
            {
                // arrays with quotes
                // action
                string[] action = { "\"Dead or alive, you're coming with me.\" (RoboCop)", "\"I never broke the law. I am the law!\" (Judge Dredd)", "\"I will look for you, I will find you, and I will kill you.\" (Taken)", "\"Yippie-ki-yay, motherf***er.\" (Die Hard)", "\"Hasta la vista, baby.\" (Terminator 2: Judgement Day)", "\"This is Sparta!\" (300)", "\"Say hello to my little friend.\" (Scarface)", "\"I’ll be back.\" (Terminator)", "\"I love the smell of napalm in the morning.\" (Apocalypse Now)", "\"I feel the need – the need for speed.\" (Top Gun)", "\"Get off my plane!\" (Air Force One)", "\"Bond. James Bond.\" (Dr. No)", "\"If it bleeds, we can kill it.\" (Predator)", "\"Let’s put a smile on that face.\" (The Dark Knight)" };
                // disney
                string[] disney = { "\"The only way to get what you want in this world is through hard work\" (The Princess and the Frog)", "\"Success doesn’t come for free. You have to do whatever it takes to seize your moment.\" (Coco)", "\"Take her to the moon for me, okay?\" (Indside Out)", "\"There’s no one I’d rather be than me.\" (Wreck-It Raph)", "\"Like so many things, it’s not what’s outside but what’s inside that counts.\" (Aladdin)", "\"Some people are worth melting for.\" (Frozen)", "\"Our fate lives within us, you only have to be brave enough to see it.\" (Brave)", "\"Ohana means family, family means nobody gets left behind.\" (Lilo and Stitch)", "\"I never look back, darling! It distracts from the now.\" (Incredibles)", "\"Oh yes, the past can hurt. But the way I see it, you can either run from it or learn from it.\" (The Lion King)", "\"The flower that blooms in adversity is the most rare and beautiful of all.\" (Mulan)", "\"Think happy thoughts.\" (Peter Pan)", "\"Just keep swimming!\" (Finding Nemo)", "\"Always let your conscience be your guide.\" (Pinocchio)" };
                // sports
                string[] sports = {"\"Glory Lasts Forever\" (The Replacements)", "\"I Love Brian Piccolo. And I'd Like All of You to Love Him, Too.\" (Brian's Song)", "\"White Men Can't Jump.\" (White Men Can't Jump)", "\"Yo, Adrian!\" (Rocky)", "\"There's No Crying in Baseball!\" (A League of Their Own)", "\"So I Got That Goin' for Me, Which Is Nice.\" (Caddyshack)", "\"You make sure they remember, forever, the night they played the Titans!\" (Remember The Titans)", "\"If You Can Dodge a Wrench, You Can Dodge a Ball.\" (Dodgeball)", "\"Money Won Is Twice as Sweet as Money Earned.\" (The Color of Money)", "\"Show Me the Money!\" (Jerry Maguire)", "\"I Coulda Been Somebody\" (On the Waterfront)",
 "\"If You Build It, He Will Come.\" (Field of Dreams)", "\"I Don’t Play Defense.\" (Space Jam)", "\"Juuuuuuuust a Bit Outside.\" (Major League)" };
                // horror
                string[] horror = { "\"I Never Drink...Wine.\" (Dracula)", "\"One, Two, Freddy's Coming For You...\" (A Nightmare On Elm Street)", "\"By The Way, I Would Have Voted For Obama For A Third Term, If I Could.\" (Get Out)", "\"He Came Home.\" (Halloween)", "\"Swallow This.\" (Evil Dead II)", "\"They're Here.\" (Poltergeist)", "\"A Census Taker Once Tried To Test Me. I Ate His Liver With Some Fava Beans And A Nice Chianti.\" (The Silence Of The Lambs)", "\"It's Alive! It's Alive!\" (Frankenstein)", "\"I See Dead People.\" (The Sixth Sense)", "\"You're Gonna Need A Bigger Boat.\" (Jaws)", "\"Do You Like Scary Movies?\" (Scream)", "\"They're Coming To Get You, Barbara.\" (Night Of The Living Dead)", "\"Do You Want To Play A Game?\" (Saw)", "\"Here's Johnny!\" (The Shining)" };

                
                Console.WriteLine();
                Console.WriteLine("Choose movie genre:");
                Console.WriteLine();
                Console.WriteLine("1 - Action");
                Console.WriteLine("2 - Disney");
                Console.WriteLine("3 - Sports");
                Console.WriteLine("4 - Horror");
                Console.WriteLine();
                Console.WriteLine("Do you want to exit the application? Type Q");
                Console.WriteLine();
                
                char opt = Console.ReadKey().KeyChar;
                
                Console.WriteLine();
                
                bool correctOpt = true;
                
                switch (opt)
                {
                    case '1':
                        {
                            Random actionRand = new Random();
                            int actionIndex = actionRand.Next(action.Length);
                            Console.WriteLine();
                            Console.WriteLine($"{action[actionIndex]}");
                            cont = true;
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            break;
                        }
                    case '2':
                        {
                            Random disneyRand = new Random();
                            int disneyIndex = disneyRand.Next(disney.Length);
                            Console.WriteLine();
                            Console.WriteLine($"{disney[disneyIndex]}");
                            cont = true;
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            break;
                        }
                    case '3':
                        {
                            Random sportsRand = new Random();
                            int sportsIndex = sportsRand.Next(sports.Length);
                            Console.WriteLine();
                            Console.WriteLine($"{sports[sportsIndex]}");
                            cont = true;
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            break;
                        }
                    case '4':
                        {
                            Random horrorRand = new Random();
                            int horrorIndex = horrorRand.Next(horror.Length);
                            Console.WriteLine();
                            Console.WriteLine($"{horror[horrorIndex]}");
                            cont = true;
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue");
                            break;
                        }
                    case 'q':
                        {
                            Console.WriteLine();
                            cont = false;
                            correctOpt = true;
                            break;
                        }
                    default:
                        correctOpt = false;
                        break;
                    
                    
                }
                
                if (!correctOpt)
                {
                    Console.WriteLine("Option selected doesn't exist, please try again");
                    Console.WriteLine("Press any key to continue.");
                }

                if (cont == false)
                {
                    Console.WriteLine("Thank you for using Console Movie Quote Generator v 1.0");
                    Console.WriteLine("Press any key to exit application.");
                }
                Console.ReadKey();
            }
        }
    }
}
