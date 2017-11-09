using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList List = new RoverList();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words\
            List.Add("1");
            List.Add("2");
            List.Add("4");
            List.Add("5");

            List.Add(2, "3");

            // TODO:  Print out the list
            List.ListNodes();
            Console.WriteLine("test");
            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

           /* for( int i = 0; i < Count; i++)
            {
                List.RemoveAt(2);
            }

            List.ListNodes();*/

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
