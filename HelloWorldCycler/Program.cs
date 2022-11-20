using System;
using System.Collections.Generic;
using System.Threading;

namespace HelloWorldCycler
{
    class Program
    {
        // initialize alphabet list
        public static List<string> characters = new List<string> {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            // empty space
            " ",
            // CAPITALS 
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            // numbers
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            // misc
            "/",
            "\\", // this is represented as a single backslash i think?
            "-",
            "+",
            "~",
            "'",
            ",",
            "!",
            "?",
            "’", // weird apostrophe..?
            ".",
            ".",
            "“",
            "”",
        };

        static void Main(string[] args)
        {
            string filler = string.Empty;
            // enter funny string
            Console.WriteLine("Enter some words!");
            string helloWorld = Console.ReadLine();
            char[] helloWorldLetters = helloWorld.ToCharArray();
            helloWorldLetters.ToString();
            int counter = 0;

        restart:
            foreach (string letter in characters)
            {

                Console.WriteLine(filler + letter);
                //Console.WriteLine(helloWorldLetters[counter].ToString());

                // toString is needed here
                if (letter == helloWorldLetters[counter].ToString())
                {
                    filler = filler + letter;
                    //Console.WriteLine(filler);
                    counter++;


                    if (counter >= helloWorldLetters.Length)
                    {
                        goto end;
                    }
                    else
                    {
                        // purely for show
                        Thread.Sleep(62);
                        // restart loop
                        goto restart;
                    }
                }
            }
        end:
            Console.ReadLine();
            //Console.WriteLine(filler);
        }
    }
}
