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
            string input = "";
            string check;
            int pos = List.Count - 1;
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words\
            List.Add("1");
            List.Add("2");
            List.Add("3");
            List.Add("4");
            List.Add("5");
            List.Add("6");
            List.Add("7");
            List.Add("8");
            List.Add("9");
            List.Add("10");
            List.Add("11");
            List.Add("12");
            List.Add("13");
            List.Add("14");
            List.Add("15");
            List.Add("16");

            // TODO:  Print out the list
            List.ListNodes();
            Console.WriteLine("");

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

            for ( int i = 2; i < List.Count; i += 2)
            {
                List.RemoveAt(i);
            }

            List.ListNodes();
            Console.WriteLine("");

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            Console.WriteLine("Input words into the list(type \"done\" when finished):");
            while (input != "done")
            {
                input = Console.ReadLine();
                if (input != "done")
                {
                    List.Add(input);
                }
            }
            List.ListNodes();
            Console.WriteLine("");
            input = "";
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            Console.WriteLine("Input words into the top of the list(type \"done\" when finished):");
            while (input != "done")
            {
                input = Console.ReadLine();
                if (input != "done")
                {
                    List.Add(0, input);
                }
            }
            List.ListNodes();
            Console.WriteLine("");

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            //while(List.ElementAt(pos) != null)
            while(pos >= 0)
            {
                check = (String)(List.ElementAt(pos).Data);
                if (check.Length % 2 == 1)
                {
                    List.RemoveAt(pos);
                }
                pos--;
            }
            List.ListNodes();
            Console.WriteLine("");
            
            // TODO:  Clear the list
            // TODO:  Print out the list
            List.Clear();
            List.ListNodes();



        }
    }
}
