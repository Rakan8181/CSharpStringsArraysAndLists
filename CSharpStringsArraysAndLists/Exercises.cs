using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen
        public static void task1()
        {
            double[] Array1 = { 1.1, 2.2, 7.9 };
            Console.WriteLine(string.Join(" ", Array1));
        }

        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 

        public static void byteArray()
        {
            byte[] array = { 104, 101, 108, 108, 111 };
            string s = string.Join(", ", array);
            Console.Write(s);

            //Don't really understand what byte arrays are and what they are used for
        }

        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out

        public static void temperatures()
        {
            List<double> temperatureList = new List<double> { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 1.1, 2.2, 3.3, 4.4, 5.5 };
            int l = temperatureList.Count;
            Console.WriteLine($"The length of the list is {l}");
            double minimum = temperatureList.Min();
            double maximum = temperatureList.Max();
            double average = temperatureList.Average();
            Console.WriteLine($"The minimum is {minimum} and the max is {maximum} and the average is {average}");
            temperatureList.Sort();
            Console.WriteLine($"Sorted list in ascending order is: {string.Join(", ", temperatureList)}");

        }

        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a list.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out     

        static public void Students()
        {
            List<(string f, string s, string dob)> tuple = new List<(string f, string s, string dob)>();
            tuple.Add(("Rak", "S", "09/08/2004"));
            tuple.Add(("Alex", "R", "11/09/2005"));

            List<List<string>> data = new List<List<string>>();
            List<int> after2010 = new List<int>();
            List<string> person1 = new List<string>();
            person1.Add("R");
            person1.Add("S");
            person1.Add("02/02/2005");
            data.Add(person1);
            
            List<string> person2 = new List<string>();
            person2.Add("A");
            person2.Add("R");
            person2.Add("02/02/2010");
            data.Add(person2);
            
            List<string> person3 = new List<string>();
            person3.Add("R");
            person3.Add("A");
            person3.Add("01/01/2011");
            data.Add(person3);

            foreach (var l in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 2)
                    {
                        string date = l[i];
                        string[] d = date.Split("/");
                        string year = d[2];
                        int y = Int16.Parse(year);
                        if (y > 2010)
                        {
                            after2010.Add(y);
                        }
                    }
                }
            }
            int numStudents = after2010.Count;
            Console.WriteLine($"{numStudents} have a birthday after 2010");

            //full names#
            List<string> fullnames = new List<string>();
            foreach (var l in data)
            {
                string fullname = l[0] + " " + l[1];
                fullnames.Add(fullname);
            }
            Console.WriteLine(string.Join(", ", fullnames));


        }

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.void
        public static void PigLatin(string input)
        {
            string[] stringArray = input.Split(" ");
            string newSentence = " ";

            for (int i = 0; i < stringArray.Length; i++)
            {
                string word = stringArray[i];
                string first = word.Substring(0, 1);
                string last = word.Substring(1, word.Length - 1);
                string newWord = last + first + "ay ";
                newSentence += newWord;


                
            }
            Console.WriteLine(newSentence);
        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
