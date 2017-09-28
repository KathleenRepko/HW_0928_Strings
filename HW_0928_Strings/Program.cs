using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_0928_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // .Length Property

            //Find the length of your first name and print it.

            //string givenName = "Kathleen";
            //int kathleenLength = givenName.Length;
            //Console.WriteLine(kathleenLength);


            //Find the length of your last name and print it.

            //string lastName = "Repko";
            //int repkoLength = lastName.Length;
            //Console.WriteLine(repkoLength);


            //If the first name is longer than the last name, print "First is longer."

            //if(kathleenLength > repkoLength)
            //{
            //    Console.WriteLine("First is longer.");
            //}

            //If the first name and last name are the same length, print "Samsies!"

            //else if(kathleenLength == repkoLength)
            //{
            //    Console.WriteLine("Samsies!");
            //}

            //Otherwise, print "last must be longer!"

            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}

            //EXTENSION: Get user input for the first and last name instead of hardcoding, such as string fName = "Mary";

            //Find the length of your first name and print it.

            //Console.WriteLine("Please enter your first name.");
            //string userFirstName = Console.ReadLine();
            //int userFirstLength = userFirstName.Length;
            //Console.WriteLine(userFirstLength);


            ////Find the length of your last name and print it.

            //Console.WriteLine("Please enter your last name.");
            //string userLastName = Console.ReadLine();
            //int userLastLength = userLastName.Length;
            //Console.WriteLine(userLastLength);

            //If the first name is longer than the last name, print "First is longer."

            //if (userFirstLength > userLastLength)
            //{
            //    Console.WriteLine("First is longer.");
            //}

            //If the first name and last name are the same length, print "Samsies!"

            //else if (userFirstLength == userLastLength)
            //{
            //    Console.WriteLine("Samsies!");
            //}

            //Otherwise, print "last must be longer!"

            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}


            // Escaping Special Characters

            // Using the escape sequences for tab, backslash, new line, and bell sound, 
            // print this result using only ONE Console.WriteLine(...).

            //Console.WriteLine("This is a tab \t.\nThis is a backslash \\.\nAnd this is a bell sound.\a");


            // Comparing Strings for Equality* First try the following using == and then try it using .Equals()

            // Create a variable and assign a person's first name to it.
            // Create a variable and assign a different person's first name to it.
            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            //string personOne = "Tom";
            //string personTwo = "Tom";
            //if(personOne == personTwo)
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}

            //bool namesEqual1 = (personOne == personTwo);
            //bool namesEqual2 = (personOne.Equals(personTwo));
            //if (namesEqual1 == true)
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}
            //if (namesEqual2 == true)
            //{
            //    Console.WriteLine("The names are the same.");
            //        }
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}


            // Concatenation* First try the following using +and then try it using .Equals()

            // Ask the user for his / her first name.
            // Ask the user for his / her last name.
            // Using concatenation, print the user's full name including a space to separate the names.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName);

            //string fullName = string.Concat(firstName, " ", lastName);
            //Console.WriteLine(fullName);


            // String Methods

            // Ask the user to guess the type of pet(Hint to the user it's the opposite of a dog)
            // Assign an answer variable to the answer of cat.
            // If they guess cat correctly, print "You guessed correctly!"
            // If they guess incorrectly, print "You guessed incorrectly..."
            // Use the ToLower() or ToUpper() methods to ensure if they enter cat or CAT or Cat, it will be correct.

            //Console.WriteLine("Guess the type of pet I am thinking of and enter the name.");
            //string userGuess = Console.ReadLine();
            //string correctAnswer = "cat";
            //if(userGuess.ToLower() == correctAnswer)
            //{
            //    Console.WriteLine("You guessed correctly!");
            //}
            //else
            //{
            //    Console.WriteLine("You guessed incorrectly.");
            //}

        

        }
    }
}
