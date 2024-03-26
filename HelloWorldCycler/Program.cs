using System;
using System.Collections.Generic;
using System.Threading;

namespace HelloWorldCycler
{
    class Program
    {
        // initialize alphabet list
        static readonly List<char> _Characters = new List<char> {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            // empty space
            ' ',
            // CAPITALS 
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z',
            // numbers
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '0',
            // misc
            '/',
            '\\', // this is represented as a single backslash i think?
            '-',
            '+',
            '~',
            '\'',
            ',',
            '!',
            '?',
            '’', // weird apostrophe..?
            '.',
            '.',
            '“',
            '”',
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words!");

            // read input
            string helloWorld = Console.ReadLine();
            while (string.IsNullOrEmpty(helloWorld))
            {
                Console.WriteLine("Please enter some words!");
                helloWorld = Console.ReadLine();
            }
            char[] helloWorldLetters = helloWorld.ToCharArray();
            int counter = 0;
            
            string filler = string.Empty;
            
            // this label does all of the work
            main:
            
            // loop through our characters
            foreach (char letter in _Characters)
            {
                // this creates a cool effect
                Console.WriteLine(filler + letter);
                if (letter == helloWorld[counter])
                {
                    filler += letter;
                    counter++;
                    
                    // if we're done
                    if (counter >= helloWorldLetters.Length)
                    {
                        goto end;
                    }
                    // purely for show
                    Thread.Sleep(62);
                    
                    // if we've found the letter, we need to break out of the loop and restart it
                    goto main;
                }
            }
            
            end:
            // don't close the console until the user presses a key 
            Console.ReadKey();
        }
    }
}
