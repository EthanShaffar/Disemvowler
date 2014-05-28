using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvowler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original: Nickleback is my favorite band. Their song writing cant be beat");
            Console.WriteLine("Disemvowled: " + Disemvowler("Nickleback is my favorite band. Their song writing cant be beat"));
            Console.WriteLine("Original: How many bears could bear grylls grill if bear grylls could grill bears" );
            Console.WriteLine("Disemvowled: " + Disemvowler("How many bears could bear grylls grill if bear grylls could grill bears"));
            Console.WriteLine("Original: I'm a code ninja, baby. I make the functions and make the calls!");
            Console.WriteLine("Disemvowled: " + Disemvowler("I'm a code ninja, baby. I make the functions and make the calls!"));

            Console.ReadKey();
        }
        //This function will take a string of any length and take all vowels (excluding y) and place
        //them in a separate string while printing both strings out.
        static string Disemvowler(string inString)
        {
            var deVowel = ""; //Placeholder for vowels.
            var normString = ""; //Placeholder for consonants.
            for (var i = 0; i < inString.Length; i++)
            {
                var Z = inString[i]; //Easy Shortcut for Typing

                //This loop will go through each specific index and confirm with an IF/ELSE statement if its a vowel
                if (Z == 'a' || Z == 'e' || Z == 'i' || Z == 'o' || Z == 'u')
                {
                   //If a vowel,  it will be removed and placed into the deVowel string
                    
                    deVowel += Z;
                    
                }
                else
                {
                    //If not vowel, it will be returned to string.
                    normString += Z;
                }
            }
            return normString; //returns the devowled string 
        }
    }
}
