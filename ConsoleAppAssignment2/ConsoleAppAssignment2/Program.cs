using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // a string array that says today is a good day !
            string[] myArray = { "Today", "is", "a", "good", "day", "!" };
            Console.WriteLine("PLease enter text here");
            string addOn = Console.ReadLine();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i] + addOn;
            }
            for (int k = 0; k < myArray.Length; k++)
            {
                Console.WriteLine(myArray[k]);
            }
            
            //int j = 0;

            //Infinite loop
           // while (j >= 0)
            {
                //Console.WriteLine(j);
               // j++;
            }
            //Infinite loop that will always execute at least once
           // do
            {
               // Console.WriteLine(j);
                //j++;
            }
           // while (j > 0);

            // loop using the < operator
           // while (j < 100)
            {
               // Console.WriteLine(j);
               // j++;
            }

            // loop using the <= operator
           // while (j <= 100)
            {
               // Console.WriteLine(j);
              //  j++;
            }


            //Unique List from Aa-Zz
            List<string> uniqueList = new List<string>() {"Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg", "Hh", "Ii", "Jj", "Kk", "Ll", "Mm", "Nn", "Oo", "Pp", "Qq", "Rr", "Ss", "Tt", "Uu", "Vv", "Ww", "Xx", "Yy", "Zz"};
            Console.WriteLine("Pick a letter to see what elements contain that letter");
            string letter = Console.ReadLine();
            bool notInList = true;
            foreach (string element in uniqueList)
            {
                if (element.Contains(letter))
                {
                    // when you pick any letter that is Aa - Zz it will print out this 
                    Console.WriteLine("The element containing the letter (" + letter + ") is at index " + uniqueList.IndexOf(element));
                    notInList = false;
                    break;
                }
            }
            if (notInList == true)
            {
                // if you pick a letter that isnt Aa-Zz it will print out this 
                Console.WriteLine("The list does not contain the letter (" + letter + ").");
            }
        
            // duplicated words in a list I, am, very, happy, and sad     
            List<string> identicalList = new List<string>() { "I", "am", "very", "happy", "I", "am", "very", "sad", "happy", "sad" };
            Console.WriteLine("Please type a word you would like to search for in the list: ");
            string word = Console.ReadLine();
            bool theList = true;

            foreach (string e in identicalList)
            {
                for (int i = 0; i < identicalList.Count; i++)
                {
                    string e2 = identicalList[i];
                    if (e.Contains(identicalList[i]) && identicalList.IndexOf(e) != i)
                    {
                        Console.WriteLine("There are identical elements at the indices(" + identicalList.IndexOf(e) + ") and (" + i + ").");
                    }
                }
                if (e.Contains(word))
                {
                    Console.WriteLine("The element containing the letter (" + word + ") is at index " + identicalList.IndexOf(e));
                    theList = false;                   
                }
            }
            if (theList == true)
            {
                Console.WriteLine("The list does not contain the letter (" + word + ").");
            }
            List<string> checkList = new List<string> { };

            foreach (string e in identicalList)
            {
                if (checkList.Contains(e))
                {
                    Console.WriteLine("This element is (" + e + "), and it has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine("This element is (" + e + "), and it has not appeared yet in the list.");
                    checkList.Add(e);
                }
            }
            Console.ReadLine();
        }
    }
}
