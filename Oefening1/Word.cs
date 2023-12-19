using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    public class Word
    {
        /*public string W { get; set; }   */     

        //public string GetLenght(string zin)
        //{
        //    int charcount = 0;
        //    foreach (char ch in zin)
        //    {
        //        charcount++;                
        //    }
        //    return $"Your sentence has a total of {charcount} characters"; 
        //}
         public char ch;

        public void GetLenght(string z)
        {
            int charcount = 0;
            foreach (char ch in z)
            {
                charcount++;
            }
            Console.WriteLine($"Your sentence has a total of {charcount} characters"); 
        }
        public void WordsToArray(string z) 
        {
            string inputZ= z;

            //to convert a string into an string array:
            string[] ss = inputZ.Select(x => x.ToString()).ToArray();
            int count = 0;
            for(int i = 0; i < ss.Length; i++) 
            {
                if (ss[i] == " ")
                {
                    continue;
                }
                else
                {
                    count++;
                }
                
            }
            Console.WriteLine($"Your sentence has a total of {count} characters, spaces excluded");            
        }
        public void CountWordsInArray(string zin)
        {            
            string s = zin;
            int countwords = 0;
            string[] wordsarray = s.Split(' ');
            foreach (string s2 in wordsarray) 
            {
                countwords++;
            }
            Console.WriteLine($"Your sentence has a total of {countwords} words");
        }
        public void GetZin()
        {
            string zin;            
            Console.Write("Enter a sentence:  ");
            zin = Console.ReadLine();
                     
            GetLenght(zin); 
            WordsToArray(zin);
            CountWordsInArray(zin);
        }
    }
}
