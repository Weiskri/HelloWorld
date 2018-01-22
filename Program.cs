using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Part one greetings statement 
            //string messageOne = "Hello World";
            //string messageTwo = "I am Spartacus";

            //// Part two Spartacus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            //// Part three display variable values
            //Console.WriteLine(messageOne); // displays initial greeting to console
            //Console.WriteLine(messageTwo);

            //// Part four mathematical, bool, and char examples
            //Console.WriteLine(ageOne + ageTwo); // addition example
            //Console.WriteLine(heightOne - heightTwo); // subtraction example
            //Console.WriteLine(weightOne * weightTwo); // multiplication example
            //Console.WriteLine(isGodLikeOne); // bool example
            //Console.WriteLine(genderMale); // char example

            //// Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            //// Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            //// Part seven increment and decrement examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //// Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am" + " " + ageOne + " " + "years old, and yes it's" + " " + isGodLikeOne + " " + "I am godlike.");
            //Console.WriteLine("I weigh around" + " " + weightOne + " " + "pounds, and I am around" + " " + heightOne + " " + "inches tall.");
            //Console.WriteLine("My father is {0} years old, and yes it's {1} he is a god.", ageThree, isGodLikeOne);
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //// Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); // prints HELLO
            //Console.WriteLine(myGreeting.ToLower()); // prints hello
            //Console.WriteLine(myGreeting); // prints Hello

            //Console.WriteLine("Enter a color, please.");
            //string response = Console.ReadLine();

            //if (response.ToLower().Equals("red"))
            //{
            //    Console.WriteLine("Roses can be red. Also, lillies.");
            //}

            ////Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Console.WriteLine("Phil said, \"You've got red on you\"."); // how to do quotations in string
            //Console.WriteLine("This is the first line. \nSecond line."); // how to write on a second line
            //Console.WriteLine("\tThis line is indented."); // indent a new line

            // Part eleven conditional statements

            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            //Console.WriteLine("What is the distance to {0}", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Vesuvius.");
            //}

            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola.");
            //}

            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria.");
            //}

            //Console.WriteLine("What is your rank?");
            //string rank = Console.ReadLine();
            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());
            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, and grab your marching boots.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

        //string vesuvius;
        //string nola;
        //string nuceria;

        //// solicit user input example
        //Console.WriteLine("What is the weather in {0}?", city1);
        //vesuvius = Console.ReadLine();
        //Console.WriteLine("What is the weather in " + city2 + "?");
        //nola = Console.ReadLine();
        //Console.WriteLine("What is the weather in Nuceria?");
        //nuceria = Console.ReadLine();

        // Part twelve

        //Console.WriteLine("What is your current rank soldier?");
        //string rank = Console.ReadLine();

        //Console.WriteLine("What is your age soldier?");
        //int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your job soldier?");
        string job = Console.ReadLine().ToLower();

        //if ((rank == "officer") || (age<=26))
        //    {
        //        Console.WriteLine("Get your gear, kiss your family goodbye, and grab your marching boots.");
        //         }
        //else if ((job == "cook") || (age<=26))
        //    {
        //        Console.WriteLine("My army has to eat. Pack your pots and pans.");
        //    }
        //else
        //    {
        //        Console.WriteLine("Sorry, you are staying home.");
        //    }

        switch (job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword.");
                    break;
                case "archers":
                    Console.WriteLine("You will carry a bow and arrow.");
                    break;
                case "supply":
                    Console.WriteLine("You will carry pots and pans.");
                    break;
                case "specialist":
                    Console.WriteLine("You will operate the catapult.");
                    break;
                default:
                    Console.WriteLine("You will ride horseback.");
                    break;
                
            }
          

            // global variables: in Main, but located outside of any if statements, have access to that variable anywhere in Main
            // local variables: defined in curly braces, in if statements, local to the method, case, statement, etc.











        }
    }
}